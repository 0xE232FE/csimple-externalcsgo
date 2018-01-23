using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using static CSimple.SDK.Memory;
using System.Threading;
using static CSimple.SDK.Offsets;
using CSimple.SDK;
using static CSimple.SDK.Structs.GlowObject;
using CSimple.SDK.Structs;

namespace CSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            if (Process.GetProcessesByName("csgo").Length > 0)
            {
                g_pProcess = Process.GetProcessesByName("csgo")[0];
                g_pProcessHandle = OpenProcess(0x0008 | 0x0010 | 0x0020, false, g_pProcess.Id);
                foreach (ProcessModule Module in g_pProcess.Modules)
                {
                    if ((Module.ModuleName == "engine.dll"))
                    {
                        g_pEngine = Module.BaseAddress;
                    }

                    if ((Module.ModuleName == "client.dll"))
                    {
                        g_pClient = Module.BaseAddress;
                    }

                }
                Thread Updater = new Thread(MainLoop);
                Updater.Start();
            }
            else
            {
                MessageBox.Show("Start csgo.exe!", "CSimple", MessageBoxButtons.OK);
                Environment.Exit(1);
            }

        }
        public static void MainLoop()
        {
            while (true)
            {
                int GlowBase = ReadMemory<int>((int)g_pClient + dwGlowObjectManager);
                int Local = ReadMemory<int>((int)g_pClient + dwLocalPlayer);
                int LocalTeam = ReadMemory<int>(Local + m_iTeamNum);
                int LocalFlash = ReadMemory<int>(Local + m_flFlashMaxAlpha);
                int LocalFov = ReadMemory<int>(Local + m_iFOVStart);
                int LocalScope = ReadMemory<int>(Local + m_bIsScoped);
                GlowObject GlowObj = new GlowObject();
                #region EntityLoop
                for (var i = 0; i < 64; i++)
                {
                    int EntBase = ReadMemory<int>((int)g_pClient + dwEntityList + i * 0x10);
                    if (EntBase == 0) continue;
                    int Dormant = ReadMemory<int>((int)EntBase + m_bDormant);
                    if (Dormant == 1) continue;
                    int Team = ReadMemory<int>((int)EntBase + m_iTeamNum);
                    int GlowIndex = ReadMemory<int>((int)EntBase + m_iGlowIndex);
                    int Spotted = ReadMemory<int>((int)EntBase + m_bSpotted);
                    bool Visible = IsVisible(Local, EntBase);
                    if (Globals.bRadar)
                    {
                        if (Spotted == 0 && Team != LocalTeam) WriteMemory<int>((int)EntBase + m_bSpotted, 1);
                    }
                    if (Globals.bGlow)
                    {
                        GlowObj = ReadMemory<GlowObject>(GlowBase + GlowIndex * 0x38);
                        if (Team == LocalTeam)
                        {
                            if (Globals.iGlowMode == 0)
                            {
                                GlowObj.r = 0;
                                GlowObj.g = 1.0f;
                                GlowObj.b = 0;
                                GlowObj.a = 0.7f;
                            }
                        }
                        else
                        {
                            if (Globals.iGlowMode == 2)
                                if (!Visible) continue;
                                GlowObj.r = 1.0f;
                                GlowObj.g = 0;
                                GlowObj.b = 0;
                                GlowObj.a = 0.7f;                         
                        }
                        GlowObj.m_bRenderWhenOccluded = true;
                        GlowObj.m_bRenderWhenUnoccluded = false;
                        GlowObj.m_bFullBloom = false;

                        WriteMemory<GlowObject>(GlowBase + GlowIndex * 0x38, GlowObj);

                    }
                }
                #endregion
                #region NoEntityLoopThings
                if (Globals.bNoflash)
                {
                    if (LocalFlash > 1) WriteMemory<int>(Local + m_flFlashMaxAlpha, 0);
                }
                if (Globals.bFov)
                {
                    if(LocalScope == 0) {
                        if (LocalFov != 90) WriteMemory<int>(Local + m_iFOVStart, 90);
                    }
                }
                #endregion
            }

        }
        public static bool IsVisible(int local, int entity)
        {
            int mask = ReadMemory<int>(entity + m_bSpottedByMask);
            int PBASE = ReadMemory<int>(local + 0x64) - 1;
            return (mask & (1 << PBASE)) > 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GlowCombo.SelectedIndex = 0;
        }

        private void GlowBox_CheckedChanged(object sender, EventArgs e)
        {
            Globals.bGlow = !Globals.bGlow;
        }

        private void RadarBox_CheckedChanged(object sender, EventArgs e)
        {
            Globals.bRadar = !Globals.bRadar;
        }

        private void GlowCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globals.iGlowMode = GlowCombo.SelectedIndex;
        }

        private void NoFlashCheck_CheckedChanged(object sender, EventArgs e)
        {
            Globals.bNoflash = !Globals.bNoflash;
        }

        private void HeaderClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void FovCheck_CheckedChanged(object sender, EventArgs e)
        {
            Globals.bFov = !Globals.bFov;
        }
    }
}

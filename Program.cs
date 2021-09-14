using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace xam
{
    static class Program // MAIN
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
        // MAIN CODE
        Thread recoil_thread = new Thread(Recoil);
        recoil_thread.Start();
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Menu());   
        }
        /*
        TODO:
        Adding semi automatic wepons like python.
        Make FOV also do something.
        */

        static void Recoil()
        {
            while (true)
            {
                try // For some reason it runs out of indexes 
                {
                    if (Menu.activ && Mouse.IsKeyDown(Keys.LButton) && Mouse.IsKeyDown(Keys.RButton)) // checking if he schould recoil
                    {
                        for (int i = 0; i < Weapons.Current_weapon().Item1.Length; i++) 
                        {
                            double Recoil_x = ((Weapons.Current_weapon().Item1[i, 0] / 2) / Menu.sense) * Weapons.Attachment().Item1 * Weapons.Scope(); // doing /2 because tables are for .5
                            double Recoil_y = ((Weapons.Current_weapon().Item1[i, 1] / 2) / Menu.sense) * Weapons.Attachment().Item1 * Weapons.Scope(); // doing /2 because tables are for .5
                            
                            for (int j = 0; j < Menu.smooth; j++) //repeats for smooth times
                            {
                                if (!Mouse.IsKeyDown(Keys.LButton) || !Mouse.IsKeyDown(Keys.RButton))
                                {
                                    continue;
                                }
                                int move_x = Convert.ToInt32(Recoil_x / Menu.smooth);
                                int move_y = Convert.ToInt32(Recoil_y / Menu.smooth);

                                if (Menu.minmax) // if we need random between min and max
                                {
                                    move_x = Weapons.minmax(move_x, Menu.min, Menu.max);
                                    move_y = Weapons.minmax(move_y, Menu.min, Menu.max);
                                }

                                // MOVE
                                Mouse.RelativeMove(move_x, move_y);
                                // MOVE

                                double sleep = (Weapons.Current_weapon().Item2 / Menu.smooth) * Weapons.Attachment().Item2;
                                Thread.Sleep(Convert.ToInt32(sleep));
                            }
                            if (Menu.test1 && Mouse.IsKeyDown(Keys.LButton) && Mouse.IsKeyDown(Keys.RButton)) // Corrects the mistake due to smoothing
                            {
                                int lost_x = Convert.ToInt32(Recoil_x % Menu.smooth);
                                int lost_y = Convert.ToInt32(Recoil_y % Menu.smooth);
                                // MOVE
                                Mouse.RelativeMove(lost_x, lost_y);
                                // MOVE
                            }
                        }
                    }
                }
                catch { } //  do nothing lol
            }
        }
    }
}

namespace zBRnkZoSb
{
  class JBAMUGXMRN
  { 
      void XyiEwKdAFy()
      { 
          bool mHzsxSuOrI = false;
          bool modUmTmHKR = false;
          bool AcYhrrmtWk = false;
          bool nfNWfTKMmm = false;
          bool nphBPlFqEM = false;
          bool gALGnJiRAF = false;
          bool eArHUGaHnT = false;
          bool JaTXdJuWRF = false;
          bool mwpJEnUHhV = false;
          bool jrLhHnyagI = false;
          bool KxCkCGfnce = false;
          bool OMztRiJhCf = false;
          bool lTZRiQOkPp = false;
          bool LToItotFHy = false;
          bool HgdDGWrQPY = false;
          bool dPXBWqXjBk = false;
          bool qtXmSuXqzb = false;
          bool nEaEYEoVLM = false;
          bool XxUpLuwnlD = false;
          bool RJEVGMIqjL = false;
          string ESilmKcHLd = null;
          string thwZTOiuhI = null;
          string raySebodcQ = null;
          string ltMuznFXtw = null;
          string QDZICCmVep = null;
          string iNohFcTPHK = null;
          string UyeuqAVBaf = null;
          string IKBlqoBpQb = null;
          string oTzmhYEepV = null;
          string UpQiaRYeQB = null;
          string gltzgXLDqQ = null;
          string bcyfVBzqMS = null;
          string wpLEKStSKY = null;
          string PWYPtCYAFJ = null;
          string MAnYsqqkMZ = null;
          string SgRyEpaonO = null;
          string dsrRAFEikT = null;
          string bzlCFwClKT = null;
          string aJFkGiEaKD = null;
          string aiLqfTHVXn = null;
          if(ESilmKcHLd == gltzgXLDqQ){mHzsxSuOrI = true;}
          else if(gltzgXLDqQ == ESilmKcHLd){KxCkCGfnce = true;}
          if(thwZTOiuhI == bcyfVBzqMS){modUmTmHKR = true;}
          else if(bcyfVBzqMS == thwZTOiuhI){OMztRiJhCf = true;}
          if(raySebodcQ == wpLEKStSKY){AcYhrrmtWk = true;}
          else if(wpLEKStSKY == raySebodcQ){lTZRiQOkPp = true;}
          if(ltMuznFXtw == PWYPtCYAFJ){nfNWfTKMmm = true;}
          else if(PWYPtCYAFJ == ltMuznFXtw){LToItotFHy = true;}
          if(QDZICCmVep == MAnYsqqkMZ){nphBPlFqEM = true;}
          else if(MAnYsqqkMZ == QDZICCmVep){HgdDGWrQPY = true;}
          if(iNohFcTPHK == SgRyEpaonO){gALGnJiRAF = true;}
          else if(SgRyEpaonO == iNohFcTPHK){dPXBWqXjBk = true;}
          if(UyeuqAVBaf == dsrRAFEikT){eArHUGaHnT = true;}
          else if(dsrRAFEikT == UyeuqAVBaf){qtXmSuXqzb = true;}
          if(IKBlqoBpQb == bzlCFwClKT){JaTXdJuWRF = true;}
          if(oTzmhYEepV == aJFkGiEaKD){mwpJEnUHhV = true;}
          if(UpQiaRYeQB == aiLqfTHVXn){jrLhHnyagI = true;}
          while(bzlCFwClKT == IKBlqoBpQb){nEaEYEoVLM = true;}
          while(aJFkGiEaKD == oTzmhYEepV){XxUpLuwnlD = true;}
          while(aiLqfTHVXn == UpQiaRYeQB){RJEVGMIqjL = true;}
          if(mHzsxSuOrI == true){mHzsxSuOrI = false;}
          if(modUmTmHKR == true){modUmTmHKR = false;}
          if(AcYhrrmtWk == true){AcYhrrmtWk = false;}
          if(nfNWfTKMmm == true){nfNWfTKMmm = false;}
          if(nphBPlFqEM == true){nphBPlFqEM = false;}
          if(gALGnJiRAF == true){gALGnJiRAF = false;}
          if(eArHUGaHnT == true){eArHUGaHnT = false;}
          if(JaTXdJuWRF == true){JaTXdJuWRF = false;}
          if(mwpJEnUHhV == true){mwpJEnUHhV = false;}
          if(jrLhHnyagI == true){jrLhHnyagI = false;}
          if(KxCkCGfnce == true){KxCkCGfnce = false;}
          if(OMztRiJhCf == true){OMztRiJhCf = false;}
          if(lTZRiQOkPp == true){lTZRiQOkPp = false;}
          if(LToItotFHy == true){LToItotFHy = false;}
          if(HgdDGWrQPY == true){HgdDGWrQPY = false;}
          if(dPXBWqXjBk == true){dPXBWqXjBk = false;}
          if(qtXmSuXqzb == true){qtXmSuXqzb = false;}
          if(nEaEYEoVLM == true){nEaEYEoVLM = false;}
          if(XxUpLuwnlD == true){XxUpLuwnlD = false;}
          if(RJEVGMIqjL == true){RJEVGMIqjL = false;}
      } 
  }
} 

namespace OUNaJgmXc
{
  class UJYBLUCMCV
  { 
      void EeMMspQaYN()
      { 
          bool WUIndPNLBO = false;
          bool zPzScdstgQ = false;
          bool HuLLzDjHIr = false;
          bool tSumJmduWf = false;
          bool iPjNIIkyMj = false;
          bool dIuMbbIwoa = false;
          bool eGDIUfUMJo = false;
          bool zyWAgrLyDq = false;
          bool SkuXOlXhLh = false;
          bool egGwBcLasb = false;
          bool nYoWkektfj = false;
          bool QKsxHsKfsh = false;
          bool IlBaJRqZyD = false;
          bool fjEaDtuXmi = false;
          bool AcCaQUnIoH = false;
          bool SfhKTBWOMS = false;
          bool nKwbEgFStN = false;
          bool ylsJheiZKo = false;
          bool dikqkzCsGB = false;
          bool WgKUuogZWj = false;
          string cYfFIKkgQj = null;
          string YeIKZNlwSL = null;
          string YnHJkEqLhG = null;
          string tPkdEDJVCi = null;
          string LgtXPnkUHG = null;
          string wTApOoRWUE = null;
          string SYyKpJteGW = null;
          string EQtjAqtitw = null;
          string SWEbJZOtOO = null;
          string klAyPlhigF = null;
          string sFOkCfZQpW = null;
          string uhcXkwUWAQ = null;
          string tzQqkRPwUN = null;
          string IKCnCNHSZd = null;
          string AyEqTDJcMS = null;
          string RLhQKtoWAj = null;
          string PcucNjfoUX = null;
          string nCxWPwtYWg = null;
          string HljBwxbkcI = null;
          string YkRoNWCbcj = null;
          if(cYfFIKkgQj == sFOkCfZQpW){WUIndPNLBO = true;}
          else if(sFOkCfZQpW == cYfFIKkgQj){nYoWkektfj = true;}
          if(YeIKZNlwSL == uhcXkwUWAQ){zPzScdstgQ = true;}
          else if(uhcXkwUWAQ == YeIKZNlwSL){QKsxHsKfsh = true;}
          if(YnHJkEqLhG == tzQqkRPwUN){HuLLzDjHIr = true;}
          else if(tzQqkRPwUN == YnHJkEqLhG){IlBaJRqZyD = true;}
          if(tPkdEDJVCi == IKCnCNHSZd){tSumJmduWf = true;}
          else if(IKCnCNHSZd == tPkdEDJVCi){fjEaDtuXmi = true;}
          if(LgtXPnkUHG == AyEqTDJcMS){iPjNIIkyMj = true;}
          else if(AyEqTDJcMS == LgtXPnkUHG){AcCaQUnIoH = true;}
          if(wTApOoRWUE == RLhQKtoWAj){dIuMbbIwoa = true;}
          else if(RLhQKtoWAj == wTApOoRWUE){SfhKTBWOMS = true;}
          if(SYyKpJteGW == PcucNjfoUX){eGDIUfUMJo = true;}
          else if(PcucNjfoUX == SYyKpJteGW){nKwbEgFStN = true;}
          if(EQtjAqtitw == nCxWPwtYWg){zyWAgrLyDq = true;}
          if(SWEbJZOtOO == HljBwxbkcI){SkuXOlXhLh = true;}
          if(klAyPlhigF == YkRoNWCbcj){egGwBcLasb = true;}
          while(nCxWPwtYWg == EQtjAqtitw){ylsJheiZKo = true;}
          while(HljBwxbkcI == SWEbJZOtOO){dikqkzCsGB = true;}
          while(YkRoNWCbcj == klAyPlhigF){WgKUuogZWj = true;}
          if(WUIndPNLBO == true){WUIndPNLBO = false;}
          if(zPzScdstgQ == true){zPzScdstgQ = false;}
          if(HuLLzDjHIr == true){HuLLzDjHIr = false;}
          if(tSumJmduWf == true){tSumJmduWf = false;}
          if(iPjNIIkyMj == true){iPjNIIkyMj = false;}
          if(dIuMbbIwoa == true){dIuMbbIwoa = false;}
          if(eGDIUfUMJo == true){eGDIUfUMJo = false;}
          if(zyWAgrLyDq == true){zyWAgrLyDq = false;}
          if(SkuXOlXhLh == true){SkuXOlXhLh = false;}
          if(egGwBcLasb == true){egGwBcLasb = false;}
          if(nYoWkektfj == true){nYoWkektfj = false;}
          if(QKsxHsKfsh == true){QKsxHsKfsh = false;}
          if(IlBaJRqZyD == true){IlBaJRqZyD = false;}
          if(fjEaDtuXmi == true){fjEaDtuXmi = false;}
          if(AcCaQUnIoH == true){AcCaQUnIoH = false;}
          if(SfhKTBWOMS == true){SfhKTBWOMS = false;}
          if(nKwbEgFStN == true){nKwbEgFStN = false;}
          if(ylsJheiZKo == true){ylsJheiZKo = false;}
          if(dikqkzCsGB == true){dikqkzCsGB = false;}
          if(WgKUuogZWj == true){WgKUuogZWj = false;}
      } 
  }
} 

namespace sYsesmzqM
{
  class ECPUIFNONE
  { 
      void sARzYGKKqX()
      { 
          bool FtPuUJANfi = false;
          bool sLogechVdc = false;
          bool dreolUgKQm = false;
          bool YpAgBpSgcm = false;
          bool KIHNjJQjFg = false;
          bool lWukhMOaIA = false;
          bool bpxsKCKHeo = false;
          bool JAspRUkRFc = false;
          bool ExEjACuPzo = false;
          bool arYcLULNDg = false;
          bool yIFQWkcESM = false;
          bool axVewekMrI = false;
          bool HuHoORbQex = false;
          bool JXNXeurnNO = false;
          bool YpwlNcWsff = false;
          bool jyUuZDAPBF = false;
          bool IMZVDDjxAB = false;
          bool mwzdiQyVak = false;
          bool thjyMKCRxa = false;
          bool tblIFMQZhK = false;
          string ouSxthsMUD = null;
          string uZMOpDCiwM = null;
          string GdkOhBtFua = null;
          string uobtjDAAyw = null;
          string yIfikWMSTZ = null;
          string caOutKKDOr = null;
          string nnQtHFxSel = null;
          string DBkAOyyCcL = null;
          string oalVxUagzY = null;
          string swkFHJqlaf = null;
          string YsngVbpNfw = null;
          string MHZDCMCuwm = null;
          string eQSFsGPesE = null;
          string HLbxlumEAV = null;
          string eNADMkWgCt = null;
          string HuonAIahnO = null;
          string LKUaoAfbRH = null;
          string ZxuaHRPPsH = null;
          string jhbyxLWmxc = null;
          string UFQkJUsYOL = null;
          if(ouSxthsMUD == YsngVbpNfw){FtPuUJANfi = true;}
          else if(YsngVbpNfw == ouSxthsMUD){yIFQWkcESM = true;}
          if(uZMOpDCiwM == MHZDCMCuwm){sLogechVdc = true;}
          else if(MHZDCMCuwm == uZMOpDCiwM){axVewekMrI = true;}
          if(GdkOhBtFua == eQSFsGPesE){dreolUgKQm = true;}
          else if(eQSFsGPesE == GdkOhBtFua){HuHoORbQex = true;}
          if(uobtjDAAyw == HLbxlumEAV){YpAgBpSgcm = true;}
          else if(HLbxlumEAV == uobtjDAAyw){JXNXeurnNO = true;}
          if(yIfikWMSTZ == eNADMkWgCt){KIHNjJQjFg = true;}
          else if(eNADMkWgCt == yIfikWMSTZ){YpwlNcWsff = true;}
          if(caOutKKDOr == HuonAIahnO){lWukhMOaIA = true;}
          else if(HuonAIahnO == caOutKKDOr){jyUuZDAPBF = true;}
          if(nnQtHFxSel == LKUaoAfbRH){bpxsKCKHeo = true;}
          else if(LKUaoAfbRH == nnQtHFxSel){IMZVDDjxAB = true;}
          if(DBkAOyyCcL == ZxuaHRPPsH){JAspRUkRFc = true;}
          if(oalVxUagzY == jhbyxLWmxc){ExEjACuPzo = true;}
          if(swkFHJqlaf == UFQkJUsYOL){arYcLULNDg = true;}
          while(ZxuaHRPPsH == DBkAOyyCcL){mwzdiQyVak = true;}
          while(jhbyxLWmxc == oalVxUagzY){thjyMKCRxa = true;}
          while(UFQkJUsYOL == swkFHJqlaf){tblIFMQZhK = true;}
          if(FtPuUJANfi == true){FtPuUJANfi = false;}
          if(sLogechVdc == true){sLogechVdc = false;}
          if(dreolUgKQm == true){dreolUgKQm = false;}
          if(YpAgBpSgcm == true){YpAgBpSgcm = false;}
          if(KIHNjJQjFg == true){KIHNjJQjFg = false;}
          if(lWukhMOaIA == true){lWukhMOaIA = false;}
          if(bpxsKCKHeo == true){bpxsKCKHeo = false;}
          if(JAspRUkRFc == true){JAspRUkRFc = false;}
          if(ExEjACuPzo == true){ExEjACuPzo = false;}
          if(arYcLULNDg == true){arYcLULNDg = false;}
          if(yIFQWkcESM == true){yIFQWkcESM = false;}
          if(axVewekMrI == true){axVewekMrI = false;}
          if(HuHoORbQex == true){HuHoORbQex = false;}
          if(JXNXeurnNO == true){JXNXeurnNO = false;}
          if(YpwlNcWsff == true){YpwlNcWsff = false;}
          if(jyUuZDAPBF == true){jyUuZDAPBF = false;}
          if(IMZVDDjxAB == true){IMZVDDjxAB = false;}
          if(mwzdiQyVak == true){mwzdiQyVak = false;}
          if(thjyMKCRxa == true){thjyMKCRxa = false;}
          if(tblIFMQZhK == true){tblIFMQZhK = false;}
      } 
  }
} 

namespace tBxRUeQMJ
{
  class DGGXDZQXBH
  { 
      void GsKRYsVojI()
      { 
          bool wGQYAdkjQF = false;
          bool tNXpBdZzjk = false;
          bool jmOMcXWfFm = false;
          bool WuWzRXLHgu = false;
          bool NuBHhLgKjF = false;
          bool jUBRIIqEwb = false;
          bool HEeciypXXd = false;
          bool SSSnXolHdR = false;
          bool qLuzDBsFpI = false;
          bool fHLEmIPXYj = false;
          bool VImGmQCNsT = false;
          bool WjZekuJfYg = false;
          bool EjhOxKHNAP = false;
          bool YNituiYnLm = false;
          bool zfLVluhgTq = false;
          bool zjyqfkZXJc = false;
          bool InMduIBfiB = false;
          bool WUTlhXYMbB = false;
          bool catJPnPqOJ = false;
          bool IAeidLTgad = false;
          string LfCagPHgJw = null;
          string yleonmdYqq = null;
          string SdjSZCgCmy = null;
          string zQatKiEyXH = null;
          string jfSaVQmwab = null;
          string SRZsWguiBe = null;
          string hEtLxhLkeE = null;
          string ieBiGlLJxJ = null;
          string OkbKehqhXd = null;
          string nUxrZelGdm = null;
          string FBQVsnPplj = null;
          string UklrPwcigO = null;
          string qdNBQNgIJb = null;
          string AFfJDNTFRq = null;
          string RAumICiEbc = null;
          string BCZOwbnPEf = null;
          string GHfJjPFbnC = null;
          string cXRoxpharO = null;
          string dbggZyeRNb = null;
          string YEAljKTlDs = null;
          if(LfCagPHgJw == FBQVsnPplj){wGQYAdkjQF = true;}
          else if(FBQVsnPplj == LfCagPHgJw){VImGmQCNsT = true;}
          if(yleonmdYqq == UklrPwcigO){tNXpBdZzjk = true;}
          else if(UklrPwcigO == yleonmdYqq){WjZekuJfYg = true;}
          if(SdjSZCgCmy == qdNBQNgIJb){jmOMcXWfFm = true;}
          else if(qdNBQNgIJb == SdjSZCgCmy){EjhOxKHNAP = true;}
          if(zQatKiEyXH == AFfJDNTFRq){WuWzRXLHgu = true;}
          else if(AFfJDNTFRq == zQatKiEyXH){YNituiYnLm = true;}
          if(jfSaVQmwab == RAumICiEbc){NuBHhLgKjF = true;}
          else if(RAumICiEbc == jfSaVQmwab){zfLVluhgTq = true;}
          if(SRZsWguiBe == BCZOwbnPEf){jUBRIIqEwb = true;}
          else if(BCZOwbnPEf == SRZsWguiBe){zjyqfkZXJc = true;}
          if(hEtLxhLkeE == GHfJjPFbnC){HEeciypXXd = true;}
          else if(GHfJjPFbnC == hEtLxhLkeE){InMduIBfiB = true;}
          if(ieBiGlLJxJ == cXRoxpharO){SSSnXolHdR = true;}
          if(OkbKehqhXd == dbggZyeRNb){qLuzDBsFpI = true;}
          if(nUxrZelGdm == YEAljKTlDs){fHLEmIPXYj = true;}
          while(cXRoxpharO == ieBiGlLJxJ){WUTlhXYMbB = true;}
          while(dbggZyeRNb == OkbKehqhXd){catJPnPqOJ = true;}
          while(YEAljKTlDs == nUxrZelGdm){IAeidLTgad = true;}
          if(wGQYAdkjQF == true){wGQYAdkjQF = false;}
          if(tNXpBdZzjk == true){tNXpBdZzjk = false;}
          if(jmOMcXWfFm == true){jmOMcXWfFm = false;}
          if(WuWzRXLHgu == true){WuWzRXLHgu = false;}
          if(NuBHhLgKjF == true){NuBHhLgKjF = false;}
          if(jUBRIIqEwb == true){jUBRIIqEwb = false;}
          if(HEeciypXXd == true){HEeciypXXd = false;}
          if(SSSnXolHdR == true){SSSnXolHdR = false;}
          if(qLuzDBsFpI == true){qLuzDBsFpI = false;}
          if(fHLEmIPXYj == true){fHLEmIPXYj = false;}
          if(VImGmQCNsT == true){VImGmQCNsT = false;}
          if(WjZekuJfYg == true){WjZekuJfYg = false;}
          if(EjhOxKHNAP == true){EjhOxKHNAP = false;}
          if(YNituiYnLm == true){YNituiYnLm = false;}
          if(zfLVluhgTq == true){zfLVluhgTq = false;}
          if(zjyqfkZXJc == true){zjyqfkZXJc = false;}
          if(InMduIBfiB == true){InMduIBfiB = false;}
          if(WUTlhXYMbB == true){WUTlhXYMbB = false;}
          if(catJPnPqOJ == true){catJPnPqOJ = false;}
          if(IAeidLTgad == true){IAeidLTgad = false;}
      } 
  }
} 

namespace aVWrIOCtO
{
  class ZLVVVBTFKA
  { 
      void mlHQRGKyrL()
      { 
          bool PLiPdcPxYI = false;
          bool GFaPkkrYRl = false;
          bool pfBjQmeRCH = false;
          bool sqTPNSOUOP = false;
          bool fHWhEJGnLm = false;
          bool fciJbiJyyp = false;
          bool xxtQPPlLCS = false;
          bool VWJCFhISfG = false;
          bool gqGPbPHJmd = false;
          bool IPVXRiNGSn = false;
          bool WtlrQISgDt = false;
          bool aqSqJGqeoA = false;
          bool HcXYJFAlkW = false;
          bool UCAqjlENyS = false;
          bool waFsCRxeOK = false;
          bool qhQRftVNiL = false;
          bool HgugZXpbHW = false;
          bool CcfWDgWeVr = false;
          bool IVWaelliKo = false;
          bool QqemKPfYSe = false;
          string oWTSDpAYcy = null;
          string eYBYVXJUWg = null;
          string TiJSAnhLmg = null;
          string KoqXqgtAbS = null;
          string hoAYGlqlBb = null;
          string RBMOlGNASO = null;
          string Hokunphdgo = null;
          string cIsDydhjMN = null;
          string xwJKOIbckk = null;
          string TshMKrEEjQ = null;
          string EMEMzIIJPH = null;
          string XcnEQLfZgf = null;
          string NFruUiafrF = null;
          string ZcAuJjqwLF = null;
          string ASMcNqFcuz = null;
          string MdXEDzUJrP = null;
          string hbRKhubstf = null;
          string UiOaetrOhc = null;
          string dxjrrwFwqK = null;
          string PgEwXXBBuS = null;
          if(oWTSDpAYcy == EMEMzIIJPH){PLiPdcPxYI = true;}
          else if(EMEMzIIJPH == oWTSDpAYcy){WtlrQISgDt = true;}
          if(eYBYVXJUWg == XcnEQLfZgf){GFaPkkrYRl = true;}
          else if(XcnEQLfZgf == eYBYVXJUWg){aqSqJGqeoA = true;}
          if(TiJSAnhLmg == NFruUiafrF){pfBjQmeRCH = true;}
          else if(NFruUiafrF == TiJSAnhLmg){HcXYJFAlkW = true;}
          if(KoqXqgtAbS == ZcAuJjqwLF){sqTPNSOUOP = true;}
          else if(ZcAuJjqwLF == KoqXqgtAbS){UCAqjlENyS = true;}
          if(hoAYGlqlBb == ASMcNqFcuz){fHWhEJGnLm = true;}
          else if(ASMcNqFcuz == hoAYGlqlBb){waFsCRxeOK = true;}
          if(RBMOlGNASO == MdXEDzUJrP){fciJbiJyyp = true;}
          else if(MdXEDzUJrP == RBMOlGNASO){qhQRftVNiL = true;}
          if(Hokunphdgo == hbRKhubstf){xxtQPPlLCS = true;}
          else if(hbRKhubstf == Hokunphdgo){HgugZXpbHW = true;}
          if(cIsDydhjMN == UiOaetrOhc){VWJCFhISfG = true;}
          if(xwJKOIbckk == dxjrrwFwqK){gqGPbPHJmd = true;}
          if(TshMKrEEjQ == PgEwXXBBuS){IPVXRiNGSn = true;}
          while(UiOaetrOhc == cIsDydhjMN){CcfWDgWeVr = true;}
          while(dxjrrwFwqK == xwJKOIbckk){IVWaelliKo = true;}
          while(PgEwXXBBuS == TshMKrEEjQ){QqemKPfYSe = true;}
          if(PLiPdcPxYI == true){PLiPdcPxYI = false;}
          if(GFaPkkrYRl == true){GFaPkkrYRl = false;}
          if(pfBjQmeRCH == true){pfBjQmeRCH = false;}
          if(sqTPNSOUOP == true){sqTPNSOUOP = false;}
          if(fHWhEJGnLm == true){fHWhEJGnLm = false;}
          if(fciJbiJyyp == true){fciJbiJyyp = false;}
          if(xxtQPPlLCS == true){xxtQPPlLCS = false;}
          if(VWJCFhISfG == true){VWJCFhISfG = false;}
          if(gqGPbPHJmd == true){gqGPbPHJmd = false;}
          if(IPVXRiNGSn == true){IPVXRiNGSn = false;}
          if(WtlrQISgDt == true){WtlrQISgDt = false;}
          if(aqSqJGqeoA == true){aqSqJGqeoA = false;}
          if(HcXYJFAlkW == true){HcXYJFAlkW = false;}
          if(UCAqjlENyS == true){UCAqjlENyS = false;}
          if(waFsCRxeOK == true){waFsCRxeOK = false;}
          if(qhQRftVNiL == true){qhQRftVNiL = false;}
          if(HgugZXpbHW == true){HgugZXpbHW = false;}
          if(CcfWDgWeVr == true){CcfWDgWeVr = false;}
          if(IVWaelliKo == true){IVWaelliKo = false;}
          if(QqemKPfYSe == true){QqemKPfYSe = false;}
      } 
  }
} 

namespace ToKPMBjNj
{
  class GPHYQRBKFQ
  { 
      void ZQEwpZNptl()
      { 
          bool nROHFHiioJ = false;
          bool dsPQyHsyoZ = false;
          bool HqaDQLXfTX = false;
          bool oYqfUVPmQn = false;
          bool etNTonwjKq = false;
          bool tfwSIxqKps = false;
          bool iCOQUFBjuc = false;
          bool qGgBuNdHNb = false;
          bool OnVcdIcXWX = false;
          bool eEwWEbfxyj = false;
          bool lMnhznyuXu = false;
          bool TixNeugllM = false;
          bool bdMXymJKwS = false;
          bool gfIdpCzmco = false;
          bool KhAbEuHirI = false;
          bool usKlHIzQjM = false;
          bool enyENmaSXb = false;
          bool wsJwCtckTC = false;
          bool eaSmXnVVWh = false;
          bool ChDPKViwNQ = false;
          string EgobwJYMTZ = null;
          string BfzBumFzui = null;
          string guodTcWgiY = null;
          string URLafXtYiQ = null;
          string YlEtcpUiop = null;
          string iEzYTJqLIS = null;
          string mqcuEjTXVX = null;
          string sfQdJtptAd = null;
          string ImrroPSlGV = null;
          string fhPPdgIJps = null;
          string VwMRxCnUOZ = null;
          string SxLeKzzjGn = null;
          string QgRzqKPAAc = null;
          string lgDGHLZaul = null;
          string byWgChWkFd = null;
          string gXDBcndMZl = null;
          string lnTlmlsEWy = null;
          string YYoTMSKkwJ = null;
          string netVwNdCdT = null;
          string hMAIzndksQ = null;
          if(EgobwJYMTZ == VwMRxCnUOZ){nROHFHiioJ = true;}
          else if(VwMRxCnUOZ == EgobwJYMTZ){lMnhznyuXu = true;}
          if(BfzBumFzui == SxLeKzzjGn){dsPQyHsyoZ = true;}
          else if(SxLeKzzjGn == BfzBumFzui){TixNeugllM = true;}
          if(guodTcWgiY == QgRzqKPAAc){HqaDQLXfTX = true;}
          else if(QgRzqKPAAc == guodTcWgiY){bdMXymJKwS = true;}
          if(URLafXtYiQ == lgDGHLZaul){oYqfUVPmQn = true;}
          else if(lgDGHLZaul == URLafXtYiQ){gfIdpCzmco = true;}
          if(YlEtcpUiop == byWgChWkFd){etNTonwjKq = true;}
          else if(byWgChWkFd == YlEtcpUiop){KhAbEuHirI = true;}
          if(iEzYTJqLIS == gXDBcndMZl){tfwSIxqKps = true;}
          else if(gXDBcndMZl == iEzYTJqLIS){usKlHIzQjM = true;}
          if(mqcuEjTXVX == lnTlmlsEWy){iCOQUFBjuc = true;}
          else if(lnTlmlsEWy == mqcuEjTXVX){enyENmaSXb = true;}
          if(sfQdJtptAd == YYoTMSKkwJ){qGgBuNdHNb = true;}
          if(ImrroPSlGV == netVwNdCdT){OnVcdIcXWX = true;}
          if(fhPPdgIJps == hMAIzndksQ){eEwWEbfxyj = true;}
          while(YYoTMSKkwJ == sfQdJtptAd){wsJwCtckTC = true;}
          while(netVwNdCdT == ImrroPSlGV){eaSmXnVVWh = true;}
          while(hMAIzndksQ == fhPPdgIJps){ChDPKViwNQ = true;}
          if(nROHFHiioJ == true){nROHFHiioJ = false;}
          if(dsPQyHsyoZ == true){dsPQyHsyoZ = false;}
          if(HqaDQLXfTX == true){HqaDQLXfTX = false;}
          if(oYqfUVPmQn == true){oYqfUVPmQn = false;}
          if(etNTonwjKq == true){etNTonwjKq = false;}
          if(tfwSIxqKps == true){tfwSIxqKps = false;}
          if(iCOQUFBjuc == true){iCOQUFBjuc = false;}
          if(qGgBuNdHNb == true){qGgBuNdHNb = false;}
          if(OnVcdIcXWX == true){OnVcdIcXWX = false;}
          if(eEwWEbfxyj == true){eEwWEbfxyj = false;}
          if(lMnhznyuXu == true){lMnhznyuXu = false;}
          if(TixNeugllM == true){TixNeugllM = false;}
          if(bdMXymJKwS == true){bdMXymJKwS = false;}
          if(gfIdpCzmco == true){gfIdpCzmco = false;}
          if(KhAbEuHirI == true){KhAbEuHirI = false;}
          if(usKlHIzQjM == true){usKlHIzQjM = false;}
          if(enyENmaSXb == true){enyENmaSXb = false;}
          if(wsJwCtckTC == true){wsJwCtckTC = false;}
          if(eaSmXnVVWh == true){eaSmXnVVWh = false;}
          if(ChDPKViwNQ == true){ChDPKViwNQ = false;}
      } 
  }
} 

namespace NCPEDWbhI
{
  class XIZHHOHIIB
  { 
      void CcMhAPmwkf()
      { 
          bool sbxIuuPKdN = false;
          bool HYGZdTqJxp = false;
          bool aOGtwGFlaE = false;
          bool XtpNBGaXBH = false;
          bool NrzLDxWfww = false;
          bool FOyVddUCMo = false;
          bool pdiZpMhsXX = false;
          bool rTIobhPuqy = false;
          bool iZoeyIwUjW = false;
          bool lXKLRjJYUp = false;
          bool PdHYDlFIsu = false;
          bool NYLOGPnEbh = false;
          bool QMJAkTJwWr = false;
          bool YqZBhFRPaL = false;
          bool CmbnJMMuFB = false;
          bool uFxmYCTGnj = false;
          bool bIlAVWzKfB = false;
          bool yYcPedkUqY = false;
          bool HNqUwTslbf = false;
          bool kLbqisAaSm = false;
          string gDpVfpBHPJ = null;
          string lIIgQdLQgD = null;
          string JnpCRHXqNm = null;
          string itQSLzNUQk = null;
          string CYedeaztRU = null;
          string KgeKLsMnEX = null;
          string RKtcaqqoUR = null;
          string QqAwBkIMWq = null;
          string HdZrbCOFGS = null;
          string lYPrTqdCDm = null;
          string iJZzETfiJa = null;
          string jAQNQnkBAX = null;
          string blhBfqaIbJ = null;
          string GFIjHxDZnI = null;
          string VfufikICbf = null;
          string GcCfKxaYTM = null;
          string rXGATdrgFS = null;
          string jKMqBwpCRt = null;
          string iYfwDdDcZK = null;
          string WdFaPxYuLE = null;
          if(gDpVfpBHPJ == iJZzETfiJa){sbxIuuPKdN = true;}
          else if(iJZzETfiJa == gDpVfpBHPJ){PdHYDlFIsu = true;}
          if(lIIgQdLQgD == jAQNQnkBAX){HYGZdTqJxp = true;}
          else if(jAQNQnkBAX == lIIgQdLQgD){NYLOGPnEbh = true;}
          if(JnpCRHXqNm == blhBfqaIbJ){aOGtwGFlaE = true;}
          else if(blhBfqaIbJ == JnpCRHXqNm){QMJAkTJwWr = true;}
          if(itQSLzNUQk == GFIjHxDZnI){XtpNBGaXBH = true;}
          else if(GFIjHxDZnI == itQSLzNUQk){YqZBhFRPaL = true;}
          if(CYedeaztRU == VfufikICbf){NrzLDxWfww = true;}
          else if(VfufikICbf == CYedeaztRU){CmbnJMMuFB = true;}
          if(KgeKLsMnEX == GcCfKxaYTM){FOyVddUCMo = true;}
          else if(GcCfKxaYTM == KgeKLsMnEX){uFxmYCTGnj = true;}
          if(RKtcaqqoUR == rXGATdrgFS){pdiZpMhsXX = true;}
          else if(rXGATdrgFS == RKtcaqqoUR){bIlAVWzKfB = true;}
          if(QqAwBkIMWq == jKMqBwpCRt){rTIobhPuqy = true;}
          if(HdZrbCOFGS == iYfwDdDcZK){iZoeyIwUjW = true;}
          if(lYPrTqdCDm == WdFaPxYuLE){lXKLRjJYUp = true;}
          while(jKMqBwpCRt == QqAwBkIMWq){yYcPedkUqY = true;}
          while(iYfwDdDcZK == HdZrbCOFGS){HNqUwTslbf = true;}
          while(WdFaPxYuLE == lYPrTqdCDm){kLbqisAaSm = true;}
          if(sbxIuuPKdN == true){sbxIuuPKdN = false;}
          if(HYGZdTqJxp == true){HYGZdTqJxp = false;}
          if(aOGtwGFlaE == true){aOGtwGFlaE = false;}
          if(XtpNBGaXBH == true){XtpNBGaXBH = false;}
          if(NrzLDxWfww == true){NrzLDxWfww = false;}
          if(FOyVddUCMo == true){FOyVddUCMo = false;}
          if(pdiZpMhsXX == true){pdiZpMhsXX = false;}
          if(rTIobhPuqy == true){rTIobhPuqy = false;}
          if(iZoeyIwUjW == true){iZoeyIwUjW = false;}
          if(lXKLRjJYUp == true){lXKLRjJYUp = false;}
          if(PdHYDlFIsu == true){PdHYDlFIsu = false;}
          if(NYLOGPnEbh == true){NYLOGPnEbh = false;}
          if(QMJAkTJwWr == true){QMJAkTJwWr = false;}
          if(YqZBhFRPaL == true){YqZBhFRPaL = false;}
          if(CmbnJMMuFB == true){CmbnJMMuFB = false;}
          if(uFxmYCTGnj == true){uFxmYCTGnj = false;}
          if(bIlAVWzKfB == true){bIlAVWzKfB = false;}
          if(yYcPedkUqY == true){yYcPedkUqY = false;}
          if(HNqUwTslbf == true){HNqUwTslbf = false;}
          if(kLbqisAaSm == true){kLbqisAaSm = false;}
      } 
  }
} 

namespace HEnTWEcnJ
{
  class FAGGJPNXQI
  { 
      void UCVjNcApYa()
      { 
          bool yACkfZoYBD = false;
          bool ClxApfsjxm = false;
          bool MKNqXyXcAE = false;
          bool RVBaCWSDVZ = false;
          bool nhzgiHspZz = false;
          bool SuEoFnlKNh = false;
          bool CLYxkfjWxT = false;
          bool NoNXyeKfHP = false;
          bool FhCBlWRMUO = false;
          bool jHpnWbJCwD = false;
          bool XVrGkdgfpa = false;
          bool cGDxbUJXLO = false;
          bool OWBiiFyZAV = false;
          bool VIiEriouPH = false;
          bool okWtkdEsMC = false;
          bool SkqhnAUJXf = false;
          bool eHeTFTWzEr = false;
          bool fNIDYczHxE = false;
          bool BFNyDjRBPq = false;
          bool OeXicgGCoR = false;
          string xgLRCFXprs = null;
          string AWKiTglWgn = null;
          string LlDTSdeODA = null;
          string PELRfSaSBR = null;
          string DsIHOJgZMo = null;
          string TuZXuKcqyX = null;
          string aIlrduLsCA = null;
          string FTUPjScwFJ = null;
          string xECNfTdmVU = null;
          string pjTcquGQcS = null;
          string ymXLiAZKmc = null;
          string gfkoaVFXLK = null;
          string RXWgKVzqXo = null;
          string LMTlLJgqdf = null;
          string tSAsmJyeCV = null;
          string ohESBZPpAN = null;
          string AhmyQULycQ = null;
          string oOseQyXdsA = null;
          string WUoCAcHBkl = null;
          string sppQeLfCbS = null;
          if(xgLRCFXprs == ymXLiAZKmc){yACkfZoYBD = true;}
          else if(ymXLiAZKmc == xgLRCFXprs){XVrGkdgfpa = true;}
          if(AWKiTglWgn == gfkoaVFXLK){ClxApfsjxm = true;}
          else if(gfkoaVFXLK == AWKiTglWgn){cGDxbUJXLO = true;}
          if(LlDTSdeODA == RXWgKVzqXo){MKNqXyXcAE = true;}
          else if(RXWgKVzqXo == LlDTSdeODA){OWBiiFyZAV = true;}
          if(PELRfSaSBR == LMTlLJgqdf){RVBaCWSDVZ = true;}
          else if(LMTlLJgqdf == PELRfSaSBR){VIiEriouPH = true;}
          if(DsIHOJgZMo == tSAsmJyeCV){nhzgiHspZz = true;}
          else if(tSAsmJyeCV == DsIHOJgZMo){okWtkdEsMC = true;}
          if(TuZXuKcqyX == ohESBZPpAN){SuEoFnlKNh = true;}
          else if(ohESBZPpAN == TuZXuKcqyX){SkqhnAUJXf = true;}
          if(aIlrduLsCA == AhmyQULycQ){CLYxkfjWxT = true;}
          else if(AhmyQULycQ == aIlrduLsCA){eHeTFTWzEr = true;}
          if(FTUPjScwFJ == oOseQyXdsA){NoNXyeKfHP = true;}
          if(xECNfTdmVU == WUoCAcHBkl){FhCBlWRMUO = true;}
          if(pjTcquGQcS == sppQeLfCbS){jHpnWbJCwD = true;}
          while(oOseQyXdsA == FTUPjScwFJ){fNIDYczHxE = true;}
          while(WUoCAcHBkl == xECNfTdmVU){BFNyDjRBPq = true;}
          while(sppQeLfCbS == pjTcquGQcS){OeXicgGCoR = true;}
          if(yACkfZoYBD == true){yACkfZoYBD = false;}
          if(ClxApfsjxm == true){ClxApfsjxm = false;}
          if(MKNqXyXcAE == true){MKNqXyXcAE = false;}
          if(RVBaCWSDVZ == true){RVBaCWSDVZ = false;}
          if(nhzgiHspZz == true){nhzgiHspZz = false;}
          if(SuEoFnlKNh == true){SuEoFnlKNh = false;}
          if(CLYxkfjWxT == true){CLYxkfjWxT = false;}
          if(NoNXyeKfHP == true){NoNXyeKfHP = false;}
          if(FhCBlWRMUO == true){FhCBlWRMUO = false;}
          if(jHpnWbJCwD == true){jHpnWbJCwD = false;}
          if(XVrGkdgfpa == true){XVrGkdgfpa = false;}
          if(cGDxbUJXLO == true){cGDxbUJXLO = false;}
          if(OWBiiFyZAV == true){OWBiiFyZAV = false;}
          if(VIiEriouPH == true){VIiEriouPH = false;}
          if(okWtkdEsMC == true){okWtkdEsMC = false;}
          if(SkqhnAUJXf == true){SkqhnAUJXf = false;}
          if(eHeTFTWzEr == true){eHeTFTWzEr = false;}
          if(fNIDYczHxE == true){fNIDYczHxE = false;}
          if(BFNyDjRBPq == true){BFNyDjRBPq = false;}
          if(OeXicgGCoR == true){OeXicgGCoR = false;}
      } 
  }
} 

namespace tyTuJFbyz
{
  class GHCCFWFPCO
  { 
      void VDSBsRUqlk()
      { 
          bool QtUaNzkYhZ = false;
          bool NFhHHyrilt = false;
          bool XbcopJHhnc = false;
          bool LYGqCDckIN = false;
          bool WujBYuraCZ = false;
          bool OdXHqnQejE = false;
          bool rCjFOnypFD = false;
          bool UGZXWbraPt = false;
          bool RfeNNgBzAN = false;
          bool lxBEVTKdmj = false;
          bool xBVyFIDzkO = false;
          bool wpPomLXVrh = false;
          bool mypqRXEVCC = false;
          bool QOnfxPKgIF = false;
          bool cCOkRwhLRK = false;
          bool wokExyKdgh = false;
          bool DhxixgBjrW = false;
          bool ApNmEkjFZU = false;
          bool osDqFbcihy = false;
          bool EfzaBtEfmj = false;
          string FVLAOsMWwQ = null;
          string iWAllNrWcM = null;
          string bjtIRSesyD = null;
          string dqQxXQjpTK = null;
          string NILyltcPbf = null;
          string rktDGUaDiu = null;
          string NTYsmqFCOU = null;
          string dCCRyTYwVX = null;
          string oPRRKsxNpC = null;
          string pfHXwsiSLt = null;
          string nZAGCphbEm = null;
          string wegKGyCGht = null;
          string trMMextdUE = null;
          string jFjbiOOKOU = null;
          string KUJDFLzwRy = null;
          string qbkRzwNnbF = null;
          string wEGzCqtFbq = null;
          string jqqMiZiIGT = null;
          string xxLWNHTRbm = null;
          string AZiJYGNJBO = null;
          if(FVLAOsMWwQ == nZAGCphbEm){QtUaNzkYhZ = true;}
          else if(nZAGCphbEm == FVLAOsMWwQ){xBVyFIDzkO = true;}
          if(iWAllNrWcM == wegKGyCGht){NFhHHyrilt = true;}
          else if(wegKGyCGht == iWAllNrWcM){wpPomLXVrh = true;}
          if(bjtIRSesyD == trMMextdUE){XbcopJHhnc = true;}
          else if(trMMextdUE == bjtIRSesyD){mypqRXEVCC = true;}
          if(dqQxXQjpTK == jFjbiOOKOU){LYGqCDckIN = true;}
          else if(jFjbiOOKOU == dqQxXQjpTK){QOnfxPKgIF = true;}
          if(NILyltcPbf == KUJDFLzwRy){WujBYuraCZ = true;}
          else if(KUJDFLzwRy == NILyltcPbf){cCOkRwhLRK = true;}
          if(rktDGUaDiu == qbkRzwNnbF){OdXHqnQejE = true;}
          else if(qbkRzwNnbF == rktDGUaDiu){wokExyKdgh = true;}
          if(NTYsmqFCOU == wEGzCqtFbq){rCjFOnypFD = true;}
          else if(wEGzCqtFbq == NTYsmqFCOU){DhxixgBjrW = true;}
          if(dCCRyTYwVX == jqqMiZiIGT){UGZXWbraPt = true;}
          if(oPRRKsxNpC == xxLWNHTRbm){RfeNNgBzAN = true;}
          if(pfHXwsiSLt == AZiJYGNJBO){lxBEVTKdmj = true;}
          while(jqqMiZiIGT == dCCRyTYwVX){ApNmEkjFZU = true;}
          while(xxLWNHTRbm == oPRRKsxNpC){osDqFbcihy = true;}
          while(AZiJYGNJBO == pfHXwsiSLt){EfzaBtEfmj = true;}
          if(QtUaNzkYhZ == true){QtUaNzkYhZ = false;}
          if(NFhHHyrilt == true){NFhHHyrilt = false;}
          if(XbcopJHhnc == true){XbcopJHhnc = false;}
          if(LYGqCDckIN == true){LYGqCDckIN = false;}
          if(WujBYuraCZ == true){WujBYuraCZ = false;}
          if(OdXHqnQejE == true){OdXHqnQejE = false;}
          if(rCjFOnypFD == true){rCjFOnypFD = false;}
          if(UGZXWbraPt == true){UGZXWbraPt = false;}
          if(RfeNNgBzAN == true){RfeNNgBzAN = false;}
          if(lxBEVTKdmj == true){lxBEVTKdmj = false;}
          if(xBVyFIDzkO == true){xBVyFIDzkO = false;}
          if(wpPomLXVrh == true){wpPomLXVrh = false;}
          if(mypqRXEVCC == true){mypqRXEVCC = false;}
          if(QOnfxPKgIF == true){QOnfxPKgIF = false;}
          if(cCOkRwhLRK == true){cCOkRwhLRK = false;}
          if(wokExyKdgh == true){wokExyKdgh = false;}
          if(DhxixgBjrW == true){DhxixgBjrW = false;}
          if(ApNmEkjFZU == true){ApNmEkjFZU = false;}
          if(osDqFbcihy == true){osDqFbcihy = false;}
          if(EfzaBtEfmj == true){EfzaBtEfmj = false;}
      } 
  }
} 

namespace ZZDdaCidF
{
  class RXNVEZTBUH
  { 
      void ReLcIHjPMP()
      { 
          bool BtWhTNsdLP = false;
          bool pZRNIQyxyn = false;
          bool FlJLOownkN = false;
          bool yNwOSHsicO = false;
          bool DmmfzYJfBO = false;
          bool QKCqIPjKTd = false;
          bool QEryRbdCtA = false;
          bool WPTjkSzdLp = false;
          bool fQmWwnLEFD = false;
          bool WiPzxytnNX = false;
          bool tGkAqBpRFp = false;
          bool PGycxAQVCc = false;
          bool QYxqdnzUml = false;
          bool XKPnuZelft = false;
          bool xsyPmQjlBw = false;
          bool hYlkGVItWC = false;
          bool BVeTREpKhX = false;
          bool VeoIfWahDM = false;
          bool DNSpEzYegZ = false;
          bool QkPcraNexi = false;
          string jFnOesNTcT = null;
          string rbtWnVcmqM = null;
          string LRwQVWabTR = null;
          string EFyNmUuQRn = null;
          string IMiMRabtJl = null;
          string ixcMXRIWrI = null;
          string SkALPlcgjT = null;
          string ZMVCEzijyt = null;
          string tfSgiHckoU = null;
          string LXXJVWLWwf = null;
          string xtKpMVbaIY = null;
          string iYXyNlSTcI = null;
          string IrrPHBoMfg = null;
          string nLmSwAVbUM = null;
          string eCcQlmzYuj = null;
          string ErtnWFBuhK = null;
          string gPtajWkFCN = null;
          string QpzQcGPbcU = null;
          string BPQwbwQyup = null;
          string yasKePHBfO = null;
          if(jFnOesNTcT == xtKpMVbaIY){BtWhTNsdLP = true;}
          else if(xtKpMVbaIY == jFnOesNTcT){tGkAqBpRFp = true;}
          if(rbtWnVcmqM == iYXyNlSTcI){pZRNIQyxyn = true;}
          else if(iYXyNlSTcI == rbtWnVcmqM){PGycxAQVCc = true;}
          if(LRwQVWabTR == IrrPHBoMfg){FlJLOownkN = true;}
          else if(IrrPHBoMfg == LRwQVWabTR){QYxqdnzUml = true;}
          if(EFyNmUuQRn == nLmSwAVbUM){yNwOSHsicO = true;}
          else if(nLmSwAVbUM == EFyNmUuQRn){XKPnuZelft = true;}
          if(IMiMRabtJl == eCcQlmzYuj){DmmfzYJfBO = true;}
          else if(eCcQlmzYuj == IMiMRabtJl){xsyPmQjlBw = true;}
          if(ixcMXRIWrI == ErtnWFBuhK){QKCqIPjKTd = true;}
          else if(ErtnWFBuhK == ixcMXRIWrI){hYlkGVItWC = true;}
          if(SkALPlcgjT == gPtajWkFCN){QEryRbdCtA = true;}
          else if(gPtajWkFCN == SkALPlcgjT){BVeTREpKhX = true;}
          if(ZMVCEzijyt == QpzQcGPbcU){WPTjkSzdLp = true;}
          if(tfSgiHckoU == BPQwbwQyup){fQmWwnLEFD = true;}
          if(LXXJVWLWwf == yasKePHBfO){WiPzxytnNX = true;}
          while(QpzQcGPbcU == ZMVCEzijyt){VeoIfWahDM = true;}
          while(BPQwbwQyup == tfSgiHckoU){DNSpEzYegZ = true;}
          while(yasKePHBfO == LXXJVWLWwf){QkPcraNexi = true;}
          if(BtWhTNsdLP == true){BtWhTNsdLP = false;}
          if(pZRNIQyxyn == true){pZRNIQyxyn = false;}
          if(FlJLOownkN == true){FlJLOownkN = false;}
          if(yNwOSHsicO == true){yNwOSHsicO = false;}
          if(DmmfzYJfBO == true){DmmfzYJfBO = false;}
          if(QKCqIPjKTd == true){QKCqIPjKTd = false;}
          if(QEryRbdCtA == true){QEryRbdCtA = false;}
          if(WPTjkSzdLp == true){WPTjkSzdLp = false;}
          if(fQmWwnLEFD == true){fQmWwnLEFD = false;}
          if(WiPzxytnNX == true){WiPzxytnNX = false;}
          if(tGkAqBpRFp == true){tGkAqBpRFp = false;}
          if(PGycxAQVCc == true){PGycxAQVCc = false;}
          if(QYxqdnzUml == true){QYxqdnzUml = false;}
          if(XKPnuZelft == true){XKPnuZelft = false;}
          if(xsyPmQjlBw == true){xsyPmQjlBw = false;}
          if(hYlkGVItWC == true){hYlkGVItWC = false;}
          if(BVeTREpKhX == true){BVeTREpKhX = false;}
          if(VeoIfWahDM == true){VeoIfWahDM = false;}
          if(DNSpEzYegZ == true){DNSpEzYegZ = false;}
          if(QkPcraNexi == true){QkPcraNexi = false;}
      } 
  }
} 

namespace ZGlQyVtKP
{
  class JPOQVXNRHO
  { 
      void mdWkPdrxsW()
      { 
          bool uCPxAEMAcP = false;
          bool CqsQrTZSQB = false;
          bool AIUueBoIkP = false;
          bool KJWniZXiEL = false;
          bool XwNEjnLehb = false;
          bool ZRrlKlgTSz = false;
          bool OEPMEsTEhS = false;
          bool upNFdDuPLq = false;
          bool oJZIorRkdw = false;
          bool rEQFwSgAzq = false;
          bool THxPgjEmIH = false;
          bool qRIaKFdGWM = false;
          bool aiakZqZIIK = false;
          bool WtQTXgMKbF = false;
          bool ndcWFauotq = false;
          bool oZcmPjgLoo = false;
          bool KwexjwAoDd = false;
          bool rSeRXxFEey = false;
          bool ujNQUxRcDm = false;
          bool zAVlurzelJ = false;
          string YUclqzYSMN = null;
          string FhkyOJBApm = null;
          string oBmLGfthFa = null;
          string nFtLGLcWKQ = null;
          string LkEnPSMtVU = null;
          string ZlKPUXhQfK = null;
          string EpNlYznZrC = null;
          string fdoYbDwyun = null;
          string TALjACudpi = null;
          string dMqzLUXSOP = null;
          string elBTouwknQ = null;
          string aiUrqEdckV = null;
          string EJjIYTmoMG = null;
          string edjfIgyruE = null;
          string GJpYItqzIH = null;
          string pugsLVCsuU = null;
          string IGYglxzoiK = null;
          string GlhgPuSKAd = null;
          string bngFPjwpUm = null;
          string eFwZwzkImL = null;
          if(YUclqzYSMN == elBTouwknQ){uCPxAEMAcP = true;}
          else if(elBTouwknQ == YUclqzYSMN){THxPgjEmIH = true;}
          if(FhkyOJBApm == aiUrqEdckV){CqsQrTZSQB = true;}
          else if(aiUrqEdckV == FhkyOJBApm){qRIaKFdGWM = true;}
          if(oBmLGfthFa == EJjIYTmoMG){AIUueBoIkP = true;}
          else if(EJjIYTmoMG == oBmLGfthFa){aiakZqZIIK = true;}
          if(nFtLGLcWKQ == edjfIgyruE){KJWniZXiEL = true;}
          else if(edjfIgyruE == nFtLGLcWKQ){WtQTXgMKbF = true;}
          if(LkEnPSMtVU == GJpYItqzIH){XwNEjnLehb = true;}
          else if(GJpYItqzIH == LkEnPSMtVU){ndcWFauotq = true;}
          if(ZlKPUXhQfK == pugsLVCsuU){ZRrlKlgTSz = true;}
          else if(pugsLVCsuU == ZlKPUXhQfK){oZcmPjgLoo = true;}
          if(EpNlYznZrC == IGYglxzoiK){OEPMEsTEhS = true;}
          else if(IGYglxzoiK == EpNlYznZrC){KwexjwAoDd = true;}
          if(fdoYbDwyun == GlhgPuSKAd){upNFdDuPLq = true;}
          if(TALjACudpi == bngFPjwpUm){oJZIorRkdw = true;}
          if(dMqzLUXSOP == eFwZwzkImL){rEQFwSgAzq = true;}
          while(GlhgPuSKAd == fdoYbDwyun){rSeRXxFEey = true;}
          while(bngFPjwpUm == TALjACudpi){ujNQUxRcDm = true;}
          while(eFwZwzkImL == dMqzLUXSOP){zAVlurzelJ = true;}
          if(uCPxAEMAcP == true){uCPxAEMAcP = false;}
          if(CqsQrTZSQB == true){CqsQrTZSQB = false;}
          if(AIUueBoIkP == true){AIUueBoIkP = false;}
          if(KJWniZXiEL == true){KJWniZXiEL = false;}
          if(XwNEjnLehb == true){XwNEjnLehb = false;}
          if(ZRrlKlgTSz == true){ZRrlKlgTSz = false;}
          if(OEPMEsTEhS == true){OEPMEsTEhS = false;}
          if(upNFdDuPLq == true){upNFdDuPLq = false;}
          if(oJZIorRkdw == true){oJZIorRkdw = false;}
          if(rEQFwSgAzq == true){rEQFwSgAzq = false;}
          if(THxPgjEmIH == true){THxPgjEmIH = false;}
          if(qRIaKFdGWM == true){qRIaKFdGWM = false;}
          if(aiakZqZIIK == true){aiakZqZIIK = false;}
          if(WtQTXgMKbF == true){WtQTXgMKbF = false;}
          if(ndcWFauotq == true){ndcWFauotq = false;}
          if(oZcmPjgLoo == true){oZcmPjgLoo = false;}
          if(KwexjwAoDd == true){KwexjwAoDd = false;}
          if(rSeRXxFEey == true){rSeRXxFEey = false;}
          if(ujNQUxRcDm == true){ujNQUxRcDm = false;}
          if(zAVlurzelJ == true){zAVlurzelJ = false;}
      } 
  }
} 

namespace IeqCRDmUp
{
  class CFVCYWVHAP
  { 
      void thZhCHkrcO()
      { 
          bool mjXUwTLQDH = false;
          bool ymzZWgujRU = false;
          bool YOBdRVzoCp = false;
          bool cGTSVKfuCL = false;
          bool KglikRdWTo = false;
          bool NShqWYitCa = false;
          bool TVOMdqTgDM = false;
          bool BzhFJrbRrA = false;
          bool qcVMcKYbuw = false;
          bool bkraqnRZEt = false;
          bool xxSGnOjbge = false;
          bool xQCCiqABiT = false;
          bool SqlGkPGGNV = false;
          bool ZCNxCtJOYO = false;
          bool ZwtQzLiprA = false;
          bool nPpjaGLMVY = false;
          bool HcNLEtCEzo = false;
          bool hkcUsVwUGZ = false;
          bool fPONgJLcWw = false;
          bool hxszGxhiLF = false;
          string FKjLlomopR = null;
          string NXCMoZUBLc = null;
          string OlybHSDrEg = null;
          string GeaLyAGqFa = null;
          string nSdipHsMaH = null;
          string BQOiCSLIDT = null;
          string ktkJKixqNo = null;
          string TcujowIPlA = null;
          string YqRwepPrIe = null;
          string nynlpsgTXG = null;
          string KBykmYUdtF = null;
          string KwVDtscoeU = null;
          string SFiiBVnItw = null;
          string OnreoXsfIG = null;
          string UlyDTqbkrw = null;
          string ProCnFSOjR = null;
          string jLixqWDqNW = null;
          string AwfYzfHfOJ = null;
          string tDQyfWyopj = null;
          string EdwpVIDALw = null;
          if(FKjLlomopR == KBykmYUdtF){mjXUwTLQDH = true;}
          else if(KBykmYUdtF == FKjLlomopR){xxSGnOjbge = true;}
          if(NXCMoZUBLc == KwVDtscoeU){ymzZWgujRU = true;}
          else if(KwVDtscoeU == NXCMoZUBLc){xQCCiqABiT = true;}
          if(OlybHSDrEg == SFiiBVnItw){YOBdRVzoCp = true;}
          else if(SFiiBVnItw == OlybHSDrEg){SqlGkPGGNV = true;}
          if(GeaLyAGqFa == OnreoXsfIG){cGTSVKfuCL = true;}
          else if(OnreoXsfIG == GeaLyAGqFa){ZCNxCtJOYO = true;}
          if(nSdipHsMaH == UlyDTqbkrw){KglikRdWTo = true;}
          else if(UlyDTqbkrw == nSdipHsMaH){ZwtQzLiprA = true;}
          if(BQOiCSLIDT == ProCnFSOjR){NShqWYitCa = true;}
          else if(ProCnFSOjR == BQOiCSLIDT){nPpjaGLMVY = true;}
          if(ktkJKixqNo == jLixqWDqNW){TVOMdqTgDM = true;}
          else if(jLixqWDqNW == ktkJKixqNo){HcNLEtCEzo = true;}
          if(TcujowIPlA == AwfYzfHfOJ){BzhFJrbRrA = true;}
          if(YqRwepPrIe == tDQyfWyopj){qcVMcKYbuw = true;}
          if(nynlpsgTXG == EdwpVIDALw){bkraqnRZEt = true;}
          while(AwfYzfHfOJ == TcujowIPlA){hkcUsVwUGZ = true;}
          while(tDQyfWyopj == YqRwepPrIe){fPONgJLcWw = true;}
          while(EdwpVIDALw == nynlpsgTXG){hxszGxhiLF = true;}
          if(mjXUwTLQDH == true){mjXUwTLQDH = false;}
          if(ymzZWgujRU == true){ymzZWgujRU = false;}
          if(YOBdRVzoCp == true){YOBdRVzoCp = false;}
          if(cGTSVKfuCL == true){cGTSVKfuCL = false;}
          if(KglikRdWTo == true){KglikRdWTo = false;}
          if(NShqWYitCa == true){NShqWYitCa = false;}
          if(TVOMdqTgDM == true){TVOMdqTgDM = false;}
          if(BzhFJrbRrA == true){BzhFJrbRrA = false;}
          if(qcVMcKYbuw == true){qcVMcKYbuw = false;}
          if(bkraqnRZEt == true){bkraqnRZEt = false;}
          if(xxSGnOjbge == true){xxSGnOjbge = false;}
          if(xQCCiqABiT == true){xQCCiqABiT = false;}
          if(SqlGkPGGNV == true){SqlGkPGGNV = false;}
          if(ZCNxCtJOYO == true){ZCNxCtJOYO = false;}
          if(ZwtQzLiprA == true){ZwtQzLiprA = false;}
          if(nPpjaGLMVY == true){nPpjaGLMVY = false;}
          if(HcNLEtCEzo == true){HcNLEtCEzo = false;}
          if(hkcUsVwUGZ == true){hkcUsVwUGZ = false;}
          if(fPONgJLcWw == true){fPONgJLcWw = false;}
          if(hxszGxhiLF == true){hxszGxhiLF = false;}
      } 
  }
} 

namespace sYHqteXsU
{
  class VZHHIYDFSO
  { 
      void FUdAcSkNEl()
      { 
          bool KAuqOPGMoL = false;
          bool CeQObdyKGF = false;
          bool yzrclZhFTj = false;
          bool oblEeHQZSo = false;
          bool TyVWzBYuSc = false;
          bool jlHrwLIRFn = false;
          bool gAsFWarMjU = false;
          bool NXqQkAcUcj = false;
          bool AmlpzCUtHS = false;
          bool zyUdHSEQAY = false;
          bool JMKyPLtpGw = false;
          bool hmoUmtODFT = false;
          bool FyEQVOCMIR = false;
          bool uMUDanbnZn = false;
          bool HdmLkLJAqM = false;
          bool EAKfSKHtbB = false;
          bool IhhoAVSksz = false;
          bool SZcRLbLsfK = false;
          bool ECVuMtBnjQ = false;
          bool fgLXeZwxKO = false;
          string sOAJyFwGrF = null;
          string cMjxuCYTMa = null;
          string mYlrbIILcs = null;
          string rKydhfniPy = null;
          string zQMooWjiff = null;
          string SyRAkUcIgo = null;
          string wkczNSOGPO = null;
          string NoENaVMwCE = null;
          string YZexatryrM = null;
          string CfCaBNmMbW = null;
          string IcSQRctEYO = null;
          string IfFbPWGfYS = null;
          string ZPNCMhmcMM = null;
          string hzUewwGOex = null;
          string AnZdDWZaKe = null;
          string HHnIxsOPEj = null;
          string pQqLfJLZfT = null;
          string QrAaSkpjzo = null;
          string HLRgFaKLhC = null;
          string gpJuHiwNxt = null;
          if(sOAJyFwGrF == IcSQRctEYO){KAuqOPGMoL = true;}
          else if(IcSQRctEYO == sOAJyFwGrF){JMKyPLtpGw = true;}
          if(cMjxuCYTMa == IfFbPWGfYS){CeQObdyKGF = true;}
          else if(IfFbPWGfYS == cMjxuCYTMa){hmoUmtODFT = true;}
          if(mYlrbIILcs == ZPNCMhmcMM){yzrclZhFTj = true;}
          else if(ZPNCMhmcMM == mYlrbIILcs){FyEQVOCMIR = true;}
          if(rKydhfniPy == hzUewwGOex){oblEeHQZSo = true;}
          else if(hzUewwGOex == rKydhfniPy){uMUDanbnZn = true;}
          if(zQMooWjiff == AnZdDWZaKe){TyVWzBYuSc = true;}
          else if(AnZdDWZaKe == zQMooWjiff){HdmLkLJAqM = true;}
          if(SyRAkUcIgo == HHnIxsOPEj){jlHrwLIRFn = true;}
          else if(HHnIxsOPEj == SyRAkUcIgo){EAKfSKHtbB = true;}
          if(wkczNSOGPO == pQqLfJLZfT){gAsFWarMjU = true;}
          else if(pQqLfJLZfT == wkczNSOGPO){IhhoAVSksz = true;}
          if(NoENaVMwCE == QrAaSkpjzo){NXqQkAcUcj = true;}
          if(YZexatryrM == HLRgFaKLhC){AmlpzCUtHS = true;}
          if(CfCaBNmMbW == gpJuHiwNxt){zyUdHSEQAY = true;}
          while(QrAaSkpjzo == NoENaVMwCE){SZcRLbLsfK = true;}
          while(HLRgFaKLhC == YZexatryrM){ECVuMtBnjQ = true;}
          while(gpJuHiwNxt == CfCaBNmMbW){fgLXeZwxKO = true;}
          if(KAuqOPGMoL == true){KAuqOPGMoL = false;}
          if(CeQObdyKGF == true){CeQObdyKGF = false;}
          if(yzrclZhFTj == true){yzrclZhFTj = false;}
          if(oblEeHQZSo == true){oblEeHQZSo = false;}
          if(TyVWzBYuSc == true){TyVWzBYuSc = false;}
          if(jlHrwLIRFn == true){jlHrwLIRFn = false;}
          if(gAsFWarMjU == true){gAsFWarMjU = false;}
          if(NXqQkAcUcj == true){NXqQkAcUcj = false;}
          if(AmlpzCUtHS == true){AmlpzCUtHS = false;}
          if(zyUdHSEQAY == true){zyUdHSEQAY = false;}
          if(JMKyPLtpGw == true){JMKyPLtpGw = false;}
          if(hmoUmtODFT == true){hmoUmtODFT = false;}
          if(FyEQVOCMIR == true){FyEQVOCMIR = false;}
          if(uMUDanbnZn == true){uMUDanbnZn = false;}
          if(HdmLkLJAqM == true){HdmLkLJAqM = false;}
          if(EAKfSKHtbB == true){EAKfSKHtbB = false;}
          if(IhhoAVSksz == true){IhhoAVSksz = false;}
          if(SZcRLbLsfK == true){SZcRLbLsfK = false;}
          if(ECVuMtBnjQ == true){ECVuMtBnjQ = false;}
          if(fgLXeZwxKO == true){fgLXeZwxKO = false;}
      } 
  }
} 

namespace NSRPUYnkK
{
  class QTGSIWCGQG
  { 
      void EcNTiNOloM()
      { 
          bool ueDPhfRjyt = false;
          bool OHUJswPEdR = false;
          bool zRtaaXnRhc = false;
          bool GYbyDEzbAg = false;
          bool SiCBRmMnVi = false;
          bool GzuKMdkboJ = false;
          bool rACUmoeVFo = false;
          bool wmEwzQPsJn = false;
          bool LzuzVGcRkZ = false;
          bool SWmqoSfgNb = false;
          bool HpiglSuzLu = false;
          bool NrSAxrECzg = false;
          bool MNjeVYANHf = false;
          bool jiegfUQOMC = false;
          bool LdFpMaElsw = false;
          bool OdgfPtGDKM = false;
          bool ShqeKdMkUc = false;
          bool boowUiHtSu = false;
          bool UNUKRGByRl = false;
          bool OMDAidlaeh = false;
          string QxXcgURaDt = null;
          string pGZORaFikY = null;
          string qaDXFCQsXX = null;
          string wkBVGYLhqJ = null;
          string idUaNiAfPx = null;
          string idjMBpsAXd = null;
          string DXCfxEEEHr = null;
          string PXqapMFcJW = null;
          string CkdaoRBnTQ = null;
          string eKKNFLbodI = null;
          string dwXWhLlIWn = null;
          string jQpAbSsaqe = null;
          string DQjqNEMdVe = null;
          string kQyAsGNHsc = null;
          string erRffNUKlm = null;
          string RAyyFNLfJc = null;
          string yImqDSSoGV = null;
          string FlhNALyELz = null;
          string iCrhNkSAuf = null;
          string tgyPeWEZcM = null;
          if(QxXcgURaDt == dwXWhLlIWn){ueDPhfRjyt = true;}
          else if(dwXWhLlIWn == QxXcgURaDt){HpiglSuzLu = true;}
          if(pGZORaFikY == jQpAbSsaqe){OHUJswPEdR = true;}
          else if(jQpAbSsaqe == pGZORaFikY){NrSAxrECzg = true;}
          if(qaDXFCQsXX == DQjqNEMdVe){zRtaaXnRhc = true;}
          else if(DQjqNEMdVe == qaDXFCQsXX){MNjeVYANHf = true;}
          if(wkBVGYLhqJ == kQyAsGNHsc){GYbyDEzbAg = true;}
          else if(kQyAsGNHsc == wkBVGYLhqJ){jiegfUQOMC = true;}
          if(idUaNiAfPx == erRffNUKlm){SiCBRmMnVi = true;}
          else if(erRffNUKlm == idUaNiAfPx){LdFpMaElsw = true;}
          if(idjMBpsAXd == RAyyFNLfJc){GzuKMdkboJ = true;}
          else if(RAyyFNLfJc == idjMBpsAXd){OdgfPtGDKM = true;}
          if(DXCfxEEEHr == yImqDSSoGV){rACUmoeVFo = true;}
          else if(yImqDSSoGV == DXCfxEEEHr){ShqeKdMkUc = true;}
          if(PXqapMFcJW == FlhNALyELz){wmEwzQPsJn = true;}
          if(CkdaoRBnTQ == iCrhNkSAuf){LzuzVGcRkZ = true;}
          if(eKKNFLbodI == tgyPeWEZcM){SWmqoSfgNb = true;}
          while(FlhNALyELz == PXqapMFcJW){boowUiHtSu = true;}
          while(iCrhNkSAuf == CkdaoRBnTQ){UNUKRGByRl = true;}
          while(tgyPeWEZcM == eKKNFLbodI){OMDAidlaeh = true;}
          if(ueDPhfRjyt == true){ueDPhfRjyt = false;}
          if(OHUJswPEdR == true){OHUJswPEdR = false;}
          if(zRtaaXnRhc == true){zRtaaXnRhc = false;}
          if(GYbyDEzbAg == true){GYbyDEzbAg = false;}
          if(SiCBRmMnVi == true){SiCBRmMnVi = false;}
          if(GzuKMdkboJ == true){GzuKMdkboJ = false;}
          if(rACUmoeVFo == true){rACUmoeVFo = false;}
          if(wmEwzQPsJn == true){wmEwzQPsJn = false;}
          if(LzuzVGcRkZ == true){LzuzVGcRkZ = false;}
          if(SWmqoSfgNb == true){SWmqoSfgNb = false;}
          if(HpiglSuzLu == true){HpiglSuzLu = false;}
          if(NrSAxrECzg == true){NrSAxrECzg = false;}
          if(MNjeVYANHf == true){MNjeVYANHf = false;}
          if(jiegfUQOMC == true){jiegfUQOMC = false;}
          if(LdFpMaElsw == true){LdFpMaElsw = false;}
          if(OdgfPtGDKM == true){OdgfPtGDKM = false;}
          if(ShqeKdMkUc == true){ShqeKdMkUc = false;}
          if(boowUiHtSu == true){boowUiHtSu = false;}
          if(UNUKRGByRl == true){UNUKRGByRl = false;}
          if(OMDAidlaeh == true){OMDAidlaeh = false;}
      } 
  }
} 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xam 
{
    public static class Weapons
    {
        private static int[,] defaultnothing = { { 0, 0 } }; // its needed because: No clue
        // RECOIL TABLES FROM https://github.com/Eternidades/NoRecoil/blob/main/norecoil/Weapons.h
        public static int[,] AssaultRifle = { { -35, 50 }, { 5, 46 }, { -55, 42 }, { -42, 37 }, { 0, 33 }, { 16, 28 }, { 29, 24 }, { 38, 19 }, { 42, 14 }, { 42, 9 }, { 38, 9 }, { 30, 18 }, { 17, 25 }, { 0, 29 }, { -15, 32 }, { -27, 33 }, { -37, 32 }, { -43, 29 }, { -46, 24 }, { -45, 17 }, { -42, 8 }, { -35, 5 }, { -24, 14 }, { -11, 21 }, { 12, 25 }, { 36, 28 }, { 49, 28 }, { 49, 26 }, { 38, 21 } };
        public static int AssaultRifleTime = 133;

        public static int[,] LR300AssaultRifle = { { -2, 25 }, { -6, 31 }, { -10, 33 }, { -14, 31 }, { -15, 25 }, { -14, 20 }, { -9, 17 }, { -2, 15 }, { 9, 12 }, { 17, 10 }, { 20, 8 }, { 17, 7 }, { 10, 5 }, { 0, 4 }, { -5, 4 }, { -9, 4 }, { -12, 3 }, { -14, 3 }, { -15, 3 }, { -15, 2 }, { -14, 2 }, { -13, 2 }, { -10, 2 }, { -7, 2 }, { -3, 2 }, { 13, 2 }, { 30, 2 }, { 36, 3 }, { 30, 3 } };
        public static int LR300AssaultRifleTime = 118;

        public static int[,] Thompson = { { -15, 33 }, { -5, 32 }, { 3, 31 }, { 11, 29 }, { 13, 26 }, { 10, 22 }, { 2, 18 }, { -7, 16 }, { -13, 14 }, { -13, 13 }, { -7, 11 }, { 2, 10 }, { 10, 9 }, { 12, 8 }, { 11, 7 }, { 5, 7 }, { -2, 6 }, { -6, 6 }, { -7, 6 } };
        public static int ThompsonTime = 127;

        public static int[,] MP5A4 = { { 0, 21 }, { 0, 29 }, { 0, 33 }, { 12, 33 }, { 29, 29 }, { 33, 22 }, { 23, 13 }, { 0, 10 }, { -18, 9 }, { -25, 8 }, { -19, 7 }, { -3, 6 }, { 7, 5 }, { 14, 4 }, { 16, 4 }, { 16, 3 }, { 12, 2 }, { 6, 2 }, { -1, 1 }, { -5, 1 }, { -8, 0 }, { -10, 0 }, { -12, 0 }, { -13, 0 }, { -13, 0 }, { -12, 0 }, { -11, 0 }, { -8, 0 }, { -5, 0 } };
        public static int MP5A4Time = 98; 

        public static int[,] CustomSMG = { { -13, 27 }, { -6, 27 }, { 0, 26 }, { 6, 25 }, { 10, 23 }, { 11, 21 }, { 9, 18 }, { 4, 16 }, { -3, 14 }, { -9, 13 }, { -11, 12 }, { -10, 10 }, { -6, 9 }, { 0, 9 }, { 6, 8 }, { 9, 7 }, { 10, 6 }, { 9, 6 }, { 4, 5 }, { 0, 5 }, { -4, 5 }, { -6, 5 }, { -5, 5 } };
        public static int CustomSMGTime = 99;

        public static int[,] M249 = { { 0, 58 }, { 0, 58 } };  // not sure if thats correct
        public static int M249Time = 103;
        // Credits End
        public static (int[,], int) Current_weapon() // Returning : Recoiltable, Timing
        {
            switch (Menu.weapon)
            {
                case "Assault Rifle":
                    return (AssaultRifle, AssaultRifleTime);

                case "LR-300 Assault Rifle":
                    return (LR300AssaultRifle, LR300AssaultRifleTime);

                case "M249":
                    return (M249, M249Time);

                case "Thompson":
                    return (Thompson, ThompsonTime);

                case "MP5A4":
                    return (MP5A4, MP5A4Time);

                case "Custom SMG":
                    return (CustomSMG, CustomSMGTime);

                default:
                    return ( defaultnothing , 0);
            }
        }
        public static (double, double) Attachment()
        {
            switch (Menu.attachment) // Returning : Multipier, Timing
            {
                case "Muzzle Boost":
                    return (1, 0.9);
                case "Muzzle Brake":
                    return (0.5, 1);
                case "Silencer":
                    return (0.8, 1);
                default:
                    return (1, 1);
            }
        }
        public static  double Scope()
        {
            switch (Menu.scope) // Returning : Recoiltable
            {
                case "8x Zoom Scope":
                    return 3.83721;
                case "16x Zoom Scope":
                    return 7.65116;
                case "Simple Handmade Sight":
                    return 0.8;
                case "Holosight":
                    return 1.2;
                default:
                    return 1;
            }
        }
        private static Random r = new Random();
        public static int minmax(int av, int min, int max) // Makes a Random value ot of one value
        {
            double percentage = r.Next(min, max);
            percentage = percentage / 100;
            double rv = av * percentage;
            int res = Convert.ToInt32(rv);
            return res;
        }
    }


}

namespace flJJDIIxw
{
  class FQLMCDEPES
  { 
      void AZLeDUaodP()
      { 
          bool ZRXdhOFpkZ = false;
          bool nInZXchwjP = false;
          bool hbFCZAJLTm = false;
          bool TydqqkfzFg = false;
          bool XxqWthAGag = false;
          bool lNqkMyMVEg = false;
          bool FtVyGodxhm = false;
          bool wipDqjkhHq = false;
          bool ADklBFHses = false;
          bool XJtXadarQE = false;
          bool DCXnjCXmsb = false;
          bool NeNMfBIjwA = false;
          bool gkRoOlnSbN = false;
          bool JrRCnyewBy = false;
          bool hUzDeswhqZ = false;
          bool UquPXSkiYx = false;
          bool OEKeSVNKYh = false;
          bool WMhySMkOJU = false;
          bool pGaCsRwBeU = false;
          bool MwWDicJTkI = false;
          string LuxlzNVfgF = null;
          string lFcLTBQkPI = null;
          string LmaQLNPxUc = null;
          string GZjUQWEPZa = null;
          string qNrcnSVXku = null;
          string tsjwlXUfZl = null;
          string xYLDyMVItx = null;
          string wBKoQxuxcs = null;
          string qrLZiMomhr = null;
          string BXoncRCnda = null;
          string wNcnzrhuen = null;
          string cWDgtFNkUl = null;
          string XhZBwXLWLz = null;
          string uHTBwdPXZp = null;
          string esHtPdUItX = null;
          string EQTrDOnara = null;
          string gKjfsVDCjP = null;
          string ooKdGdaelR = null;
          string DDcmudmbxh = null;
          string pofzJTJbAt = null;
          if(LuxlzNVfgF == wNcnzrhuen){ZRXdhOFpkZ = true;}
          else if(wNcnzrhuen == LuxlzNVfgF){DCXnjCXmsb = true;}
          if(lFcLTBQkPI == cWDgtFNkUl){nInZXchwjP = true;}
          else if(cWDgtFNkUl == lFcLTBQkPI){NeNMfBIjwA = true;}
          if(LmaQLNPxUc == XhZBwXLWLz){hbFCZAJLTm = true;}
          else if(XhZBwXLWLz == LmaQLNPxUc){gkRoOlnSbN = true;}
          if(GZjUQWEPZa == uHTBwdPXZp){TydqqkfzFg = true;}
          else if(uHTBwdPXZp == GZjUQWEPZa){JrRCnyewBy = true;}
          if(qNrcnSVXku == esHtPdUItX){XxqWthAGag = true;}
          else if(esHtPdUItX == qNrcnSVXku){hUzDeswhqZ = true;}
          if(tsjwlXUfZl == EQTrDOnara){lNqkMyMVEg = true;}
          else if(EQTrDOnara == tsjwlXUfZl){UquPXSkiYx = true;}
          if(xYLDyMVItx == gKjfsVDCjP){FtVyGodxhm = true;}
          else if(gKjfsVDCjP == xYLDyMVItx){OEKeSVNKYh = true;}
          if(wBKoQxuxcs == ooKdGdaelR){wipDqjkhHq = true;}
          if(qrLZiMomhr == DDcmudmbxh){ADklBFHses = true;}
          if(BXoncRCnda == pofzJTJbAt){XJtXadarQE = true;}
          while(ooKdGdaelR == wBKoQxuxcs){WMhySMkOJU = true;}
          while(DDcmudmbxh == qrLZiMomhr){pGaCsRwBeU = true;}
          while(pofzJTJbAt == BXoncRCnda){MwWDicJTkI = true;}
          if(ZRXdhOFpkZ == true){ZRXdhOFpkZ = false;}
          if(nInZXchwjP == true){nInZXchwjP = false;}
          if(hbFCZAJLTm == true){hbFCZAJLTm = false;}
          if(TydqqkfzFg == true){TydqqkfzFg = false;}
          if(XxqWthAGag == true){XxqWthAGag = false;}
          if(lNqkMyMVEg == true){lNqkMyMVEg = false;}
          if(FtVyGodxhm == true){FtVyGodxhm = false;}
          if(wipDqjkhHq == true){wipDqjkhHq = false;}
          if(ADklBFHses == true){ADklBFHses = false;}
          if(XJtXadarQE == true){XJtXadarQE = false;}
          if(DCXnjCXmsb == true){DCXnjCXmsb = false;}
          if(NeNMfBIjwA == true){NeNMfBIjwA = false;}
          if(gkRoOlnSbN == true){gkRoOlnSbN = false;}
          if(JrRCnyewBy == true){JrRCnyewBy = false;}
          if(hUzDeswhqZ == true){hUzDeswhqZ = false;}
          if(UquPXSkiYx == true){UquPXSkiYx = false;}
          if(OEKeSVNKYh == true){OEKeSVNKYh = false;}
          if(WMhySMkOJU == true){WMhySMkOJU = false;}
          if(pGaCsRwBeU == true){pGaCsRwBeU = false;}
          if(MwWDicJTkI == true){MwWDicJTkI = false;}
      } 
  }
} 

namespace byGJElIKT
{
  class PIIGBEJSLL
  { 
      void TIBYlZinYd()
      { 
          bool OfbzfydRiw = false;
          bool PiyXLunVsQ = false;
          bool uSZFNbWnzn = false;
          bool XrjffDrEdd = false;
          bool zFpBEtAAQZ = false;
          bool lSNMQwGVlE = false;
          bool boRtYWzRqH = false;
          bool CjrOQpcXAS = false;
          bool aVWZBEeWOj = false;
          bool xVSYCJnuch = false;
          bool tiJIWCayua = false;
          bool ShUSdFSqrT = false;
          bool qcCGKgRSMH = false;
          bool BgtSYrMODz = false;
          bool dgbnRPAzux = false;
          bool pwDJpRfCyo = false;
          bool jHlmYlmCsl = false;
          bool sEmsoKBOou = false;
          bool fRXOQFdkcH = false;
          bool LJPOOVtnOe = false;
          string rxICaaIUJh = null;
          string EMeQQiZdmf = null;
          string qPbiSECIUk = null;
          string rFNJjqJtcx = null;
          string ejPWmqAwuK = null;
          string QmmrWcUZjV = null;
          string XAAYoyyUfY = null;
          string YfApAGAFua = null;
          string EGNKUFRVlH = null;
          string WjJGYejpho = null;
          string rePVkklxqP = null;
          string bPeIQRloEi = null;
          string gciXCoVsRV = null;
          string WJXGiZpqYj = null;
          string TUdVeGEBpH = null;
          string stlyIOwqSw = null;
          string OrfVsSrXZq = null;
          string atQUPLzMsu = null;
          string jTDJccWYyT = null;
          string dzXcUanHcM = null;
          if(rxICaaIUJh == rePVkklxqP){OfbzfydRiw = true;}
          else if(rePVkklxqP == rxICaaIUJh){tiJIWCayua = true;}
          if(EMeQQiZdmf == bPeIQRloEi){PiyXLunVsQ = true;}
          else if(bPeIQRloEi == EMeQQiZdmf){ShUSdFSqrT = true;}
          if(qPbiSECIUk == gciXCoVsRV){uSZFNbWnzn = true;}
          else if(gciXCoVsRV == qPbiSECIUk){qcCGKgRSMH = true;}
          if(rFNJjqJtcx == WJXGiZpqYj){XrjffDrEdd = true;}
          else if(WJXGiZpqYj == rFNJjqJtcx){BgtSYrMODz = true;}
          if(ejPWmqAwuK == TUdVeGEBpH){zFpBEtAAQZ = true;}
          else if(TUdVeGEBpH == ejPWmqAwuK){dgbnRPAzux = true;}
          if(QmmrWcUZjV == stlyIOwqSw){lSNMQwGVlE = true;}
          else if(stlyIOwqSw == QmmrWcUZjV){pwDJpRfCyo = true;}
          if(XAAYoyyUfY == OrfVsSrXZq){boRtYWzRqH = true;}
          else if(OrfVsSrXZq == XAAYoyyUfY){jHlmYlmCsl = true;}
          if(YfApAGAFua == atQUPLzMsu){CjrOQpcXAS = true;}
          if(EGNKUFRVlH == jTDJccWYyT){aVWZBEeWOj = true;}
          if(WjJGYejpho == dzXcUanHcM){xVSYCJnuch = true;}
          while(atQUPLzMsu == YfApAGAFua){sEmsoKBOou = true;}
          while(jTDJccWYyT == EGNKUFRVlH){fRXOQFdkcH = true;}
          while(dzXcUanHcM == WjJGYejpho){LJPOOVtnOe = true;}
          if(OfbzfydRiw == true){OfbzfydRiw = false;}
          if(PiyXLunVsQ == true){PiyXLunVsQ = false;}
          if(uSZFNbWnzn == true){uSZFNbWnzn = false;}
          if(XrjffDrEdd == true){XrjffDrEdd = false;}
          if(zFpBEtAAQZ == true){zFpBEtAAQZ = false;}
          if(lSNMQwGVlE == true){lSNMQwGVlE = false;}
          if(boRtYWzRqH == true){boRtYWzRqH = false;}
          if(CjrOQpcXAS == true){CjrOQpcXAS = false;}
          if(aVWZBEeWOj == true){aVWZBEeWOj = false;}
          if(xVSYCJnuch == true){xVSYCJnuch = false;}
          if(tiJIWCayua == true){tiJIWCayua = false;}
          if(ShUSdFSqrT == true){ShUSdFSqrT = false;}
          if(qcCGKgRSMH == true){qcCGKgRSMH = false;}
          if(BgtSYrMODz == true){BgtSYrMODz = false;}
          if(dgbnRPAzux == true){dgbnRPAzux = false;}
          if(pwDJpRfCyo == true){pwDJpRfCyo = false;}
          if(jHlmYlmCsl == true){jHlmYlmCsl = false;}
          if(sEmsoKBOou == true){sEmsoKBOou = false;}
          if(fRXOQFdkcH == true){fRXOQFdkcH = false;}
          if(LJPOOVtnOe == true){LJPOOVtnOe = false;}
      } 
  }
} 

namespace swKxATQpH
{
  class ZIXNEMOIPS
  { 
      void fuHJYYEkVd()
      { 
          bool rXpPgPQygK = false;
          bool ZuAdfLpfWF = false;
          bool MhFVaqNoQK = false;
          bool cIcBcqlDsk = false;
          bool ymCLPslFbL = false;
          bool EGhDSJSTnp = false;
          bool CbhVhQRzBn = false;
          bool ZmmlGZftFh = false;
          bool EIMEGVaYhS = false;
          bool YRODhWFfcz = false;
          bool amDmlQTwws = false;
          bool dYOFksOdPL = false;
          bool psQiPIXjDj = false;
          bool UzQGHREZSo = false;
          bool CebnoADJRo = false;
          bool IaQQJhWUWc = false;
          bool rirMYdHHyT = false;
          bool nnKZJKQbsO = false;
          bool EOSObsizxY = false;
          bool tjCowSlPPK = false;
          string WzXmQqUoFF = null;
          string ZLLFnVPmVx = null;
          string ejpQoJbZUX = null;
          string ibHToJfqXZ = null;
          string okWUigoLKC = null;
          string qWosrlJHyG = null;
          string PuUhWxDqQe = null;
          string oXPwHtNUhH = null;
          string TQORfLmNbD = null;
          string zYsRJtQnyk = null;
          string dxueMTHskx = null;
          string XoYplzgCBK = null;
          string KpPMfQexlN = null;
          string cYWxdVUiEM = null;
          string EtbdeKACeK = null;
          string NNmmanhhzw = null;
          string nJHXUyRbMP = null;
          string dxxnGPNlhU = null;
          string PbSaAOliVp = null;
          string nmiIXumEJf = null;
          if(WzXmQqUoFF == dxueMTHskx){rXpPgPQygK = true;}
          else if(dxueMTHskx == WzXmQqUoFF){amDmlQTwws = true;}
          if(ZLLFnVPmVx == XoYplzgCBK){ZuAdfLpfWF = true;}
          else if(XoYplzgCBK == ZLLFnVPmVx){dYOFksOdPL = true;}
          if(ejpQoJbZUX == KpPMfQexlN){MhFVaqNoQK = true;}
          else if(KpPMfQexlN == ejpQoJbZUX){psQiPIXjDj = true;}
          if(ibHToJfqXZ == cYWxdVUiEM){cIcBcqlDsk = true;}
          else if(cYWxdVUiEM == ibHToJfqXZ){UzQGHREZSo = true;}
          if(okWUigoLKC == EtbdeKACeK){ymCLPslFbL = true;}
          else if(EtbdeKACeK == okWUigoLKC){CebnoADJRo = true;}
          if(qWosrlJHyG == NNmmanhhzw){EGhDSJSTnp = true;}
          else if(NNmmanhhzw == qWosrlJHyG){IaQQJhWUWc = true;}
          if(PuUhWxDqQe == nJHXUyRbMP){CbhVhQRzBn = true;}
          else if(nJHXUyRbMP == PuUhWxDqQe){rirMYdHHyT = true;}
          if(oXPwHtNUhH == dxxnGPNlhU){ZmmlGZftFh = true;}
          if(TQORfLmNbD == PbSaAOliVp){EIMEGVaYhS = true;}
          if(zYsRJtQnyk == nmiIXumEJf){YRODhWFfcz = true;}
          while(dxxnGPNlhU == oXPwHtNUhH){nnKZJKQbsO = true;}
          while(PbSaAOliVp == TQORfLmNbD){EOSObsizxY = true;}
          while(nmiIXumEJf == zYsRJtQnyk){tjCowSlPPK = true;}
          if(rXpPgPQygK == true){rXpPgPQygK = false;}
          if(ZuAdfLpfWF == true){ZuAdfLpfWF = false;}
          if(MhFVaqNoQK == true){MhFVaqNoQK = false;}
          if(cIcBcqlDsk == true){cIcBcqlDsk = false;}
          if(ymCLPslFbL == true){ymCLPslFbL = false;}
          if(EGhDSJSTnp == true){EGhDSJSTnp = false;}
          if(CbhVhQRzBn == true){CbhVhQRzBn = false;}
          if(ZmmlGZftFh == true){ZmmlGZftFh = false;}
          if(EIMEGVaYhS == true){EIMEGVaYhS = false;}
          if(YRODhWFfcz == true){YRODhWFfcz = false;}
          if(amDmlQTwws == true){amDmlQTwws = false;}
          if(dYOFksOdPL == true){dYOFksOdPL = false;}
          if(psQiPIXjDj == true){psQiPIXjDj = false;}
          if(UzQGHREZSo == true){UzQGHREZSo = false;}
          if(CebnoADJRo == true){CebnoADJRo = false;}
          if(IaQQJhWUWc == true){IaQQJhWUWc = false;}
          if(rirMYdHHyT == true){rirMYdHHyT = false;}
          if(nnKZJKQbsO == true){nnKZJKQbsO = false;}
          if(EOSObsizxY == true){EOSObsizxY = false;}
          if(tjCowSlPPK == true){tjCowSlPPK = false;}
      } 
  }
} 

namespace SwBPkDcJf
{
  class KVNHICGNUT
  { 
      void fDwnoSZydA()
      { 
          bool VioyTQeBbS = false;
          bool IBnOtpcOyU = false;
          bool UugXxpFbLC = false;
          bool MriallpKOu = false;
          bool YykcGRMemh = false;
          bool HQedlZCRBc = false;
          bool LDpYGPSMcI = false;
          bool zRACwWJDQf = false;
          bool dZoduuMEnL = false;
          bool iYJljUHMWq = false;
          bool yzBdhoQbhP = false;
          bool PyBUzkOMdK = false;
          bool DOYQYaINSa = false;
          bool PxgZhdXKuF = false;
          bool ejVYwjXnly = false;
          bool GuhLmiakEH = false;
          bool gCJGASRamV = false;
          bool NDRYeTrAUo = false;
          bool CTbTUUOUly = false;
          bool CmFmXbZPXc = false;
          string VDqlyHadbn = null;
          string kXDgGxtEXj = null;
          string wQQSTjjjXY = null;
          string yofDmDUbxA = null;
          string XDROcipcKa = null;
          string yRRALEmYRN = null;
          string XpFDpuqztC = null;
          string cSHXLrzBok = null;
          string tHZwZfXerh = null;
          string QuJibhyOYh = null;
          string qqiIyfKsoS = null;
          string FligTQQIcJ = null;
          string WMGLlhIXud = null;
          string tkcGtDXQyt = null;
          string VdpYcdLcOL = null;
          string QokOLejWWQ = null;
          string WlyLYUIbmQ = null;
          string rzJimrVhiH = null;
          string VfJiMEzNuO = null;
          string SBthXjfdzH = null;
          if(VDqlyHadbn == qqiIyfKsoS){VioyTQeBbS = true;}
          else if(qqiIyfKsoS == VDqlyHadbn){yzBdhoQbhP = true;}
          if(kXDgGxtEXj == FligTQQIcJ){IBnOtpcOyU = true;}
          else if(FligTQQIcJ == kXDgGxtEXj){PyBUzkOMdK = true;}
          if(wQQSTjjjXY == WMGLlhIXud){UugXxpFbLC = true;}
          else if(WMGLlhIXud == wQQSTjjjXY){DOYQYaINSa = true;}
          if(yofDmDUbxA == tkcGtDXQyt){MriallpKOu = true;}
          else if(tkcGtDXQyt == yofDmDUbxA){PxgZhdXKuF = true;}
          if(XDROcipcKa == VdpYcdLcOL){YykcGRMemh = true;}
          else if(VdpYcdLcOL == XDROcipcKa){ejVYwjXnly = true;}
          if(yRRALEmYRN == QokOLejWWQ){HQedlZCRBc = true;}
          else if(QokOLejWWQ == yRRALEmYRN){GuhLmiakEH = true;}
          if(XpFDpuqztC == WlyLYUIbmQ){LDpYGPSMcI = true;}
          else if(WlyLYUIbmQ == XpFDpuqztC){gCJGASRamV = true;}
          if(cSHXLrzBok == rzJimrVhiH){zRACwWJDQf = true;}
          if(tHZwZfXerh == VfJiMEzNuO){dZoduuMEnL = true;}
          if(QuJibhyOYh == SBthXjfdzH){iYJljUHMWq = true;}
          while(rzJimrVhiH == cSHXLrzBok){NDRYeTrAUo = true;}
          while(VfJiMEzNuO == tHZwZfXerh){CTbTUUOUly = true;}
          while(SBthXjfdzH == QuJibhyOYh){CmFmXbZPXc = true;}
          if(VioyTQeBbS == true){VioyTQeBbS = false;}
          if(IBnOtpcOyU == true){IBnOtpcOyU = false;}
          if(UugXxpFbLC == true){UugXxpFbLC = false;}
          if(MriallpKOu == true){MriallpKOu = false;}
          if(YykcGRMemh == true){YykcGRMemh = false;}
          if(HQedlZCRBc == true){HQedlZCRBc = false;}
          if(LDpYGPSMcI == true){LDpYGPSMcI = false;}
          if(zRACwWJDQf == true){zRACwWJDQf = false;}
          if(dZoduuMEnL == true){dZoduuMEnL = false;}
          if(iYJljUHMWq == true){iYJljUHMWq = false;}
          if(yzBdhoQbhP == true){yzBdhoQbhP = false;}
          if(PyBUzkOMdK == true){PyBUzkOMdK = false;}
          if(DOYQYaINSa == true){DOYQYaINSa = false;}
          if(PxgZhdXKuF == true){PxgZhdXKuF = false;}
          if(ejVYwjXnly == true){ejVYwjXnly = false;}
          if(GuhLmiakEH == true){GuhLmiakEH = false;}
          if(gCJGASRamV == true){gCJGASRamV = false;}
          if(NDRYeTrAUo == true){NDRYeTrAUo = false;}
          if(CTbTUUOUly == true){CTbTUUOUly = false;}
          if(CmFmXbZPXc == true){CmFmXbZPXc = false;}
      } 
  }
} 

namespace utKHiLABo
{
  class JJTGLAYEDH
  { 
      void nEntpjSjLE()
      { 
          bool aYoQgXOdmH = false;
          bool wBVEhoYeLX = false;
          bool iRZNuhBJqB = false;
          bool culKDILbtP = false;
          bool XJuEtoYSzn = false;
          bool iYBKbIzaUz = false;
          bool VFlldBOLBZ = false;
          bool cxkuAYVUTG = false;
          bool IiJDRDtbit = false;
          bool IjGtsRXJZs = false;
          bool aNRZKlnFJC = false;
          bool mdHNqmuhTa = false;
          bool HmcGQspqCh = false;
          bool BLtZfuQjse = false;
          bool PnRfHebrDF = false;
          bool WopzlmjLIQ = false;
          bool uwDaAaihhu = false;
          bool WLnnKTUxyl = false;
          bool QxmwLMVumr = false;
          bool KEacjSjqeg = false;
          string nBxLpQmyeS = null;
          string QiqTLRZznj = null;
          string YELWfrTEFl = null;
          string xPJhZxZeBY = null;
          string PmeBkDtmFz = null;
          string gKJImipafy = null;
          string xhssVAZJsN = null;
          string rtyOUkYKlb = null;
          string yfzFFlGBuq = null;
          string HzyCbgslej = null;
          string dksqHlMtmB = null;
          string JenDzQinni = null;
          string tXOCGrwumm = null;
          string qmeCyNmIxS = null;
          string ZLNsgbKuDL = null;
          string yFywpGWqjP = null;
          string pQHAKWAlFl = null;
          string dZqUJhJUUe = null;
          string gArbnlnhMq = null;
          string puXhcIENiK = null;
          if(nBxLpQmyeS == dksqHlMtmB){aYoQgXOdmH = true;}
          else if(dksqHlMtmB == nBxLpQmyeS){aNRZKlnFJC = true;}
          if(QiqTLRZznj == JenDzQinni){wBVEhoYeLX = true;}
          else if(JenDzQinni == QiqTLRZznj){mdHNqmuhTa = true;}
          if(YELWfrTEFl == tXOCGrwumm){iRZNuhBJqB = true;}
          else if(tXOCGrwumm == YELWfrTEFl){HmcGQspqCh = true;}
          if(xPJhZxZeBY == qmeCyNmIxS){culKDILbtP = true;}
          else if(qmeCyNmIxS == xPJhZxZeBY){BLtZfuQjse = true;}
          if(PmeBkDtmFz == ZLNsgbKuDL){XJuEtoYSzn = true;}
          else if(ZLNsgbKuDL == PmeBkDtmFz){PnRfHebrDF = true;}
          if(gKJImipafy == yFywpGWqjP){iYBKbIzaUz = true;}
          else if(yFywpGWqjP == gKJImipafy){WopzlmjLIQ = true;}
          if(xhssVAZJsN == pQHAKWAlFl){VFlldBOLBZ = true;}
          else if(pQHAKWAlFl == xhssVAZJsN){uwDaAaihhu = true;}
          if(rtyOUkYKlb == dZqUJhJUUe){cxkuAYVUTG = true;}
          if(yfzFFlGBuq == gArbnlnhMq){IiJDRDtbit = true;}
          if(HzyCbgslej == puXhcIENiK){IjGtsRXJZs = true;}
          while(dZqUJhJUUe == rtyOUkYKlb){WLnnKTUxyl = true;}
          while(gArbnlnhMq == yfzFFlGBuq){QxmwLMVumr = true;}
          while(puXhcIENiK == HzyCbgslej){KEacjSjqeg = true;}
          if(aYoQgXOdmH == true){aYoQgXOdmH = false;}
          if(wBVEhoYeLX == true){wBVEhoYeLX = false;}
          if(iRZNuhBJqB == true){iRZNuhBJqB = false;}
          if(culKDILbtP == true){culKDILbtP = false;}
          if(XJuEtoYSzn == true){XJuEtoYSzn = false;}
          if(iYBKbIzaUz == true){iYBKbIzaUz = false;}
          if(VFlldBOLBZ == true){VFlldBOLBZ = false;}
          if(cxkuAYVUTG == true){cxkuAYVUTG = false;}
          if(IiJDRDtbit == true){IiJDRDtbit = false;}
          if(IjGtsRXJZs == true){IjGtsRXJZs = false;}
          if(aNRZKlnFJC == true){aNRZKlnFJC = false;}
          if(mdHNqmuhTa == true){mdHNqmuhTa = false;}
          if(HmcGQspqCh == true){HmcGQspqCh = false;}
          if(BLtZfuQjse == true){BLtZfuQjse = false;}
          if(PnRfHebrDF == true){PnRfHebrDF = false;}
          if(WopzlmjLIQ == true){WopzlmjLIQ = false;}
          if(uwDaAaihhu == true){uwDaAaihhu = false;}
          if(WLnnKTUxyl == true){WLnnKTUxyl = false;}
          if(QxmwLMVumr == true){QxmwLMVumr = false;}
          if(KEacjSjqeg == true){KEacjSjqeg = false;}
      } 
  }
} 

namespace cOkfDJKxR
{
  class IWULSHMEGR
  { 
      void duIVSLGUbZ()
      { 
          bool kVijAqPCjC = false;
          bool swAyMDVTrq = false;
          bool kCTWaZTefW = false;
          bool hFwRydOgiu = false;
          bool edmerYiuXJ = false;
          bool bWgJZiCLJZ = false;
          bool WjVNTmzizi = false;
          bool onkxLGPneB = false;
          bool pYHVuKYmqO = false;
          bool aCXIYuHYKE = false;
          bool ZAwnTmlixS = false;
          bool TNgHiybzRI = false;
          bool OLqjImPbXQ = false;
          bool ypdZbpbTCH = false;
          bool XopXuMVQZZ = false;
          bool SIHCpOIMfg = false;
          bool XKKfUdjGfs = false;
          bool VIxJjZVTou = false;
          bool RzCyypiajN = false;
          bool gPmVjNdJDQ = false;
          string fLgWCioPCZ = null;
          string WDIlJCnkVg = null;
          string HBXPnAPrUp = null;
          string yKpbEByqty = null;
          string rnSkIVIRlm = null;
          string kbTMednQiC = null;
          string SwuMaLNfgI = null;
          string DwpXnSilGR = null;
          string qxGgEWqcxZ = null;
          string MgIrewsFJx = null;
          string IbkdiolwXL = null;
          string uBKRLVpNIE = null;
          string UjiHuWnyrr = null;
          string ZcbJJOMbxO = null;
          string juFldKWqgJ = null;
          string FewEbXschM = null;
          string BmDfkSZAIw = null;
          string JNPtTZexcj = null;
          string zxRimtgWgk = null;
          string VisjNxqZAL = null;
          if(fLgWCioPCZ == IbkdiolwXL){kVijAqPCjC = true;}
          else if(IbkdiolwXL == fLgWCioPCZ){ZAwnTmlixS = true;}
          if(WDIlJCnkVg == uBKRLVpNIE){swAyMDVTrq = true;}
          else if(uBKRLVpNIE == WDIlJCnkVg){TNgHiybzRI = true;}
          if(HBXPnAPrUp == UjiHuWnyrr){kCTWaZTefW = true;}
          else if(UjiHuWnyrr == HBXPnAPrUp){OLqjImPbXQ = true;}
          if(yKpbEByqty == ZcbJJOMbxO){hFwRydOgiu = true;}
          else if(ZcbJJOMbxO == yKpbEByqty){ypdZbpbTCH = true;}
          if(rnSkIVIRlm == juFldKWqgJ){edmerYiuXJ = true;}
          else if(juFldKWqgJ == rnSkIVIRlm){XopXuMVQZZ = true;}
          if(kbTMednQiC == FewEbXschM){bWgJZiCLJZ = true;}
          else if(FewEbXschM == kbTMednQiC){SIHCpOIMfg = true;}
          if(SwuMaLNfgI == BmDfkSZAIw){WjVNTmzizi = true;}
          else if(BmDfkSZAIw == SwuMaLNfgI){XKKfUdjGfs = true;}
          if(DwpXnSilGR == JNPtTZexcj){onkxLGPneB = true;}
          if(qxGgEWqcxZ == zxRimtgWgk){pYHVuKYmqO = true;}
          if(MgIrewsFJx == VisjNxqZAL){aCXIYuHYKE = true;}
          while(JNPtTZexcj == DwpXnSilGR){VIxJjZVTou = true;}
          while(zxRimtgWgk == qxGgEWqcxZ){RzCyypiajN = true;}
          while(VisjNxqZAL == MgIrewsFJx){gPmVjNdJDQ = true;}
          if(kVijAqPCjC == true){kVijAqPCjC = false;}
          if(swAyMDVTrq == true){swAyMDVTrq = false;}
          if(kCTWaZTefW == true){kCTWaZTefW = false;}
          if(hFwRydOgiu == true){hFwRydOgiu = false;}
          if(edmerYiuXJ == true){edmerYiuXJ = false;}
          if(bWgJZiCLJZ == true){bWgJZiCLJZ = false;}
          if(WjVNTmzizi == true){WjVNTmzizi = false;}
          if(onkxLGPneB == true){onkxLGPneB = false;}
          if(pYHVuKYmqO == true){pYHVuKYmqO = false;}
          if(aCXIYuHYKE == true){aCXIYuHYKE = false;}
          if(ZAwnTmlixS == true){ZAwnTmlixS = false;}
          if(TNgHiybzRI == true){TNgHiybzRI = false;}
          if(OLqjImPbXQ == true){OLqjImPbXQ = false;}
          if(ypdZbpbTCH == true){ypdZbpbTCH = false;}
          if(XopXuMVQZZ == true){XopXuMVQZZ = false;}
          if(SIHCpOIMfg == true){SIHCpOIMfg = false;}
          if(XKKfUdjGfs == true){XKKfUdjGfs = false;}
          if(VIxJjZVTou == true){VIxJjZVTou = false;}
          if(RzCyypiajN == true){RzCyypiajN = false;}
          if(gPmVjNdJDQ == true){gPmVjNdJDQ = false;}
      } 
  }
} 

namespace yodybnSfI
{
  class YWJKLBDWWF
  { 
      void FeTCjomXuf()
      { 
          bool zzqqxtQaNc = false;
          bool kHqSrHawAp = false;
          bool XzkUbwmOEX = false;
          bool mhimaGKRQh = false;
          bool dxEPfkPXDF = false;
          bool IHJIfzOVPB = false;
          bool GBWppDXDrl = false;
          bool wJfRMauUop = false;
          bool gOKyPeXZGa = false;
          bool qnBPabZOZb = false;
          bool NLfQJybqwE = false;
          bool DtfZTqqXZK = false;
          bool eyxQuHIPqk = false;
          bool AgtNcVitoR = false;
          bool DgcBXxIawj = false;
          bool kCnPwONOVB = false;
          bool oLALDWzSxx = false;
          bool HwiIHyUusy = false;
          bool zgTGzyreQN = false;
          bool HUYmbqfRxA = false;
          string kcJCEKEymR = null;
          string ZqLdgNlwMO = null;
          string UbjWPJAUOn = null;
          string QZpBWRIwKD = null;
          string XQeydKRiAm = null;
          string dqiWKJrllu = null;
          string KiiyBzAJGP = null;
          string FokIpEwlsF = null;
          string qRUbKZqTqN = null;
          string YVKPsnhfxd = null;
          string KIbjgnFafG = null;
          string MGrgDrOGnb = null;
          string IfSsqieUPC = null;
          string VQnOtiojuV = null;
          string TPnjBRccMA = null;
          string YbrVVdpiry = null;
          string IjLdjwSdlU = null;
          string DeKRHrrhrZ = null;
          string FBIOctXSsQ = null;
          string sGqwMiEKzE = null;
          if(kcJCEKEymR == KIbjgnFafG){zzqqxtQaNc = true;}
          else if(KIbjgnFafG == kcJCEKEymR){NLfQJybqwE = true;}
          if(ZqLdgNlwMO == MGrgDrOGnb){kHqSrHawAp = true;}
          else if(MGrgDrOGnb == ZqLdgNlwMO){DtfZTqqXZK = true;}
          if(UbjWPJAUOn == IfSsqieUPC){XzkUbwmOEX = true;}
          else if(IfSsqieUPC == UbjWPJAUOn){eyxQuHIPqk = true;}
          if(QZpBWRIwKD == VQnOtiojuV){mhimaGKRQh = true;}
          else if(VQnOtiojuV == QZpBWRIwKD){AgtNcVitoR = true;}
          if(XQeydKRiAm == TPnjBRccMA){dxEPfkPXDF = true;}
          else if(TPnjBRccMA == XQeydKRiAm){DgcBXxIawj = true;}
          if(dqiWKJrllu == YbrVVdpiry){IHJIfzOVPB = true;}
          else if(YbrVVdpiry == dqiWKJrllu){kCnPwONOVB = true;}
          if(KiiyBzAJGP == IjLdjwSdlU){GBWppDXDrl = true;}
          else if(IjLdjwSdlU == KiiyBzAJGP){oLALDWzSxx = true;}
          if(FokIpEwlsF == DeKRHrrhrZ){wJfRMauUop = true;}
          if(qRUbKZqTqN == FBIOctXSsQ){gOKyPeXZGa = true;}
          if(YVKPsnhfxd == sGqwMiEKzE){qnBPabZOZb = true;}
          while(DeKRHrrhrZ == FokIpEwlsF){HwiIHyUusy = true;}
          while(FBIOctXSsQ == qRUbKZqTqN){zgTGzyreQN = true;}
          while(sGqwMiEKzE == YVKPsnhfxd){HUYmbqfRxA = true;}
          if(zzqqxtQaNc == true){zzqqxtQaNc = false;}
          if(kHqSrHawAp == true){kHqSrHawAp = false;}
          if(XzkUbwmOEX == true){XzkUbwmOEX = false;}
          if(mhimaGKRQh == true){mhimaGKRQh = false;}
          if(dxEPfkPXDF == true){dxEPfkPXDF = false;}
          if(IHJIfzOVPB == true){IHJIfzOVPB = false;}
          if(GBWppDXDrl == true){GBWppDXDrl = false;}
          if(wJfRMauUop == true){wJfRMauUop = false;}
          if(gOKyPeXZGa == true){gOKyPeXZGa = false;}
          if(qnBPabZOZb == true){qnBPabZOZb = false;}
          if(NLfQJybqwE == true){NLfQJybqwE = false;}
          if(DtfZTqqXZK == true){DtfZTqqXZK = false;}
          if(eyxQuHIPqk == true){eyxQuHIPqk = false;}
          if(AgtNcVitoR == true){AgtNcVitoR = false;}
          if(DgcBXxIawj == true){DgcBXxIawj = false;}
          if(kCnPwONOVB == true){kCnPwONOVB = false;}
          if(oLALDWzSxx == true){oLALDWzSxx = false;}
          if(HwiIHyUusy == true){HwiIHyUusy = false;}
          if(zgTGzyreQN == true){zgTGzyreQN = false;}
          if(HUYmbqfRxA == true){HUYmbqfRxA = false;}
      } 
  }
} 

namespace hUyGZnaWl
{
  class GOSXXFIMMT
  { 
      void oaDtnkFJqV()
      { 
          bool ADHqFHLQIi = false;
          bool GSZcExoQgG = false;
          bool wailyncrEG = false;
          bool yYGxMjCsLo = false;
          bool jPaiCelFVp = false;
          bool dXbCXZTVsR = false;
          bool eTLBjgLcQT = false;
          bool uuFqVgzAiS = false;
          bool BWVNcZxEZm = false;
          bool QfAsKPDZyU = false;
          bool TJoCuhSjgp = false;
          bool ZSlZPIxxYJ = false;
          bool jHDdCOuLgF = false;
          bool cZCNzrgTSt = false;
          bool GMXiMysZdB = false;
          bool SFBojLFLzf = false;
          bool mHDaNAQXaW = false;
          bool adedCXjUQE = false;
          bool VUhemXYMdm = false;
          bool lVUmHzIwUM = false;
          string qWwSfxwRsa = null;
          string yHcqEpBSEF = null;
          string CmYlTOkUap = null;
          string VNDNRnEtfV = null;
          string gIAFRNYdeW = null;
          string ahlTXExKyR = null;
          string LbpDFkEPZP = null;
          string lHlhXsmTUG = null;
          string oHoDOnaioN = null;
          string ptuOKFRxAf = null;
          string IIDPjTwEwd = null;
          string RdorbEllnR = null;
          string JUaMYrMWWR = null;
          string boSnxfDZSu = null;
          string qVmKuLECmG = null;
          string TeJiWnhqpr = null;
          string HYgdCbLBuw = null;
          string ALSrZmgPQM = null;
          string mJjQxwfjRJ = null;
          string xMianSoIIT = null;
          if(qWwSfxwRsa == IIDPjTwEwd){ADHqFHLQIi = true;}
          else if(IIDPjTwEwd == qWwSfxwRsa){TJoCuhSjgp = true;}
          if(yHcqEpBSEF == RdorbEllnR){GSZcExoQgG = true;}
          else if(RdorbEllnR == yHcqEpBSEF){ZSlZPIxxYJ = true;}
          if(CmYlTOkUap == JUaMYrMWWR){wailyncrEG = true;}
          else if(JUaMYrMWWR == CmYlTOkUap){jHDdCOuLgF = true;}
          if(VNDNRnEtfV == boSnxfDZSu){yYGxMjCsLo = true;}
          else if(boSnxfDZSu == VNDNRnEtfV){cZCNzrgTSt = true;}
          if(gIAFRNYdeW == qVmKuLECmG){jPaiCelFVp = true;}
          else if(qVmKuLECmG == gIAFRNYdeW){GMXiMysZdB = true;}
          if(ahlTXExKyR == TeJiWnhqpr){dXbCXZTVsR = true;}
          else if(TeJiWnhqpr == ahlTXExKyR){SFBojLFLzf = true;}
          if(LbpDFkEPZP == HYgdCbLBuw){eTLBjgLcQT = true;}
          else if(HYgdCbLBuw == LbpDFkEPZP){mHDaNAQXaW = true;}
          if(lHlhXsmTUG == ALSrZmgPQM){uuFqVgzAiS = true;}
          if(oHoDOnaioN == mJjQxwfjRJ){BWVNcZxEZm = true;}
          if(ptuOKFRxAf == xMianSoIIT){QfAsKPDZyU = true;}
          while(ALSrZmgPQM == lHlhXsmTUG){adedCXjUQE = true;}
          while(mJjQxwfjRJ == oHoDOnaioN){VUhemXYMdm = true;}
          while(xMianSoIIT == ptuOKFRxAf){lVUmHzIwUM = true;}
          if(ADHqFHLQIi == true){ADHqFHLQIi = false;}
          if(GSZcExoQgG == true){GSZcExoQgG = false;}
          if(wailyncrEG == true){wailyncrEG = false;}
          if(yYGxMjCsLo == true){yYGxMjCsLo = false;}
          if(jPaiCelFVp == true){jPaiCelFVp = false;}
          if(dXbCXZTVsR == true){dXbCXZTVsR = false;}
          if(eTLBjgLcQT == true){eTLBjgLcQT = false;}
          if(uuFqVgzAiS == true){uuFqVgzAiS = false;}
          if(BWVNcZxEZm == true){BWVNcZxEZm = false;}
          if(QfAsKPDZyU == true){QfAsKPDZyU = false;}
          if(TJoCuhSjgp == true){TJoCuhSjgp = false;}
          if(ZSlZPIxxYJ == true){ZSlZPIxxYJ = false;}
          if(jHDdCOuLgF == true){jHDdCOuLgF = false;}
          if(cZCNzrgTSt == true){cZCNzrgTSt = false;}
          if(GMXiMysZdB == true){GMXiMysZdB = false;}
          if(SFBojLFLzf == true){SFBojLFLzf = false;}
          if(mHDaNAQXaW == true){mHDaNAQXaW = false;}
          if(adedCXjUQE == true){adedCXjUQE = false;}
          if(VUhemXYMdm == true){VUhemXYMdm = false;}
          if(lVUmHzIwUM == true){lVUmHzIwUM = false;}
      } 
  }
} 

namespace XihnFLIOO
{
  class LARNYNAQOD
  { 
      void RixfmYMaHj()
      { 
          bool oiYBVcCBDE = false;
          bool btnDbERtuA = false;
          bool KpgKMwVhDj = false;
          bool ljBCFEICRU = false;
          bool OiMJatVapK = false;
          bool chcNpzCOoY = false;
          bool HUxTRqslyX = false;
          bool uObZlacXiR = false;
          bool atqsHEHmMF = false;
          bool BtNrMslsqj = false;
          bool BicSONFCbO = false;
          bool WeeXyMcDLN = false;
          bool iFYrVBBiMr = false;
          bool ojfzPqRYet = false;
          bool yFLxiWOptA = false;
          bool QhgdAuKjwM = false;
          bool LVoiYlyfHG = false;
          bool uEYROdtaJy = false;
          bool lLnMbHDBzU = false;
          bool ghcRhbQbXw = false;
          string KfERoaqYIh = null;
          string zAeiVjzbni = null;
          string qPzCRfawZc = null;
          string oOoNofJnOk = null;
          string AkVWcUYjeJ = null;
          string SrDDstfBzJ = null;
          string ztzfskLQsp = null;
          string aKNChGtbYx = null;
          string HqRQKwLlTu = null;
          string zHoFkGkpdr = null;
          string JHpohIeAUm = null;
          string zDcBBIchUw = null;
          string YYxypSUIRb = null;
          string UEygnzBchC = null;
          string RKQguuemDc = null;
          string cDUhSjKqyP = null;
          string mWisStFuNB = null;
          string GAASeOIPDu = null;
          string mhEnyRjPND = null;
          string oJdSPtbXOA = null;
          if(KfERoaqYIh == JHpohIeAUm){oiYBVcCBDE = true;}
          else if(JHpohIeAUm == KfERoaqYIh){BicSONFCbO = true;}
          if(zAeiVjzbni == zDcBBIchUw){btnDbERtuA = true;}
          else if(zDcBBIchUw == zAeiVjzbni){WeeXyMcDLN = true;}
          if(qPzCRfawZc == YYxypSUIRb){KpgKMwVhDj = true;}
          else if(YYxypSUIRb == qPzCRfawZc){iFYrVBBiMr = true;}
          if(oOoNofJnOk == UEygnzBchC){ljBCFEICRU = true;}
          else if(UEygnzBchC == oOoNofJnOk){ojfzPqRYet = true;}
          if(AkVWcUYjeJ == RKQguuemDc){OiMJatVapK = true;}
          else if(RKQguuemDc == AkVWcUYjeJ){yFLxiWOptA = true;}
          if(SrDDstfBzJ == cDUhSjKqyP){chcNpzCOoY = true;}
          else if(cDUhSjKqyP == SrDDstfBzJ){QhgdAuKjwM = true;}
          if(ztzfskLQsp == mWisStFuNB){HUxTRqslyX = true;}
          else if(mWisStFuNB == ztzfskLQsp){LVoiYlyfHG = true;}
          if(aKNChGtbYx == GAASeOIPDu){uObZlacXiR = true;}
          if(HqRQKwLlTu == mhEnyRjPND){atqsHEHmMF = true;}
          if(zHoFkGkpdr == oJdSPtbXOA){BtNrMslsqj = true;}
          while(GAASeOIPDu == aKNChGtbYx){uEYROdtaJy = true;}
          while(mhEnyRjPND == HqRQKwLlTu){lLnMbHDBzU = true;}
          while(oJdSPtbXOA == zHoFkGkpdr){ghcRhbQbXw = true;}
          if(oiYBVcCBDE == true){oiYBVcCBDE = false;}
          if(btnDbERtuA == true){btnDbERtuA = false;}
          if(KpgKMwVhDj == true){KpgKMwVhDj = false;}
          if(ljBCFEICRU == true){ljBCFEICRU = false;}
          if(OiMJatVapK == true){OiMJatVapK = false;}
          if(chcNpzCOoY == true){chcNpzCOoY = false;}
          if(HUxTRqslyX == true){HUxTRqslyX = false;}
          if(uObZlacXiR == true){uObZlacXiR = false;}
          if(atqsHEHmMF == true){atqsHEHmMF = false;}
          if(BtNrMslsqj == true){BtNrMslsqj = false;}
          if(BicSONFCbO == true){BicSONFCbO = false;}
          if(WeeXyMcDLN == true){WeeXyMcDLN = false;}
          if(iFYrVBBiMr == true){iFYrVBBiMr = false;}
          if(ojfzPqRYet == true){ojfzPqRYet = false;}
          if(yFLxiWOptA == true){yFLxiWOptA = false;}
          if(QhgdAuKjwM == true){QhgdAuKjwM = false;}
          if(LVoiYlyfHG == true){LVoiYlyfHG = false;}
          if(uEYROdtaJy == true){uEYROdtaJy = false;}
          if(lLnMbHDBzU == true){lLnMbHDBzU = false;}
          if(ghcRhbQbXw == true){ghcRhbQbXw = false;}
      } 
  }
} 

namespace qhCPacEEV
{
  class KVLXEDIQPS
  { 
      void sHqobUzxbn()
      { 
          bool TPEYXSmEob = false;
          bool JIzAMDfJFb = false;
          bool bQgknWWtyx = false;
          bool YfVTGHyoIe = false;
          bool IbfPLiIgWa = false;
          bool IBGPMCiSjB = false;
          bool usGqDcmftF = false;
          bool FqAZSzkQYF = false;
          bool NoWWnWZFGE = false;
          bool XeEGjPVnMh = false;
          bool wcmRVRBfwN = false;
          bool QStenFViDf = false;
          bool DgZpgZmsoD = false;
          bool cxDqIkBEBW = false;
          bool VsIrmFkYSd = false;
          bool tlkfdOCxku = false;
          bool dHpsjTOCVC = false;
          bool DQhfKJYgDa = false;
          bool oNZLIqMWMt = false;
          bool hETGrODOIS = false;
          string EIujUmdKoO = null;
          string BQuZxeouFd = null;
          string EXYPeDOwuW = null;
          string pmVNAazqVW = null;
          string UcNZMBjlec = null;
          string RoJhLgjfFQ = null;
          string XgOSYOtgYW = null;
          string fyZiJaJzCc = null;
          string ScRREAcnBT = null;
          string pSlEymNuBy = null;
          string HCMHxSPaYk = null;
          string WjcbxuPxNX = null;
          string lGeEfMMUjV = null;
          string MOyEVPPJTk = null;
          string jBOQxFoJGD = null;
          string XQgcLBXHaj = null;
          string GupDXIlYFg = null;
          string eFdcmjqOHZ = null;
          string XCOgxwgUrU = null;
          string rIhieoLLrn = null;
          if(EIujUmdKoO == HCMHxSPaYk){TPEYXSmEob = true;}
          else if(HCMHxSPaYk == EIujUmdKoO){wcmRVRBfwN = true;}
          if(BQuZxeouFd == WjcbxuPxNX){JIzAMDfJFb = true;}
          else if(WjcbxuPxNX == BQuZxeouFd){QStenFViDf = true;}
          if(EXYPeDOwuW == lGeEfMMUjV){bQgknWWtyx = true;}
          else if(lGeEfMMUjV == EXYPeDOwuW){DgZpgZmsoD = true;}
          if(pmVNAazqVW == MOyEVPPJTk){YfVTGHyoIe = true;}
          else if(MOyEVPPJTk == pmVNAazqVW){cxDqIkBEBW = true;}
          if(UcNZMBjlec == jBOQxFoJGD){IbfPLiIgWa = true;}
          else if(jBOQxFoJGD == UcNZMBjlec){VsIrmFkYSd = true;}
          if(RoJhLgjfFQ == XQgcLBXHaj){IBGPMCiSjB = true;}
          else if(XQgcLBXHaj == RoJhLgjfFQ){tlkfdOCxku = true;}
          if(XgOSYOtgYW == GupDXIlYFg){usGqDcmftF = true;}
          else if(GupDXIlYFg == XgOSYOtgYW){dHpsjTOCVC = true;}
          if(fyZiJaJzCc == eFdcmjqOHZ){FqAZSzkQYF = true;}
          if(ScRREAcnBT == XCOgxwgUrU){NoWWnWZFGE = true;}
          if(pSlEymNuBy == rIhieoLLrn){XeEGjPVnMh = true;}
          while(eFdcmjqOHZ == fyZiJaJzCc){DQhfKJYgDa = true;}
          while(XCOgxwgUrU == ScRREAcnBT){oNZLIqMWMt = true;}
          while(rIhieoLLrn == pSlEymNuBy){hETGrODOIS = true;}
          if(TPEYXSmEob == true){TPEYXSmEob = false;}
          if(JIzAMDfJFb == true){JIzAMDfJFb = false;}
          if(bQgknWWtyx == true){bQgknWWtyx = false;}
          if(YfVTGHyoIe == true){YfVTGHyoIe = false;}
          if(IbfPLiIgWa == true){IbfPLiIgWa = false;}
          if(IBGPMCiSjB == true){IBGPMCiSjB = false;}
          if(usGqDcmftF == true){usGqDcmftF = false;}
          if(FqAZSzkQYF == true){FqAZSzkQYF = false;}
          if(NoWWnWZFGE == true){NoWWnWZFGE = false;}
          if(XeEGjPVnMh == true){XeEGjPVnMh = false;}
          if(wcmRVRBfwN == true){wcmRVRBfwN = false;}
          if(QStenFViDf == true){QStenFViDf = false;}
          if(DgZpgZmsoD == true){DgZpgZmsoD = false;}
          if(cxDqIkBEBW == true){cxDqIkBEBW = false;}
          if(VsIrmFkYSd == true){VsIrmFkYSd = false;}
          if(tlkfdOCxku == true){tlkfdOCxku = false;}
          if(dHpsjTOCVC == true){dHpsjTOCVC = false;}
          if(DQhfKJYgDa == true){DQhfKJYgDa = false;}
          if(oNZLIqMWMt == true){oNZLIqMWMt = false;}
          if(hETGrODOIS == true){hETGrODOIS = false;}
      } 
  }
} 

namespace dXFUGPhAU
{
  class KXQVRTJWNU
  { 
      void tsOoiEPCic()
      { 
          bool REPDJUjDtP = false;
          bool MZKOjCWyDK = false;
          bool NXoZGKRRsW = false;
          bool LBnuAmMAir = false;
          bool VoBWlBpkzz = false;
          bool SJOBstOpxy = false;
          bool DSKXDKkPOw = false;
          bool pWOLoYWSmE = false;
          bool UgRtEBmmBG = false;
          bool XVDjoCdcSb = false;
          bool QaVDJuuCLU = false;
          bool WwDrdVAPSC = false;
          bool WyNHXUTdWm = false;
          bool tszKnsKOkI = false;
          bool FkagjbRKFS = false;
          bool BNKQFSNOeo = false;
          bool bQfYZcxsEk = false;
          bool LleJwkWgXw = false;
          bool CIXEkfihEV = false;
          bool fwiwgoFBGG = false;
          string fxaRVXnywR = null;
          string yCGNjIVTeq = null;
          string UJkCzeDUVm = null;
          string GYAnjVDLKS = null;
          string FbmwcjXIBH = null;
          string HYSCBVLXSp = null;
          string UTbILZBRdO = null;
          string FKIMlrWnZO = null;
          string HtTOegGymN = null;
          string JfsTxlAdkD = null;
          string iFelCxPGPJ = null;
          string zWyDiazNdd = null;
          string TCeQEZRoOz = null;
          string rsDVeBOgMh = null;
          string QzhdNlgokV = null;
          string mlzHifaNgb = null;
          string eaqQQGTbYg = null;
          string LRBwMTTBCS = null;
          string rcDsMFsulz = null;
          string aBzjCoIRMH = null;
          if(fxaRVXnywR == iFelCxPGPJ){REPDJUjDtP = true;}
          else if(iFelCxPGPJ == fxaRVXnywR){QaVDJuuCLU = true;}
          if(yCGNjIVTeq == zWyDiazNdd){MZKOjCWyDK = true;}
          else if(zWyDiazNdd == yCGNjIVTeq){WwDrdVAPSC = true;}
          if(UJkCzeDUVm == TCeQEZRoOz){NXoZGKRRsW = true;}
          else if(TCeQEZRoOz == UJkCzeDUVm){WyNHXUTdWm = true;}
          if(GYAnjVDLKS == rsDVeBOgMh){LBnuAmMAir = true;}
          else if(rsDVeBOgMh == GYAnjVDLKS){tszKnsKOkI = true;}
          if(FbmwcjXIBH == QzhdNlgokV){VoBWlBpkzz = true;}
          else if(QzhdNlgokV == FbmwcjXIBH){FkagjbRKFS = true;}
          if(HYSCBVLXSp == mlzHifaNgb){SJOBstOpxy = true;}
          else if(mlzHifaNgb == HYSCBVLXSp){BNKQFSNOeo = true;}
          if(UTbILZBRdO == eaqQQGTbYg){DSKXDKkPOw = true;}
          else if(eaqQQGTbYg == UTbILZBRdO){bQfYZcxsEk = true;}
          if(FKIMlrWnZO == LRBwMTTBCS){pWOLoYWSmE = true;}
          if(HtTOegGymN == rcDsMFsulz){UgRtEBmmBG = true;}
          if(JfsTxlAdkD == aBzjCoIRMH){XVDjoCdcSb = true;}
          while(LRBwMTTBCS == FKIMlrWnZO){LleJwkWgXw = true;}
          while(rcDsMFsulz == HtTOegGymN){CIXEkfihEV = true;}
          while(aBzjCoIRMH == JfsTxlAdkD){fwiwgoFBGG = true;}
          if(REPDJUjDtP == true){REPDJUjDtP = false;}
          if(MZKOjCWyDK == true){MZKOjCWyDK = false;}
          if(NXoZGKRRsW == true){NXoZGKRRsW = false;}
          if(LBnuAmMAir == true){LBnuAmMAir = false;}
          if(VoBWlBpkzz == true){VoBWlBpkzz = false;}
          if(SJOBstOpxy == true){SJOBstOpxy = false;}
          if(DSKXDKkPOw == true){DSKXDKkPOw = false;}
          if(pWOLoYWSmE == true){pWOLoYWSmE = false;}
          if(UgRtEBmmBG == true){UgRtEBmmBG = false;}
          if(XVDjoCdcSb == true){XVDjoCdcSb = false;}
          if(QaVDJuuCLU == true){QaVDJuuCLU = false;}
          if(WwDrdVAPSC == true){WwDrdVAPSC = false;}
          if(WyNHXUTdWm == true){WyNHXUTdWm = false;}
          if(tszKnsKOkI == true){tszKnsKOkI = false;}
          if(FkagjbRKFS == true){FkagjbRKFS = false;}
          if(BNKQFSNOeo == true){BNKQFSNOeo = false;}
          if(bQfYZcxsEk == true){bQfYZcxsEk = false;}
          if(LleJwkWgXw == true){LleJwkWgXw = false;}
          if(CIXEkfihEV == true){CIXEkfihEV = false;}
          if(fwiwgoFBGG == true){fwiwgoFBGG = false;}
      } 
  }
} 

namespace QCUfbAWQu
{
  class ZIEPFNLMQC
  { 
      void esfbLCducz()
      { 
          bool prZuWODrWN = false;
          bool wGVNzAzzWs = false;
          bool oSyTjUJqNA = false;
          bool qnGyTfGuns = false;
          bool pDAZAlwfZt = false;
          bool safXZXsGLB = false;
          bool FMdWVHzXtT = false;
          bool tDLdCkRXTx = false;
          bool YdRTHQHhXu = false;
          bool lAjlmdYdEr = false;
          bool lYkFzoOBUn = false;
          bool GUlNcbtKPF = false;
          bool AQzygsTYpY = false;
          bool LmTaLArLTR = false;
          bool BGNjoRNWIL = false;
          bool iNOzrUYmYF = false;
          bool UpLwbSAKBc = false;
          bool iiqxDsDOIO = false;
          bool fxPdpxYUip = false;
          bool aFmNxLtRHW = false;
          string wnNJBQAYMu = null;
          string dWqlRlrqwH = null;
          string OihDQWhxnu = null;
          string gLJGtQwgDe = null;
          string qSBEBXqmPQ = null;
          string OsuVzNGJre = null;
          string hDkQOSMjrA = null;
          string pKnQPwgcCs = null;
          string eugXfnPnHf = null;
          string JlnYwnhkpi = null;
          string KHtOaDFeGC = null;
          string gcHyAmVMja = null;
          string CYcLqDWOTa = null;
          string OwmThWARwb = null;
          string hkhEzgepXJ = null;
          string SUAOflehXX = null;
          string gpKemkpmPc = null;
          string lDQIrRpXMJ = null;
          string XfqKItuXnw = null;
          string rRtYtrZCQO = null;
          if(wnNJBQAYMu == KHtOaDFeGC){prZuWODrWN = true;}
          else if(KHtOaDFeGC == wnNJBQAYMu){lYkFzoOBUn = true;}
          if(dWqlRlrqwH == gcHyAmVMja){wGVNzAzzWs = true;}
          else if(gcHyAmVMja == dWqlRlrqwH){GUlNcbtKPF = true;}
          if(OihDQWhxnu == CYcLqDWOTa){oSyTjUJqNA = true;}
          else if(CYcLqDWOTa == OihDQWhxnu){AQzygsTYpY = true;}
          if(gLJGtQwgDe == OwmThWARwb){qnGyTfGuns = true;}
          else if(OwmThWARwb == gLJGtQwgDe){LmTaLArLTR = true;}
          if(qSBEBXqmPQ == hkhEzgepXJ){pDAZAlwfZt = true;}
          else if(hkhEzgepXJ == qSBEBXqmPQ){BGNjoRNWIL = true;}
          if(OsuVzNGJre == SUAOflehXX){safXZXsGLB = true;}
          else if(SUAOflehXX == OsuVzNGJre){iNOzrUYmYF = true;}
          if(hDkQOSMjrA == gpKemkpmPc){FMdWVHzXtT = true;}
          else if(gpKemkpmPc == hDkQOSMjrA){UpLwbSAKBc = true;}
          if(pKnQPwgcCs == lDQIrRpXMJ){tDLdCkRXTx = true;}
          if(eugXfnPnHf == XfqKItuXnw){YdRTHQHhXu = true;}
          if(JlnYwnhkpi == rRtYtrZCQO){lAjlmdYdEr = true;}
          while(lDQIrRpXMJ == pKnQPwgcCs){iiqxDsDOIO = true;}
          while(XfqKItuXnw == eugXfnPnHf){fxPdpxYUip = true;}
          while(rRtYtrZCQO == JlnYwnhkpi){aFmNxLtRHW = true;}
          if(prZuWODrWN == true){prZuWODrWN = false;}
          if(wGVNzAzzWs == true){wGVNzAzzWs = false;}
          if(oSyTjUJqNA == true){oSyTjUJqNA = false;}
          if(qnGyTfGuns == true){qnGyTfGuns = false;}
          if(pDAZAlwfZt == true){pDAZAlwfZt = false;}
          if(safXZXsGLB == true){safXZXsGLB = false;}
          if(FMdWVHzXtT == true){FMdWVHzXtT = false;}
          if(tDLdCkRXTx == true){tDLdCkRXTx = false;}
          if(YdRTHQHhXu == true){YdRTHQHhXu = false;}
          if(lAjlmdYdEr == true){lAjlmdYdEr = false;}
          if(lYkFzoOBUn == true){lYkFzoOBUn = false;}
          if(GUlNcbtKPF == true){GUlNcbtKPF = false;}
          if(AQzygsTYpY == true){AQzygsTYpY = false;}
          if(LmTaLArLTR == true){LmTaLArLTR = false;}
          if(BGNjoRNWIL == true){BGNjoRNWIL = false;}
          if(iNOzrUYmYF == true){iNOzrUYmYF = false;}
          if(UpLwbSAKBc == true){UpLwbSAKBc = false;}
          if(iiqxDsDOIO == true){iiqxDsDOIO = false;}
          if(fxPdpxYUip == true){fxPdpxYUip = false;}
          if(aFmNxLtRHW == true){aFmNxLtRHW = false;}
      } 
  }
} 

namespace TgTnHImdp
{
  class MVBKYMJIZU
  { 
      void xftuIkrbTF()
      { 
          bool dIeMbWjPjN = false;
          bool ToyckqiitK = false;
          bool UVfmEwiTzI = false;
          bool EyCSWAIBTF = false;
          bool lzIZIbbkGk = false;
          bool OICBPHcrIf = false;
          bool mPQaJUmeFk = false;
          bool hgPnYVNGeb = false;
          bool UyNNsuwBDP = false;
          bool XQsmSVhgQn = false;
          bool oweVDhsNbs = false;
          bool sWNfLoCCgN = false;
          bool XkapMQmbVD = false;
          bool mgopmXSrKL = false;
          bool BhYJVBDMbc = false;
          bool SezCPDUoIl = false;
          bool tRrYFMgWsn = false;
          bool VKrVLpLRUL = false;
          bool NaArjIglaj = false;
          bool CdiYQjpADI = false;
          string lfNhRQeueB = null;
          string hWHSsQRSta = null;
          string YNJVEsOXdX = null;
          string IQSGiKlfwA = null;
          string RLgjtiMKHL = null;
          string BRTdNXVrcX = null;
          string CHQGrQEBji = null;
          string elWsINgZaV = null;
          string gDQSWqxosL = null;
          string nsCYyKtaqc = null;
          string dLaXfOuZUA = null;
          string pwQHpzpyiB = null;
          string TPHYtlixux = null;
          string SGhxqUbrlH = null;
          string uWTsUrbuhz = null;
          string UwqpJODCdt = null;
          string fxeWgjOTPU = null;
          string WxLaGwuODB = null;
          string JnOwcVOrmb = null;
          string QZNqbxrwLj = null;
          if(lfNhRQeueB == dLaXfOuZUA){dIeMbWjPjN = true;}
          else if(dLaXfOuZUA == lfNhRQeueB){oweVDhsNbs = true;}
          if(hWHSsQRSta == pwQHpzpyiB){ToyckqiitK = true;}
          else if(pwQHpzpyiB == hWHSsQRSta){sWNfLoCCgN = true;}
          if(YNJVEsOXdX == TPHYtlixux){UVfmEwiTzI = true;}
          else if(TPHYtlixux == YNJVEsOXdX){XkapMQmbVD = true;}
          if(IQSGiKlfwA == SGhxqUbrlH){EyCSWAIBTF = true;}
          else if(SGhxqUbrlH == IQSGiKlfwA){mgopmXSrKL = true;}
          if(RLgjtiMKHL == uWTsUrbuhz){lzIZIbbkGk = true;}
          else if(uWTsUrbuhz == RLgjtiMKHL){BhYJVBDMbc = true;}
          if(BRTdNXVrcX == UwqpJODCdt){OICBPHcrIf = true;}
          else if(UwqpJODCdt == BRTdNXVrcX){SezCPDUoIl = true;}
          if(CHQGrQEBji == fxeWgjOTPU){mPQaJUmeFk = true;}
          else if(fxeWgjOTPU == CHQGrQEBji){tRrYFMgWsn = true;}
          if(elWsINgZaV == WxLaGwuODB){hgPnYVNGeb = true;}
          if(gDQSWqxosL == JnOwcVOrmb){UyNNsuwBDP = true;}
          if(nsCYyKtaqc == QZNqbxrwLj){XQsmSVhgQn = true;}
          while(WxLaGwuODB == elWsINgZaV){VKrVLpLRUL = true;}
          while(JnOwcVOrmb == gDQSWqxosL){NaArjIglaj = true;}
          while(QZNqbxrwLj == nsCYyKtaqc){CdiYQjpADI = true;}
          if(dIeMbWjPjN == true){dIeMbWjPjN = false;}
          if(ToyckqiitK == true){ToyckqiitK = false;}
          if(UVfmEwiTzI == true){UVfmEwiTzI = false;}
          if(EyCSWAIBTF == true){EyCSWAIBTF = false;}
          if(lzIZIbbkGk == true){lzIZIbbkGk = false;}
          if(OICBPHcrIf == true){OICBPHcrIf = false;}
          if(mPQaJUmeFk == true){mPQaJUmeFk = false;}
          if(hgPnYVNGeb == true){hgPnYVNGeb = false;}
          if(UyNNsuwBDP == true){UyNNsuwBDP = false;}
          if(XQsmSVhgQn == true){XQsmSVhgQn = false;}
          if(oweVDhsNbs == true){oweVDhsNbs = false;}
          if(sWNfLoCCgN == true){sWNfLoCCgN = false;}
          if(XkapMQmbVD == true){XkapMQmbVD = false;}
          if(mgopmXSrKL == true){mgopmXSrKL = false;}
          if(BhYJVBDMbc == true){BhYJVBDMbc = false;}
          if(SezCPDUoIl == true){SezCPDUoIl = false;}
          if(tRrYFMgWsn == true){tRrYFMgWsn = false;}
          if(VKrVLpLRUL == true){VKrVLpLRUL = false;}
          if(NaArjIglaj == true){NaArjIglaj = false;}
          if(CdiYQjpADI == true){CdiYQjpADI = false;}
      } 
  }
} 

namespace PYehMcoZm
{
  class JSPZWNLYEM
  { 
      void quagfnmTQV()
      { 
          bool tVYWKmfPhU = false;
          bool SpclkRhnBs = false;
          bool HFEeCwIVDF = false;
          bool XhiqwXRztu = false;
          bool MshRiTMOtH = false;
          bool TMPyCnRtUN = false;
          bool eKMbxkHlpN = false;
          bool AisGgNXmwi = false;
          bool jsaulKRjnH = false;
          bool GXefQBgFTy = false;
          bool LZYgGkTJRo = false;
          bool PdykdliQpl = false;
          bool SWxhHcDMpe = false;
          bool gRSyWJTtnA = false;
          bool qISzrbZsCd = false;
          bool RQPheocpYd = false;
          bool gHTlHxLANU = false;
          bool RobouKDxpe = false;
          bool DKKLMPCjSh = false;
          bool fdUKTjnfqt = false;
          string qwgPjgCwEo = null;
          string sRQmjzCbmH = null;
          string eQFNZFAyiB = null;
          string FlzXTjFxAi = null;
          string pIIqTlLZji = null;
          string LmyghaqSoe = null;
          string fDNCjGSrTA = null;
          string tFaERVINtn = null;
          string sZOApSnRor = null;
          string slHVCluFHM = null;
          string TSFjnGLtPM = null;
          string ScYBlGoNMQ = null;
          string SBDaGIxFBe = null;
          string aCGgTZTeLi = null;
          string HsBcZQNGiw = null;
          string xhsptRPdcf = null;
          string JFrjlPVqgL = null;
          string lJBcIYzZBp = null;
          string tqWEhrIPmB = null;
          string JoBfZCARqJ = null;
          if(qwgPjgCwEo == TSFjnGLtPM){tVYWKmfPhU = true;}
          else if(TSFjnGLtPM == qwgPjgCwEo){LZYgGkTJRo = true;}
          if(sRQmjzCbmH == ScYBlGoNMQ){SpclkRhnBs = true;}
          else if(ScYBlGoNMQ == sRQmjzCbmH){PdykdliQpl = true;}
          if(eQFNZFAyiB == SBDaGIxFBe){HFEeCwIVDF = true;}
          else if(SBDaGIxFBe == eQFNZFAyiB){SWxhHcDMpe = true;}
          if(FlzXTjFxAi == aCGgTZTeLi){XhiqwXRztu = true;}
          else if(aCGgTZTeLi == FlzXTjFxAi){gRSyWJTtnA = true;}
          if(pIIqTlLZji == HsBcZQNGiw){MshRiTMOtH = true;}
          else if(HsBcZQNGiw == pIIqTlLZji){qISzrbZsCd = true;}
          if(LmyghaqSoe == xhsptRPdcf){TMPyCnRtUN = true;}
          else if(xhsptRPdcf == LmyghaqSoe){RQPheocpYd = true;}
          if(fDNCjGSrTA == JFrjlPVqgL){eKMbxkHlpN = true;}
          else if(JFrjlPVqgL == fDNCjGSrTA){gHTlHxLANU = true;}
          if(tFaERVINtn == lJBcIYzZBp){AisGgNXmwi = true;}
          if(sZOApSnRor == tqWEhrIPmB){jsaulKRjnH = true;}
          if(slHVCluFHM == JoBfZCARqJ){GXefQBgFTy = true;}
          while(lJBcIYzZBp == tFaERVINtn){RobouKDxpe = true;}
          while(tqWEhrIPmB == sZOApSnRor){DKKLMPCjSh = true;}
          while(JoBfZCARqJ == slHVCluFHM){fdUKTjnfqt = true;}
          if(tVYWKmfPhU == true){tVYWKmfPhU = false;}
          if(SpclkRhnBs == true){SpclkRhnBs = false;}
          if(HFEeCwIVDF == true){HFEeCwIVDF = false;}
          if(XhiqwXRztu == true){XhiqwXRztu = false;}
          if(MshRiTMOtH == true){MshRiTMOtH = false;}
          if(TMPyCnRtUN == true){TMPyCnRtUN = false;}
          if(eKMbxkHlpN == true){eKMbxkHlpN = false;}
          if(AisGgNXmwi == true){AisGgNXmwi = false;}
          if(jsaulKRjnH == true){jsaulKRjnH = false;}
          if(GXefQBgFTy == true){GXefQBgFTy = false;}
          if(LZYgGkTJRo == true){LZYgGkTJRo = false;}
          if(PdykdliQpl == true){PdykdliQpl = false;}
          if(SWxhHcDMpe == true){SWxhHcDMpe = false;}
          if(gRSyWJTtnA == true){gRSyWJTtnA = false;}
          if(qISzrbZsCd == true){qISzrbZsCd = false;}
          if(RQPheocpYd == true){RQPheocpYd = false;}
          if(gHTlHxLANU == true){gHTlHxLANU = false;}
          if(RobouKDxpe == true){RobouKDxpe = false;}
          if(DKKLMPCjSh == true){DKKLMPCjSh = false;}
          if(fdUKTjnfqt == true){fdUKTjnfqt = false;}
      } 
  }
} 

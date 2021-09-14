using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;



namespace xam
{
    public partial class Menu : MetroFramework.Forms.MetroForm
    {
        #region vars
        public static bool activ = false;
        public static bool minmax = false;
        public static bool test1 = false;

        public static int min = 0;
        public static int max = 1;
        public static int smooth = 1;
        public static double sense = 1.0;
        public static int fov = 90;

        public static string weapon;
        public static string attachment;
        public static string scope;

        #endregion
        public Menu()
        {
            InitializeComponent();
        }
        #region bool
        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(metroCheckBox1.Checked)
            {
                activ = true;
            }
            else
            {
                activ = false;
            }
        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox2.Checked)
            {
                minmax = true;
            }
            else
            {
                minmax = false;
            }
        }
        private void metroCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox3.Checked)
            {
                test1 = true;
            }
            else
            {
                test1 = false;
            }
        }

        #endregion
        #region int
        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            min = metroTrackBar1.Value;
        }

        private void metroTrackBar2_Scroll(object sender, ScrollEventArgs e)
        {
            max = metroTrackBar2.Value;
        }

        private void metroTrackBar3_Scroll(object sender, ScrollEventArgs e)
        {
            smooth = metroTrackBar3.Value;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            sense = Convert.ToDouble(numericUpDown1.Value);
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            fov = Convert.ToInt32(numericUpDown2.Value);
        }
        #endregion
        #region string
        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            weapon = (string)metroComboBox1.SelectedItem;
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            attachment = (string)metroComboBox2.SelectedItem;
        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            scope = (string)metroComboBox3.SelectedItem;
        }
        #endregion

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

    }
}

namespace CiQicQZXG
{
  class IREEJBLILK
  { 
      void fgsPeKlRmZ()
      { 
          bool FIBxGXjRpP = false;
          bool qUELnRpVcI = false;
          bool QjsndKQADH = false;
          bool oyYtcFETRB = false;
          bool UFMDxHwiVq = false;
          bool iysllUPNSu = false;
          bool GjNhasuKhh = false;
          bool NWEbnKXopW = false;
          bool NgdMYqFlHH = false;
          bool ppAVtjqdcE = false;
          bool LlAmcLtQyb = false;
          bool xZWwgYFAJj = false;
          bool nIDarWWhgD = false;
          bool SsMlKbgqjM = false;
          bool xnnfJPTDnU = false;
          bool eqUsQDhZtG = false;
          bool oLjtIEMklF = false;
          bool rOQxlzTXQb = false;
          bool DSsMYbXTVG = false;
          bool tGwdWkEtXF = false;
          string xeDXViQYVr = null;
          string iRBeCnnfcq = null;
          string BdKHmKTGCo = null;
          string ZMpyDXYtlA = null;
          string ulDBRgWUxC = null;
          string BTNGbSUwkK = null;
          string PJVfSVbCbd = null;
          string OttbuOZIoF = null;
          string myIAmFziWk = null;
          string DcJakkPXiw = null;
          string EUsTnHZkLM = null;
          string rLGeXRBVrM = null;
          string WrepZkjSqJ = null;
          string yCYsBREoMf = null;
          string fNXJsrWeCT = null;
          string jteWYLpCsC = null;
          string WGtCNolNcF = null;
          string MMJMgIUUxh = null;
          string OFQXYEXCTo = null;
          string bBuJIYTVuD = null;
          if(xeDXViQYVr == EUsTnHZkLM){FIBxGXjRpP = true;}
          else if(EUsTnHZkLM == xeDXViQYVr){LlAmcLtQyb = true;}
          if(iRBeCnnfcq == rLGeXRBVrM){qUELnRpVcI = true;}
          else if(rLGeXRBVrM == iRBeCnnfcq){xZWwgYFAJj = true;}
          if(BdKHmKTGCo == WrepZkjSqJ){QjsndKQADH = true;}
          else if(WrepZkjSqJ == BdKHmKTGCo){nIDarWWhgD = true;}
          if(ZMpyDXYtlA == yCYsBREoMf){oyYtcFETRB = true;}
          else if(yCYsBREoMf == ZMpyDXYtlA){SsMlKbgqjM = true;}
          if(ulDBRgWUxC == fNXJsrWeCT){UFMDxHwiVq = true;}
          else if(fNXJsrWeCT == ulDBRgWUxC){xnnfJPTDnU = true;}
          if(BTNGbSUwkK == jteWYLpCsC){iysllUPNSu = true;}
          else if(jteWYLpCsC == BTNGbSUwkK){eqUsQDhZtG = true;}
          if(PJVfSVbCbd == WGtCNolNcF){GjNhasuKhh = true;}
          else if(WGtCNolNcF == PJVfSVbCbd){oLjtIEMklF = true;}
          if(OttbuOZIoF == MMJMgIUUxh){NWEbnKXopW = true;}
          if(myIAmFziWk == OFQXYEXCTo){NgdMYqFlHH = true;}
          if(DcJakkPXiw == bBuJIYTVuD){ppAVtjqdcE = true;}
          while(MMJMgIUUxh == OttbuOZIoF){rOQxlzTXQb = true;}
          while(OFQXYEXCTo == myIAmFziWk){DSsMYbXTVG = true;}
          while(bBuJIYTVuD == DcJakkPXiw){tGwdWkEtXF = true;}
          if(FIBxGXjRpP == true){FIBxGXjRpP = false;}
          if(qUELnRpVcI == true){qUELnRpVcI = false;}
          if(QjsndKQADH == true){QjsndKQADH = false;}
          if(oyYtcFETRB == true){oyYtcFETRB = false;}
          if(UFMDxHwiVq == true){UFMDxHwiVq = false;}
          if(iysllUPNSu == true){iysllUPNSu = false;}
          if(GjNhasuKhh == true){GjNhasuKhh = false;}
          if(NWEbnKXopW == true){NWEbnKXopW = false;}
          if(NgdMYqFlHH == true){NgdMYqFlHH = false;}
          if(ppAVtjqdcE == true){ppAVtjqdcE = false;}
          if(LlAmcLtQyb == true){LlAmcLtQyb = false;}
          if(xZWwgYFAJj == true){xZWwgYFAJj = false;}
          if(nIDarWWhgD == true){nIDarWWhgD = false;}
          if(SsMlKbgqjM == true){SsMlKbgqjM = false;}
          if(xnnfJPTDnU == true){xnnfJPTDnU = false;}
          if(eqUsQDhZtG == true){eqUsQDhZtG = false;}
          if(oLjtIEMklF == true){oLjtIEMklF = false;}
          if(rOQxlzTXQb == true){rOQxlzTXQb = false;}
          if(DSsMYbXTVG == true){DSsMYbXTVG = false;}
          if(tGwdWkEtXF == true){tGwdWkEtXF = false;}
      } 
  }
} 

namespace kJpmIChSa
{
  class NPFNJMLWMU
  { 
      void ZUwsaSVFrp()
      { 
          bool UautsHcSGp = false;
          bool QAWJyDWSby = false;
          bool QydwZVAcVA = false;
          bool gnARVbPVaj = false;
          bool tUrKfYJMYY = false;
          bool oYgMtWxzTW = false;
          bool GAxFJcAFnV = false;
          bool mBrqDuFSPA = false;
          bool LnDwKIGmWy = false;
          bool eQBDctXlBD = false;
          bool YEXCknfpJy = false;
          bool QeiTLSwAtB = false;
          bool VMhoqWzoNJ = false;
          bool XTQLbHPBLW = false;
          bool bPdXhzghqK = false;
          bool yWqzgMViLO = false;
          bool opcAaxNXqE = false;
          bool CuoXYGhJHr = false;
          bool oRxCKAbQdP = false;
          bool kgpwglmdxj = false;
          string OxRmicuRwi = null;
          string KFgthxjzcn = null;
          string NBjkkCXZIG = null;
          string caIfitjsLi = null;
          string sKtlBkIBwY = null;
          string DiumaNNfCg = null;
          string EVIpGiwALn = null;
          string NpnsuCGyjz = null;
          string tVcjCtfVFU = null;
          string gDqeeXBDfS = null;
          string nHoHLMuBrX = null;
          string GOwDlirYmL = null;
          string DatpHJyIOW = null;
          string BDSQKmfVYp = null;
          string yddhORGnsu = null;
          string ecPTPNMzzB = null;
          string NllUWDwesz = null;
          string CWzxMYxMbp = null;
          string DKPTrXmyBw = null;
          string ZgVWbMqJLK = null;
          if(OxRmicuRwi == nHoHLMuBrX){UautsHcSGp = true;}
          else if(nHoHLMuBrX == OxRmicuRwi){YEXCknfpJy = true;}
          if(KFgthxjzcn == GOwDlirYmL){QAWJyDWSby = true;}
          else if(GOwDlirYmL == KFgthxjzcn){QeiTLSwAtB = true;}
          if(NBjkkCXZIG == DatpHJyIOW){QydwZVAcVA = true;}
          else if(DatpHJyIOW == NBjkkCXZIG){VMhoqWzoNJ = true;}
          if(caIfitjsLi == BDSQKmfVYp){gnARVbPVaj = true;}
          else if(BDSQKmfVYp == caIfitjsLi){XTQLbHPBLW = true;}
          if(sKtlBkIBwY == yddhORGnsu){tUrKfYJMYY = true;}
          else if(yddhORGnsu == sKtlBkIBwY){bPdXhzghqK = true;}
          if(DiumaNNfCg == ecPTPNMzzB){oYgMtWxzTW = true;}
          else if(ecPTPNMzzB == DiumaNNfCg){yWqzgMViLO = true;}
          if(EVIpGiwALn == NllUWDwesz){GAxFJcAFnV = true;}
          else if(NllUWDwesz == EVIpGiwALn){opcAaxNXqE = true;}
          if(NpnsuCGyjz == CWzxMYxMbp){mBrqDuFSPA = true;}
          if(tVcjCtfVFU == DKPTrXmyBw){LnDwKIGmWy = true;}
          if(gDqeeXBDfS == ZgVWbMqJLK){eQBDctXlBD = true;}
          while(CWzxMYxMbp == NpnsuCGyjz){CuoXYGhJHr = true;}
          while(DKPTrXmyBw == tVcjCtfVFU){oRxCKAbQdP = true;}
          while(ZgVWbMqJLK == gDqeeXBDfS){kgpwglmdxj = true;}
          if(UautsHcSGp == true){UautsHcSGp = false;}
          if(QAWJyDWSby == true){QAWJyDWSby = false;}
          if(QydwZVAcVA == true){QydwZVAcVA = false;}
          if(gnARVbPVaj == true){gnARVbPVaj = false;}
          if(tUrKfYJMYY == true){tUrKfYJMYY = false;}
          if(oYgMtWxzTW == true){oYgMtWxzTW = false;}
          if(GAxFJcAFnV == true){GAxFJcAFnV = false;}
          if(mBrqDuFSPA == true){mBrqDuFSPA = false;}
          if(LnDwKIGmWy == true){LnDwKIGmWy = false;}
          if(eQBDctXlBD == true){eQBDctXlBD = false;}
          if(YEXCknfpJy == true){YEXCknfpJy = false;}
          if(QeiTLSwAtB == true){QeiTLSwAtB = false;}
          if(VMhoqWzoNJ == true){VMhoqWzoNJ = false;}
          if(XTQLbHPBLW == true){XTQLbHPBLW = false;}
          if(bPdXhzghqK == true){bPdXhzghqK = false;}
          if(yWqzgMViLO == true){yWqzgMViLO = false;}
          if(opcAaxNXqE == true){opcAaxNXqE = false;}
          if(CuoXYGhJHr == true){CuoXYGhJHr = false;}
          if(oRxCKAbQdP == true){oRxCKAbQdP = false;}
          if(kgpwglmdxj == true){kgpwglmdxj = false;}
      } 
  }
} 

namespace BluCcyVkw
{
  class RVUHOWHJMJ
  { 
      void zzhpspoxfy()
      { 
          bool UFzUrEbpZi = false;
          bool pgInOflDtE = false;
          bool wJKlpnWPOP = false;
          bool VXKqXIMBeZ = false;
          bool MWVpqoZugU = false;
          bool iyKbVKuNeD = false;
          bool hMbKMSWRPF = false;
          bool TjXUrZmTuA = false;
          bool ObhsgXMiUM = false;
          bool NzWarzuKcX = false;
          bool SIeaByZpiw = false;
          bool XaRdoFdhdo = false;
          bool FnwDrUNwbs = false;
          bool dbpWhFwHqh = false;
          bool xVzYolgrll = false;
          bool VMgnSeMbhg = false;
          bool kdOpRukuwi = false;
          bool JWqwrinWNG = false;
          bool mUKpXRuCEC = false;
          bool sUYKxTHJHt = false;
          string zLrKheAhuN = null;
          string aobLmSGhuk = null;
          string LjQnMmBRsO = null;
          string FiiPThJlkS = null;
          string OMyizhCuEo = null;
          string tLqmUOtEyt = null;
          string diofIrFMqF = null;
          string IUxcWzkhnd = null;
          string kFNEUsqwuF = null;
          string mFnqofXRZH = null;
          string cpEyfZOOQU = null;
          string cMPUIYUjLO = null;
          string AJQlSDfFnp = null;
          string bTHfAuBOYu = null;
          string dcfZbZoThP = null;
          string KmGKGTYRfc = null;
          string sJaZsJFjTM = null;
          string XFLQkXcqJr = null;
          string NMWXenMwZg = null;
          string WiiuBUBFfS = null;
          if(zLrKheAhuN == cpEyfZOOQU){UFzUrEbpZi = true;}
          else if(cpEyfZOOQU == zLrKheAhuN){SIeaByZpiw = true;}
          if(aobLmSGhuk == cMPUIYUjLO){pgInOflDtE = true;}
          else if(cMPUIYUjLO == aobLmSGhuk){XaRdoFdhdo = true;}
          if(LjQnMmBRsO == AJQlSDfFnp){wJKlpnWPOP = true;}
          else if(AJQlSDfFnp == LjQnMmBRsO){FnwDrUNwbs = true;}
          if(FiiPThJlkS == bTHfAuBOYu){VXKqXIMBeZ = true;}
          else if(bTHfAuBOYu == FiiPThJlkS){dbpWhFwHqh = true;}
          if(OMyizhCuEo == dcfZbZoThP){MWVpqoZugU = true;}
          else if(dcfZbZoThP == OMyizhCuEo){xVzYolgrll = true;}
          if(tLqmUOtEyt == KmGKGTYRfc){iyKbVKuNeD = true;}
          else if(KmGKGTYRfc == tLqmUOtEyt){VMgnSeMbhg = true;}
          if(diofIrFMqF == sJaZsJFjTM){hMbKMSWRPF = true;}
          else if(sJaZsJFjTM == diofIrFMqF){kdOpRukuwi = true;}
          if(IUxcWzkhnd == XFLQkXcqJr){TjXUrZmTuA = true;}
          if(kFNEUsqwuF == NMWXenMwZg){ObhsgXMiUM = true;}
          if(mFnqofXRZH == WiiuBUBFfS){NzWarzuKcX = true;}
          while(XFLQkXcqJr == IUxcWzkhnd){JWqwrinWNG = true;}
          while(NMWXenMwZg == kFNEUsqwuF){mUKpXRuCEC = true;}
          while(WiiuBUBFfS == mFnqofXRZH){sUYKxTHJHt = true;}
          if(UFzUrEbpZi == true){UFzUrEbpZi = false;}
          if(pgInOflDtE == true){pgInOflDtE = false;}
          if(wJKlpnWPOP == true){wJKlpnWPOP = false;}
          if(VXKqXIMBeZ == true){VXKqXIMBeZ = false;}
          if(MWVpqoZugU == true){MWVpqoZugU = false;}
          if(iyKbVKuNeD == true){iyKbVKuNeD = false;}
          if(hMbKMSWRPF == true){hMbKMSWRPF = false;}
          if(TjXUrZmTuA == true){TjXUrZmTuA = false;}
          if(ObhsgXMiUM == true){ObhsgXMiUM = false;}
          if(NzWarzuKcX == true){NzWarzuKcX = false;}
          if(SIeaByZpiw == true){SIeaByZpiw = false;}
          if(XaRdoFdhdo == true){XaRdoFdhdo = false;}
          if(FnwDrUNwbs == true){FnwDrUNwbs = false;}
          if(dbpWhFwHqh == true){dbpWhFwHqh = false;}
          if(xVzYolgrll == true){xVzYolgrll = false;}
          if(VMgnSeMbhg == true){VMgnSeMbhg = false;}
          if(kdOpRukuwi == true){kdOpRukuwi = false;}
          if(JWqwrinWNG == true){JWqwrinWNG = false;}
          if(mUKpXRuCEC == true){mUKpXRuCEC = false;}
          if(sUYKxTHJHt == true){sUYKxTHJHt = false;}
      } 
  }
} 

namespace nGgAutXsV
{
  class VNDSNRANLG
  { 
      void jHBwoPqwoA()
      { 
          bool zgTVTIFJbg = false;
          bool QVKfurpBSG = false;
          bool jNOchsNwQT = false;
          bool hNcDuQWGET = false;
          bool whmDgAPdYz = false;
          bool CgFJAlSqna = false;
          bool tIsIzCrGkd = false;
          bool UixyJCZKuh = false;
          bool cjWRQAISCI = false;
          bool yfScYnneEd = false;
          bool HJrudTjHAy = false;
          bool LHuFyKkbqz = false;
          bool tYDbfoPTYU = false;
          bool NuFRZTqbmx = false;
          bool PBSExpjMeO = false;
          bool DMmFjhFPPn = false;
          bool DQhekPBdfd = false;
          bool SIntisGzeo = false;
          bool ECoKRAHAgq = false;
          bool NbMyszSmSh = false;
          string AQhdnrwULY = null;
          string ozpzXtPpod = null;
          string sAZusdZFDc = null;
          string UVXOzwBHYx = null;
          string fSlNpjJAXR = null;
          string enbBHApmkJ = null;
          string RpRiDSbaAb = null;
          string sIRqyZNMFJ = null;
          string TZglygsVHz = null;
          string FOVOfoBDKW = null;
          string IiAwXVVkDg = null;
          string ldhborIejW = null;
          string YFTBVelCLI = null;
          string YKChAkYkNb = null;
          string KISZMaftZm = null;
          string fWSmxDPyas = null;
          string jSZtIbbzaD = null;
          string SXQILQltnt = null;
          string yqcXbCrOkx = null;
          string VZKUrriXQk = null;
          if(AQhdnrwULY == IiAwXVVkDg){zgTVTIFJbg = true;}
          else if(IiAwXVVkDg == AQhdnrwULY){HJrudTjHAy = true;}
          if(ozpzXtPpod == ldhborIejW){QVKfurpBSG = true;}
          else if(ldhborIejW == ozpzXtPpod){LHuFyKkbqz = true;}
          if(sAZusdZFDc == YFTBVelCLI){jNOchsNwQT = true;}
          else if(YFTBVelCLI == sAZusdZFDc){tYDbfoPTYU = true;}
          if(UVXOzwBHYx == YKChAkYkNb){hNcDuQWGET = true;}
          else if(YKChAkYkNb == UVXOzwBHYx){NuFRZTqbmx = true;}
          if(fSlNpjJAXR == KISZMaftZm){whmDgAPdYz = true;}
          else if(KISZMaftZm == fSlNpjJAXR){PBSExpjMeO = true;}
          if(enbBHApmkJ == fWSmxDPyas){CgFJAlSqna = true;}
          else if(fWSmxDPyas == enbBHApmkJ){DMmFjhFPPn = true;}
          if(RpRiDSbaAb == jSZtIbbzaD){tIsIzCrGkd = true;}
          else if(jSZtIbbzaD == RpRiDSbaAb){DQhekPBdfd = true;}
          if(sIRqyZNMFJ == SXQILQltnt){UixyJCZKuh = true;}
          if(TZglygsVHz == yqcXbCrOkx){cjWRQAISCI = true;}
          if(FOVOfoBDKW == VZKUrriXQk){yfScYnneEd = true;}
          while(SXQILQltnt == sIRqyZNMFJ){SIntisGzeo = true;}
          while(yqcXbCrOkx == TZglygsVHz){ECoKRAHAgq = true;}
          while(VZKUrriXQk == FOVOfoBDKW){NbMyszSmSh = true;}
          if(zgTVTIFJbg == true){zgTVTIFJbg = false;}
          if(QVKfurpBSG == true){QVKfurpBSG = false;}
          if(jNOchsNwQT == true){jNOchsNwQT = false;}
          if(hNcDuQWGET == true){hNcDuQWGET = false;}
          if(whmDgAPdYz == true){whmDgAPdYz = false;}
          if(CgFJAlSqna == true){CgFJAlSqna = false;}
          if(tIsIzCrGkd == true){tIsIzCrGkd = false;}
          if(UixyJCZKuh == true){UixyJCZKuh = false;}
          if(cjWRQAISCI == true){cjWRQAISCI = false;}
          if(yfScYnneEd == true){yfScYnneEd = false;}
          if(HJrudTjHAy == true){HJrudTjHAy = false;}
          if(LHuFyKkbqz == true){LHuFyKkbqz = false;}
          if(tYDbfoPTYU == true){tYDbfoPTYU = false;}
          if(NuFRZTqbmx == true){NuFRZTqbmx = false;}
          if(PBSExpjMeO == true){PBSExpjMeO = false;}
          if(DMmFjhFPPn == true){DMmFjhFPPn = false;}
          if(DQhekPBdfd == true){DQhekPBdfd = false;}
          if(SIntisGzeo == true){SIntisGzeo = false;}
          if(ECoKRAHAgq == true){ECoKRAHAgq = false;}
          if(NbMyszSmSh == true){NbMyszSmSh = false;}
      } 
  }
} 

namespace JETSXNJyy
{
  class JGDFSLGATN
  { 
      void AGXLBBsmRK()
      { 
          bool xBRHxQopek = false;
          bool wxWxTWylAt = false;
          bool Tdwxcwmtmx = false;
          bool fzUOoxjmKh = false;
          bool oHMDcxWXlj = false;
          bool RbuqYSFTdA = false;
          bool dtDhFxcIIW = false;
          bool lKaREMQrTe = false;
          bool ZOIDeDDcpV = false;
          bool rQIKDtEeyf = false;
          bool UOPPxGAclM = false;
          bool BNzzaPlACB = false;
          bool szSldVBQOJ = false;
          bool IlsmJKzrFX = false;
          bool DZqcUdQJin = false;
          bool IEcwmVwckb = false;
          bool FiObEPULoQ = false;
          bool PttdyTIoRA = false;
          bool ErhaBDJwAn = false;
          bool OWGcSTLOYF = false;
          string AZwYrWVbsV = null;
          string xIGSSfgOnC = null;
          string ONQnmFmPSb = null;
          string VsAltkBNnm = null;
          string qaYPlonTVl = null;
          string hsrhglJIkm = null;
          string iFIRzDIUYg = null;
          string eSaAKmnBCx = null;
          string QTsgsbASEH = null;
          string brbBDlRHPh = null;
          string gSuoGOSrXt = null;
          string yHFnVPMbXW = null;
          string CpPQFlpZxX = null;
          string UgkUQyXEae = null;
          string JIuKJTmnen = null;
          string YpiseqDdiT = null;
          string XstzYQWkWX = null;
          string qHBsNsuFHl = null;
          string zBtIzexroZ = null;
          string utUGGPNukr = null;
          if(AZwYrWVbsV == gSuoGOSrXt){xBRHxQopek = true;}
          else if(gSuoGOSrXt == AZwYrWVbsV){UOPPxGAclM = true;}
          if(xIGSSfgOnC == yHFnVPMbXW){wxWxTWylAt = true;}
          else if(yHFnVPMbXW == xIGSSfgOnC){BNzzaPlACB = true;}
          if(ONQnmFmPSb == CpPQFlpZxX){Tdwxcwmtmx = true;}
          else if(CpPQFlpZxX == ONQnmFmPSb){szSldVBQOJ = true;}
          if(VsAltkBNnm == UgkUQyXEae){fzUOoxjmKh = true;}
          else if(UgkUQyXEae == VsAltkBNnm){IlsmJKzrFX = true;}
          if(qaYPlonTVl == JIuKJTmnen){oHMDcxWXlj = true;}
          else if(JIuKJTmnen == qaYPlonTVl){DZqcUdQJin = true;}
          if(hsrhglJIkm == YpiseqDdiT){RbuqYSFTdA = true;}
          else if(YpiseqDdiT == hsrhglJIkm){IEcwmVwckb = true;}
          if(iFIRzDIUYg == XstzYQWkWX){dtDhFxcIIW = true;}
          else if(XstzYQWkWX == iFIRzDIUYg){FiObEPULoQ = true;}
          if(eSaAKmnBCx == qHBsNsuFHl){lKaREMQrTe = true;}
          if(QTsgsbASEH == zBtIzexroZ){ZOIDeDDcpV = true;}
          if(brbBDlRHPh == utUGGPNukr){rQIKDtEeyf = true;}
          while(qHBsNsuFHl == eSaAKmnBCx){PttdyTIoRA = true;}
          while(zBtIzexroZ == QTsgsbASEH){ErhaBDJwAn = true;}
          while(utUGGPNukr == brbBDlRHPh){OWGcSTLOYF = true;}
          if(xBRHxQopek == true){xBRHxQopek = false;}
          if(wxWxTWylAt == true){wxWxTWylAt = false;}
          if(Tdwxcwmtmx == true){Tdwxcwmtmx = false;}
          if(fzUOoxjmKh == true){fzUOoxjmKh = false;}
          if(oHMDcxWXlj == true){oHMDcxWXlj = false;}
          if(RbuqYSFTdA == true){RbuqYSFTdA = false;}
          if(dtDhFxcIIW == true){dtDhFxcIIW = false;}
          if(lKaREMQrTe == true){lKaREMQrTe = false;}
          if(ZOIDeDDcpV == true){ZOIDeDDcpV = false;}
          if(rQIKDtEeyf == true){rQIKDtEeyf = false;}
          if(UOPPxGAclM == true){UOPPxGAclM = false;}
          if(BNzzaPlACB == true){BNzzaPlACB = false;}
          if(szSldVBQOJ == true){szSldVBQOJ = false;}
          if(IlsmJKzrFX == true){IlsmJKzrFX = false;}
          if(DZqcUdQJin == true){DZqcUdQJin = false;}
          if(IEcwmVwckb == true){IEcwmVwckb = false;}
          if(FiObEPULoQ == true){FiObEPULoQ = false;}
          if(PttdyTIoRA == true){PttdyTIoRA = false;}
          if(ErhaBDJwAn == true){ErhaBDJwAn = false;}
          if(OWGcSTLOYF == true){OWGcSTLOYF = false;}
      } 
  }
} 

namespace MpGPYGocl
{
  class YYYOVZXBGM
  { 
      void sMPWLjIYNg()
      { 
          bool JhBsbrMIKu = false;
          bool tbbkohQxzB = false;
          bool oVARqVbNSY = false;
          bool hzwmOJwlwq = false;
          bool WcTEmVEGjb = false;
          bool ITCNQngiBF = false;
          bool PyplNufoWe = false;
          bool keBIeMBweV = false;
          bool QVdqPNwiWZ = false;
          bool bMkqaXmhpq = false;
          bool oPiEpdStiE = false;
          bool mkEentUzVz = false;
          bool ywSwCYsJgG = false;
          bool YTFmfBlYBl = false;
          bool tCARmqHFCg = false;
          bool DmLqssxmBQ = false;
          bool jJMbeTeQym = false;
          bool HwyiEuwAJL = false;
          bool QnGADlHOtm = false;
          bool DzWjCkpXlS = false;
          string mmzjiUhtIF = null;
          string dXtShUsxhZ = null;
          string dNkUuTLSjY = null;
          string KaWNHALRYs = null;
          string wCmWnjgJYS = null;
          string FgNHtZCdnO = null;
          string IOKjuCBfKg = null;
          string IbXncaZOgL = null;
          string mCsQScNOTh = null;
          string ygcKkgrCak = null;
          string hAyrJdIYdT = null;
          string znxcbGUsRR = null;
          string olMcibyNCu = null;
          string hXmwclDBGo = null;
          string UnkAhKiAhd = null;
          string LykIwwnVJh = null;
          string euVikbABzo = null;
          string CTlbxABLtX = null;
          string rxeXiileAg = null;
          string ygqYJYRBPG = null;
          if(mmzjiUhtIF == hAyrJdIYdT){JhBsbrMIKu = true;}
          else if(hAyrJdIYdT == mmzjiUhtIF){oPiEpdStiE = true;}
          if(dXtShUsxhZ == znxcbGUsRR){tbbkohQxzB = true;}
          else if(znxcbGUsRR == dXtShUsxhZ){mkEentUzVz = true;}
          if(dNkUuTLSjY == olMcibyNCu){oVARqVbNSY = true;}
          else if(olMcibyNCu == dNkUuTLSjY){ywSwCYsJgG = true;}
          if(KaWNHALRYs == hXmwclDBGo){hzwmOJwlwq = true;}
          else if(hXmwclDBGo == KaWNHALRYs){YTFmfBlYBl = true;}
          if(wCmWnjgJYS == UnkAhKiAhd){WcTEmVEGjb = true;}
          else if(UnkAhKiAhd == wCmWnjgJYS){tCARmqHFCg = true;}
          if(FgNHtZCdnO == LykIwwnVJh){ITCNQngiBF = true;}
          else if(LykIwwnVJh == FgNHtZCdnO){DmLqssxmBQ = true;}
          if(IOKjuCBfKg == euVikbABzo){PyplNufoWe = true;}
          else if(euVikbABzo == IOKjuCBfKg){jJMbeTeQym = true;}
          if(IbXncaZOgL == CTlbxABLtX){keBIeMBweV = true;}
          if(mCsQScNOTh == rxeXiileAg){QVdqPNwiWZ = true;}
          if(ygcKkgrCak == ygqYJYRBPG){bMkqaXmhpq = true;}
          while(CTlbxABLtX == IbXncaZOgL){HwyiEuwAJL = true;}
          while(rxeXiileAg == mCsQScNOTh){QnGADlHOtm = true;}
          while(ygqYJYRBPG == ygcKkgrCak){DzWjCkpXlS = true;}
          if(JhBsbrMIKu == true){JhBsbrMIKu = false;}
          if(tbbkohQxzB == true){tbbkohQxzB = false;}
          if(oVARqVbNSY == true){oVARqVbNSY = false;}
          if(hzwmOJwlwq == true){hzwmOJwlwq = false;}
          if(WcTEmVEGjb == true){WcTEmVEGjb = false;}
          if(ITCNQngiBF == true){ITCNQngiBF = false;}
          if(PyplNufoWe == true){PyplNufoWe = false;}
          if(keBIeMBweV == true){keBIeMBweV = false;}
          if(QVdqPNwiWZ == true){QVdqPNwiWZ = false;}
          if(bMkqaXmhpq == true){bMkqaXmhpq = false;}
          if(oPiEpdStiE == true){oPiEpdStiE = false;}
          if(mkEentUzVz == true){mkEentUzVz = false;}
          if(ywSwCYsJgG == true){ywSwCYsJgG = false;}
          if(YTFmfBlYBl == true){YTFmfBlYBl = false;}
          if(tCARmqHFCg == true){tCARmqHFCg = false;}
          if(DmLqssxmBQ == true){DmLqssxmBQ = false;}
          if(jJMbeTeQym == true){jJMbeTeQym = false;}
          if(HwyiEuwAJL == true){HwyiEuwAJL = false;}
          if(QnGADlHOtm == true){QnGADlHOtm = false;}
          if(DzWjCkpXlS == true){DzWjCkpXlS = false;}
      } 
  }
} 

namespace WUrxPCgoj
{
  class NRVLTEXJRZ
  { 
      void mBtJtwZyPY()
      { 
          bool wzTniDIUsu = false;
          bool ysZzYCirWp = false;
          bool xaUWYGauwT = false;
          bool jyFduAdqBs = false;
          bool pUPQUQWUQg = false;
          bool zLquoUdxPb = false;
          bool bMYZKAnuEX = false;
          bool YrpdAbLEBI = false;
          bool jGeOTXGKoZ = false;
          bool WfaYQdwoFU = false;
          bool baPrIHUNtM = false;
          bool JYwHrVgKFl = false;
          bool sdFeBrQRMW = false;
          bool fVzgfIpmFL = false;
          bool DsPbQxjTgu = false;
          bool wljSayUkqQ = false;
          bool qDAXgmZPbi = false;
          bool etEtiAOcOD = false;
          bool HwjRZtlfFg = false;
          bool mEwnUzsquc = false;
          string mOatKINYOK = null;
          string hMFpJPenqq = null;
          string wwUClfwgHy = null;
          string qgScuPeogp = null;
          string mKjQEAfbHo = null;
          string BZATTqsYHd = null;
          string LgRPSBtcts = null;
          string kpGADkLDxl = null;
          string zUYRxRfyJE = null;
          string VGgCdGsUyD = null;
          string GDgNDKSzQh = null;
          string epaVeqHzSB = null;
          string UuSpXeJDWw = null;
          string rqFteumLNl = null;
          string yghaYfeKXl = null;
          string zsBwiLkqpY = null;
          string BOcTomjfpi = null;
          string DwkgCnMqQq = null;
          string zyfjwypILT = null;
          string KwUojiDOll = null;
          if(mOatKINYOK == GDgNDKSzQh){wzTniDIUsu = true;}
          else if(GDgNDKSzQh == mOatKINYOK){baPrIHUNtM = true;}
          if(hMFpJPenqq == epaVeqHzSB){ysZzYCirWp = true;}
          else if(epaVeqHzSB == hMFpJPenqq){JYwHrVgKFl = true;}
          if(wwUClfwgHy == UuSpXeJDWw){xaUWYGauwT = true;}
          else if(UuSpXeJDWw == wwUClfwgHy){sdFeBrQRMW = true;}
          if(qgScuPeogp == rqFteumLNl){jyFduAdqBs = true;}
          else if(rqFteumLNl == qgScuPeogp){fVzgfIpmFL = true;}
          if(mKjQEAfbHo == yghaYfeKXl){pUPQUQWUQg = true;}
          else if(yghaYfeKXl == mKjQEAfbHo){DsPbQxjTgu = true;}
          if(BZATTqsYHd == zsBwiLkqpY){zLquoUdxPb = true;}
          else if(zsBwiLkqpY == BZATTqsYHd){wljSayUkqQ = true;}
          if(LgRPSBtcts == BOcTomjfpi){bMYZKAnuEX = true;}
          else if(BOcTomjfpi == LgRPSBtcts){qDAXgmZPbi = true;}
          if(kpGADkLDxl == DwkgCnMqQq){YrpdAbLEBI = true;}
          if(zUYRxRfyJE == zyfjwypILT){jGeOTXGKoZ = true;}
          if(VGgCdGsUyD == KwUojiDOll){WfaYQdwoFU = true;}
          while(DwkgCnMqQq == kpGADkLDxl){etEtiAOcOD = true;}
          while(zyfjwypILT == zUYRxRfyJE){HwjRZtlfFg = true;}
          while(KwUojiDOll == VGgCdGsUyD){mEwnUzsquc = true;}
          if(wzTniDIUsu == true){wzTniDIUsu = false;}
          if(ysZzYCirWp == true){ysZzYCirWp = false;}
          if(xaUWYGauwT == true){xaUWYGauwT = false;}
          if(jyFduAdqBs == true){jyFduAdqBs = false;}
          if(pUPQUQWUQg == true){pUPQUQWUQg = false;}
          if(zLquoUdxPb == true){zLquoUdxPb = false;}
          if(bMYZKAnuEX == true){bMYZKAnuEX = false;}
          if(YrpdAbLEBI == true){YrpdAbLEBI = false;}
          if(jGeOTXGKoZ == true){jGeOTXGKoZ = false;}
          if(WfaYQdwoFU == true){WfaYQdwoFU = false;}
          if(baPrIHUNtM == true){baPrIHUNtM = false;}
          if(JYwHrVgKFl == true){JYwHrVgKFl = false;}
          if(sdFeBrQRMW == true){sdFeBrQRMW = false;}
          if(fVzgfIpmFL == true){fVzgfIpmFL = false;}
          if(DsPbQxjTgu == true){DsPbQxjTgu = false;}
          if(wljSayUkqQ == true){wljSayUkqQ = false;}
          if(qDAXgmZPbi == true){qDAXgmZPbi = false;}
          if(etEtiAOcOD == true){etEtiAOcOD = false;}
          if(HwjRZtlfFg == true){HwjRZtlfFg = false;}
          if(mEwnUzsquc == true){mEwnUzsquc = false;}
      } 
  }
} 

namespace NzJctmtbG
{
  class GOWPWEYICU
  { 
      void rpqwZDenmK()
      { 
          bool RWkYjrAMIN = false;
          bool osrflwKKKE = false;
          bool jQTrUjVNXl = false;
          bool WNJyslJbTK = false;
          bool MolEIZjnai = false;
          bool jhbqZBCsEz = false;
          bool VlnWqaismz = false;
          bool mhqAqtdPit = false;
          bool zhmoColSYq = false;
          bool jPXTnZAPMg = false;
          bool ppAbwBqbze = false;
          bool XlJJAnzzTC = false;
          bool oQUuPWJWLR = false;
          bool sOCCEJgLrA = false;
          bool xJTsTxGOTA = false;
          bool ZBuKqZUFLY = false;
          bool qUPgkJiGEq = false;
          bool GmGTEewaaR = false;
          bool QuDKqrSrKe = false;
          bool nbzTIcsmIK = false;
          string kIYQQLbFjF = null;
          string NLHWplemsw = null;
          string RTCqNeoizW = null;
          string nUOXSdZGFH = null;
          string bRGrslyHrb = null;
          string lIzRFRFgDl = null;
          string VrGNRrxiEM = null;
          string MYhkTzMKxa = null;
          string fgqXkfUxSA = null;
          string XsCSkiKsaB = null;
          string oODfONZNxG = null;
          string FuibFoBibl = null;
          string WzQDnTVOzj = null;
          string oSjwlRcLIX = null;
          string FHzMucJaNw = null;
          string hbQodoyAqu = null;
          string qLOMQlLlon = null;
          string MpaEfPAEHK = null;
          string JtBDCMCuSx = null;
          string TcTMftrluJ = null;
          if(kIYQQLbFjF == oODfONZNxG){RWkYjrAMIN = true;}
          else if(oODfONZNxG == kIYQQLbFjF){ppAbwBqbze = true;}
          if(NLHWplemsw == FuibFoBibl){osrflwKKKE = true;}
          else if(FuibFoBibl == NLHWplemsw){XlJJAnzzTC = true;}
          if(RTCqNeoizW == WzQDnTVOzj){jQTrUjVNXl = true;}
          else if(WzQDnTVOzj == RTCqNeoizW){oQUuPWJWLR = true;}
          if(nUOXSdZGFH == oSjwlRcLIX){WNJyslJbTK = true;}
          else if(oSjwlRcLIX == nUOXSdZGFH){sOCCEJgLrA = true;}
          if(bRGrslyHrb == FHzMucJaNw){MolEIZjnai = true;}
          else if(FHzMucJaNw == bRGrslyHrb){xJTsTxGOTA = true;}
          if(lIzRFRFgDl == hbQodoyAqu){jhbqZBCsEz = true;}
          else if(hbQodoyAqu == lIzRFRFgDl){ZBuKqZUFLY = true;}
          if(VrGNRrxiEM == qLOMQlLlon){VlnWqaismz = true;}
          else if(qLOMQlLlon == VrGNRrxiEM){qUPgkJiGEq = true;}
          if(MYhkTzMKxa == MpaEfPAEHK){mhqAqtdPit = true;}
          if(fgqXkfUxSA == JtBDCMCuSx){zhmoColSYq = true;}
          if(XsCSkiKsaB == TcTMftrluJ){jPXTnZAPMg = true;}
          while(MpaEfPAEHK == MYhkTzMKxa){GmGTEewaaR = true;}
          while(JtBDCMCuSx == fgqXkfUxSA){QuDKqrSrKe = true;}
          while(TcTMftrluJ == XsCSkiKsaB){nbzTIcsmIK = true;}
          if(RWkYjrAMIN == true){RWkYjrAMIN = false;}
          if(osrflwKKKE == true){osrflwKKKE = false;}
          if(jQTrUjVNXl == true){jQTrUjVNXl = false;}
          if(WNJyslJbTK == true){WNJyslJbTK = false;}
          if(MolEIZjnai == true){MolEIZjnai = false;}
          if(jhbqZBCsEz == true){jhbqZBCsEz = false;}
          if(VlnWqaismz == true){VlnWqaismz = false;}
          if(mhqAqtdPit == true){mhqAqtdPit = false;}
          if(zhmoColSYq == true){zhmoColSYq = false;}
          if(jPXTnZAPMg == true){jPXTnZAPMg = false;}
          if(ppAbwBqbze == true){ppAbwBqbze = false;}
          if(XlJJAnzzTC == true){XlJJAnzzTC = false;}
          if(oQUuPWJWLR == true){oQUuPWJWLR = false;}
          if(sOCCEJgLrA == true){sOCCEJgLrA = false;}
          if(xJTsTxGOTA == true){xJTsTxGOTA = false;}
          if(ZBuKqZUFLY == true){ZBuKqZUFLY = false;}
          if(qUPgkJiGEq == true){qUPgkJiGEq = false;}
          if(GmGTEewaaR == true){GmGTEewaaR = false;}
          if(QuDKqrSrKe == true){QuDKqrSrKe = false;}
          if(nbzTIcsmIK == true){nbzTIcsmIK = false;}
      } 
  }
} 

namespace YzXMjVyZb
{
  class TYMBIZMXTZ
  { 
      void zyqhGOwQTE()
      { 
          bool fwqulCFjaA = false;
          bool PrOFLzByRg = false;
          bool nafByiBwXT = false;
          bool ncTeSdWzHV = false;
          bool UXcdLORfji = false;
          bool krxElFPowD = false;
          bool BJLHMmXilh = false;
          bool cCpwMQyCpj = false;
          bool QVLniuePrN = false;
          bool NgCETKLVRY = false;
          bool pisCGhCBqV = false;
          bool GMzMlfyXXQ = false;
          bool HIpYTuzlbB = false;
          bool FckQshbIgA = false;
          bool scXWGAhpRn = false;
          bool LnxAQhrUiL = false;
          bool hPZpQdbhSE = false;
          bool DppWXejTSS = false;
          bool NJUmpQekAL = false;
          bool oHYVScDhGb = false;
          string RfTJeMlyys = null;
          string azcCtJFZCX = null;
          string teCsFUuHZE = null;
          string aiqEFGBnTk = null;
          string uxlqmOUuDZ = null;
          string NyHgdmcZEJ = null;
          string ReYsSqIYwn = null;
          string HRGQcwrLFp = null;
          string AADzqbaJZS = null;
          string caiKTPXsYu = null;
          string GwyORurpDg = null;
          string uRUNJRaZCp = null;
          string PyydKgiuxN = null;
          string YylJjDBogu = null;
          string ikFsWLGUAC = null;
          string oyqhfIxUEk = null;
          string MwspHweKdF = null;
          string PlrGGerFGz = null;
          string ZNttYaHEdb = null;
          string GgkwimqPka = null;
          if(RfTJeMlyys == GwyORurpDg){fwqulCFjaA = true;}
          else if(GwyORurpDg == RfTJeMlyys){pisCGhCBqV = true;}
          if(azcCtJFZCX == uRUNJRaZCp){PrOFLzByRg = true;}
          else if(uRUNJRaZCp == azcCtJFZCX){GMzMlfyXXQ = true;}
          if(teCsFUuHZE == PyydKgiuxN){nafByiBwXT = true;}
          else if(PyydKgiuxN == teCsFUuHZE){HIpYTuzlbB = true;}
          if(aiqEFGBnTk == YylJjDBogu){ncTeSdWzHV = true;}
          else if(YylJjDBogu == aiqEFGBnTk){FckQshbIgA = true;}
          if(uxlqmOUuDZ == ikFsWLGUAC){UXcdLORfji = true;}
          else if(ikFsWLGUAC == uxlqmOUuDZ){scXWGAhpRn = true;}
          if(NyHgdmcZEJ == oyqhfIxUEk){krxElFPowD = true;}
          else if(oyqhfIxUEk == NyHgdmcZEJ){LnxAQhrUiL = true;}
          if(ReYsSqIYwn == MwspHweKdF){BJLHMmXilh = true;}
          else if(MwspHweKdF == ReYsSqIYwn){hPZpQdbhSE = true;}
          if(HRGQcwrLFp == PlrGGerFGz){cCpwMQyCpj = true;}
          if(AADzqbaJZS == ZNttYaHEdb){QVLniuePrN = true;}
          if(caiKTPXsYu == GgkwimqPka){NgCETKLVRY = true;}
          while(PlrGGerFGz == HRGQcwrLFp){DppWXejTSS = true;}
          while(ZNttYaHEdb == AADzqbaJZS){NJUmpQekAL = true;}
          while(GgkwimqPka == caiKTPXsYu){oHYVScDhGb = true;}
          if(fwqulCFjaA == true){fwqulCFjaA = false;}
          if(PrOFLzByRg == true){PrOFLzByRg = false;}
          if(nafByiBwXT == true){nafByiBwXT = false;}
          if(ncTeSdWzHV == true){ncTeSdWzHV = false;}
          if(UXcdLORfji == true){UXcdLORfji = false;}
          if(krxElFPowD == true){krxElFPowD = false;}
          if(BJLHMmXilh == true){BJLHMmXilh = false;}
          if(cCpwMQyCpj == true){cCpwMQyCpj = false;}
          if(QVLniuePrN == true){QVLniuePrN = false;}
          if(NgCETKLVRY == true){NgCETKLVRY = false;}
          if(pisCGhCBqV == true){pisCGhCBqV = false;}
          if(GMzMlfyXXQ == true){GMzMlfyXXQ = false;}
          if(HIpYTuzlbB == true){HIpYTuzlbB = false;}
          if(FckQshbIgA == true){FckQshbIgA = false;}
          if(scXWGAhpRn == true){scXWGAhpRn = false;}
          if(LnxAQhrUiL == true){LnxAQhrUiL = false;}
          if(hPZpQdbhSE == true){hPZpQdbhSE = false;}
          if(DppWXejTSS == true){DppWXejTSS = false;}
          if(NJUmpQekAL == true){NJUmpQekAL = false;}
          if(oHYVScDhGb == true){oHYVScDhGb = false;}
      } 
  }
} 

namespace KcxkGdGUa
{
  class KEEHVQRFPI
  { 
      void HHTrTohjZo()
      { 
          bool TJXLDharCA = false;
          bool YdgbIoZEow = false;
          bool UscpResMZg = false;
          bool KUrEyZbWXZ = false;
          bool xPQLUtwbZy = false;
          bool itpmSZggtX = false;
          bool nNSUpElbdh = false;
          bool NDgOyEcRVW = false;
          bool iQmayQeEkX = false;
          bool stbzkixuVQ = false;
          bool ITyqjfManO = false;
          bool xOLWoXaqWY = false;
          bool YgqFoTagdP = false;
          bool GgwFOORwqS = false;
          bool DDPWadiFKM = false;
          bool IGYwqacsBQ = false;
          bool EfwYHQSGHZ = false;
          bool GezDVURTeK = false;
          bool jVVQHAIzNn = false;
          bool kXtZNWGpPJ = false;
          string fNdVgqgFQS = null;
          string MuYcuhzCoi = null;
          string McbzBApqbw = null;
          string DcKYKqneAa = null;
          string TXRPgjlCxW = null;
          string StgzFCkdTg = null;
          string BpcUPjkASE = null;
          string tTCNPoLMSQ = null;
          string OnsFcIwKTI = null;
          string FKLSZctxAx = null;
          string zkjscyqSiP = null;
          string qYKCRNxXqH = null;
          string mafJyiIimm = null;
          string uNMVRcDzbd = null;
          string QdaEQfzIAM = null;
          string eWFsJXFZts = null;
          string pIewUcMojo = null;
          string JxuNpJzbrS = null;
          string jAhaHXITLs = null;
          string XdEinIyejn = null;
          if(fNdVgqgFQS == zkjscyqSiP){TJXLDharCA = true;}
          else if(zkjscyqSiP == fNdVgqgFQS){ITyqjfManO = true;}
          if(MuYcuhzCoi == qYKCRNxXqH){YdgbIoZEow = true;}
          else if(qYKCRNxXqH == MuYcuhzCoi){xOLWoXaqWY = true;}
          if(McbzBApqbw == mafJyiIimm){UscpResMZg = true;}
          else if(mafJyiIimm == McbzBApqbw){YgqFoTagdP = true;}
          if(DcKYKqneAa == uNMVRcDzbd){KUrEyZbWXZ = true;}
          else if(uNMVRcDzbd == DcKYKqneAa){GgwFOORwqS = true;}
          if(TXRPgjlCxW == QdaEQfzIAM){xPQLUtwbZy = true;}
          else if(QdaEQfzIAM == TXRPgjlCxW){DDPWadiFKM = true;}
          if(StgzFCkdTg == eWFsJXFZts){itpmSZggtX = true;}
          else if(eWFsJXFZts == StgzFCkdTg){IGYwqacsBQ = true;}
          if(BpcUPjkASE == pIewUcMojo){nNSUpElbdh = true;}
          else if(pIewUcMojo == BpcUPjkASE){EfwYHQSGHZ = true;}
          if(tTCNPoLMSQ == JxuNpJzbrS){NDgOyEcRVW = true;}
          if(OnsFcIwKTI == jAhaHXITLs){iQmayQeEkX = true;}
          if(FKLSZctxAx == XdEinIyejn){stbzkixuVQ = true;}
          while(JxuNpJzbrS == tTCNPoLMSQ){GezDVURTeK = true;}
          while(jAhaHXITLs == OnsFcIwKTI){jVVQHAIzNn = true;}
          while(XdEinIyejn == FKLSZctxAx){kXtZNWGpPJ = true;}
          if(TJXLDharCA == true){TJXLDharCA = false;}
          if(YdgbIoZEow == true){YdgbIoZEow = false;}
          if(UscpResMZg == true){UscpResMZg = false;}
          if(KUrEyZbWXZ == true){KUrEyZbWXZ = false;}
          if(xPQLUtwbZy == true){xPQLUtwbZy = false;}
          if(itpmSZggtX == true){itpmSZggtX = false;}
          if(nNSUpElbdh == true){nNSUpElbdh = false;}
          if(NDgOyEcRVW == true){NDgOyEcRVW = false;}
          if(iQmayQeEkX == true){iQmayQeEkX = false;}
          if(stbzkixuVQ == true){stbzkixuVQ = false;}
          if(ITyqjfManO == true){ITyqjfManO = false;}
          if(xOLWoXaqWY == true){xOLWoXaqWY = false;}
          if(YgqFoTagdP == true){YgqFoTagdP = false;}
          if(GgwFOORwqS == true){GgwFOORwqS = false;}
          if(DDPWadiFKM == true){DDPWadiFKM = false;}
          if(IGYwqacsBQ == true){IGYwqacsBQ = false;}
          if(EfwYHQSGHZ == true){EfwYHQSGHZ = false;}
          if(GezDVURTeK == true){GezDVURTeK = false;}
          if(jVVQHAIzNn == true){jVVQHAIzNn = false;}
          if(kXtZNWGpPJ == true){kXtZNWGpPJ = false;}
      } 
  }
} 

namespace ETJMVbuwP
{
  class GWKSEYJNQL
  { 
      void RMcrGNlHdL()
      { 
          bool sNNeraKViY = false;
          bool kHUTPMznnJ = false;
          bool LELpwKPDEb = false;
          bool txtprtjkRx = false;
          bool hCONPGeDql = false;
          bool xpsVmoBWig = false;
          bool KHRGemNeaU = false;
          bool bNWpbJpyao = false;
          bool fLMSdDEXCD = false;
          bool sNBjlajHhb = false;
          bool sAbVJjSCsd = false;
          bool zCwtBztycb = false;
          bool iobXbOLmDB = false;
          bool YhQyufipIt = false;
          bool jBeYEpQHhm = false;
          bool fkeGsDXEtu = false;
          bool XfyrFQlxyV = false;
          bool QDphqgKCSk = false;
          bool xEEQVmDJEq = false;
          bool HewMWEClTn = false;
          string XYyYiXVxgi = null;
          string gYBUujpyad = null;
          string AFQcLmKniy = null;
          string MpHrhLSasm = null;
          string MZUQqFATXK = null;
          string cbAPrSHVNu = null;
          string MhOhVqQJmj = null;
          string RPFnQZjAkF = null;
          string mqQXVjorAP = null;
          string DwMxZeLltA = null;
          string nqgmsMWMyR = null;
          string hHjIHVQpMl = null;
          string BYIWgUCHNl = null;
          string OyFkQwKdeI = null;
          string McsihuMEpE = null;
          string NVZIyPhJFX = null;
          string KPyMCiBzqK = null;
          string LmKDYYeZnl = null;
          string IxQJXsXxmA = null;
          string OAXGyxegfy = null;
          if(XYyYiXVxgi == nqgmsMWMyR){sNNeraKViY = true;}
          else if(nqgmsMWMyR == XYyYiXVxgi){sAbVJjSCsd = true;}
          if(gYBUujpyad == hHjIHVQpMl){kHUTPMznnJ = true;}
          else if(hHjIHVQpMl == gYBUujpyad){zCwtBztycb = true;}
          if(AFQcLmKniy == BYIWgUCHNl){LELpwKPDEb = true;}
          else if(BYIWgUCHNl == AFQcLmKniy){iobXbOLmDB = true;}
          if(MpHrhLSasm == OyFkQwKdeI){txtprtjkRx = true;}
          else if(OyFkQwKdeI == MpHrhLSasm){YhQyufipIt = true;}
          if(MZUQqFATXK == McsihuMEpE){hCONPGeDql = true;}
          else if(McsihuMEpE == MZUQqFATXK){jBeYEpQHhm = true;}
          if(cbAPrSHVNu == NVZIyPhJFX){xpsVmoBWig = true;}
          else if(NVZIyPhJFX == cbAPrSHVNu){fkeGsDXEtu = true;}
          if(MhOhVqQJmj == KPyMCiBzqK){KHRGemNeaU = true;}
          else if(KPyMCiBzqK == MhOhVqQJmj){XfyrFQlxyV = true;}
          if(RPFnQZjAkF == LmKDYYeZnl){bNWpbJpyao = true;}
          if(mqQXVjorAP == IxQJXsXxmA){fLMSdDEXCD = true;}
          if(DwMxZeLltA == OAXGyxegfy){sNBjlajHhb = true;}
          while(LmKDYYeZnl == RPFnQZjAkF){QDphqgKCSk = true;}
          while(IxQJXsXxmA == mqQXVjorAP){xEEQVmDJEq = true;}
          while(OAXGyxegfy == DwMxZeLltA){HewMWEClTn = true;}
          if(sNNeraKViY == true){sNNeraKViY = false;}
          if(kHUTPMznnJ == true){kHUTPMznnJ = false;}
          if(LELpwKPDEb == true){LELpwKPDEb = false;}
          if(txtprtjkRx == true){txtprtjkRx = false;}
          if(hCONPGeDql == true){hCONPGeDql = false;}
          if(xpsVmoBWig == true){xpsVmoBWig = false;}
          if(KHRGemNeaU == true){KHRGemNeaU = false;}
          if(bNWpbJpyao == true){bNWpbJpyao = false;}
          if(fLMSdDEXCD == true){fLMSdDEXCD = false;}
          if(sNBjlajHhb == true){sNBjlajHhb = false;}
          if(sAbVJjSCsd == true){sAbVJjSCsd = false;}
          if(zCwtBztycb == true){zCwtBztycb = false;}
          if(iobXbOLmDB == true){iobXbOLmDB = false;}
          if(YhQyufipIt == true){YhQyufipIt = false;}
          if(jBeYEpQHhm == true){jBeYEpQHhm = false;}
          if(fkeGsDXEtu == true){fkeGsDXEtu = false;}
          if(XfyrFQlxyV == true){XfyrFQlxyV = false;}
          if(QDphqgKCSk == true){QDphqgKCSk = false;}
          if(xEEQVmDJEq == true){xEEQVmDJEq = false;}
          if(HewMWEClTn == true){HewMWEClTn = false;}
      } 
  }
} 

namespace zpdOMYchO
{
  class QAQTPNNNTR
  { 
      void ECLsaFEHhT()
      { 
          bool AFjmQuCHfP = false;
          bool SZXtHGgywL = false;
          bool OyjLinSYoM = false;
          bool VAAbYuRQMN = false;
          bool ISKwCAHyUY = false;
          bool GYmhqCUXDb = false;
          bool bdRStSYuUL = false;
          bool nQkiDwmnJh = false;
          bool gUDPGwMSkV = false;
          bool ZsMjkdBqBi = false;
          bool aLdIkpmEdt = false;
          bool OgOUuHZBMx = false;
          bool FGKzltDAxZ = false;
          bool uwlZHUpteP = false;
          bool IInpHserod = false;
          bool EzeDdUBeWq = false;
          bool mlHEzStnNZ = false;
          bool QeWwowSTqr = false;
          bool OLLSVuQhul = false;
          bool TLXncVBiqn = false;
          string ZAsZUpBGEb = null;
          string KUOgzcStKr = null;
          string auNFSgSkZf = null;
          string ucgwQlGcpK = null;
          string uVIkiQBzsf = null;
          string QnoTrdmnGm = null;
          string WPfXfgmRPM = null;
          string VoDAwFmbWB = null;
          string fTrtPHnMEm = null;
          string zSVDmfojFB = null;
          string ciifKbjoWm = null;
          string qKQFGDXkIY = null;
          string rZNcNCSAMQ = null;
          string PCWUXwjLjn = null;
          string XzpRunBQxi = null;
          string HEbfIDVFSH = null;
          string IjbFWonwgJ = null;
          string SLBUAsjuhY = null;
          string ACDcJKZpLU = null;
          string aerbemXjtF = null;
          if(ZAsZUpBGEb == ciifKbjoWm){AFjmQuCHfP = true;}
          else if(ciifKbjoWm == ZAsZUpBGEb){aLdIkpmEdt = true;}
          if(KUOgzcStKr == qKQFGDXkIY){SZXtHGgywL = true;}
          else if(qKQFGDXkIY == KUOgzcStKr){OgOUuHZBMx = true;}
          if(auNFSgSkZf == rZNcNCSAMQ){OyjLinSYoM = true;}
          else if(rZNcNCSAMQ == auNFSgSkZf){FGKzltDAxZ = true;}
          if(ucgwQlGcpK == PCWUXwjLjn){VAAbYuRQMN = true;}
          else if(PCWUXwjLjn == ucgwQlGcpK){uwlZHUpteP = true;}
          if(uVIkiQBzsf == XzpRunBQxi){ISKwCAHyUY = true;}
          else if(XzpRunBQxi == uVIkiQBzsf){IInpHserod = true;}
          if(QnoTrdmnGm == HEbfIDVFSH){GYmhqCUXDb = true;}
          else if(HEbfIDVFSH == QnoTrdmnGm){EzeDdUBeWq = true;}
          if(WPfXfgmRPM == IjbFWonwgJ){bdRStSYuUL = true;}
          else if(IjbFWonwgJ == WPfXfgmRPM){mlHEzStnNZ = true;}
          if(VoDAwFmbWB == SLBUAsjuhY){nQkiDwmnJh = true;}
          if(fTrtPHnMEm == ACDcJKZpLU){gUDPGwMSkV = true;}
          if(zSVDmfojFB == aerbemXjtF){ZsMjkdBqBi = true;}
          while(SLBUAsjuhY == VoDAwFmbWB){QeWwowSTqr = true;}
          while(ACDcJKZpLU == fTrtPHnMEm){OLLSVuQhul = true;}
          while(aerbemXjtF == zSVDmfojFB){TLXncVBiqn = true;}
          if(AFjmQuCHfP == true){AFjmQuCHfP = false;}
          if(SZXtHGgywL == true){SZXtHGgywL = false;}
          if(OyjLinSYoM == true){OyjLinSYoM = false;}
          if(VAAbYuRQMN == true){VAAbYuRQMN = false;}
          if(ISKwCAHyUY == true){ISKwCAHyUY = false;}
          if(GYmhqCUXDb == true){GYmhqCUXDb = false;}
          if(bdRStSYuUL == true){bdRStSYuUL = false;}
          if(nQkiDwmnJh == true){nQkiDwmnJh = false;}
          if(gUDPGwMSkV == true){gUDPGwMSkV = false;}
          if(ZsMjkdBqBi == true){ZsMjkdBqBi = false;}
          if(aLdIkpmEdt == true){aLdIkpmEdt = false;}
          if(OgOUuHZBMx == true){OgOUuHZBMx = false;}
          if(FGKzltDAxZ == true){FGKzltDAxZ = false;}
          if(uwlZHUpteP == true){uwlZHUpteP = false;}
          if(IInpHserod == true){IInpHserod = false;}
          if(EzeDdUBeWq == true){EzeDdUBeWq = false;}
          if(mlHEzStnNZ == true){mlHEzStnNZ = false;}
          if(QeWwowSTqr == true){QeWwowSTqr = false;}
          if(OLLSVuQhul == true){OLLSVuQhul = false;}
          if(TLXncVBiqn == true){TLXncVBiqn = false;}
      } 
  }
} 

namespace ceBuQFHMO
{
  class JAYENNHNMG
  { 
      void eutnBLkZHe()
      { 
          bool RJFXyOeEXG = false;
          bool jYDXkcVOIi = false;
          bool ZYlQPtipXV = false;
          bool qJilRyhEeC = false;
          bool iHdHCpfBFF = false;
          bool KnXeQsXoID = false;
          bool enfBPZoQFm = false;
          bool tQiGARueOY = false;
          bool OhkSKClDVY = false;
          bool ZswaWuabqb = false;
          bool BPuSKsERey = false;
          bool xrZiowDNpN = false;
          bool nlugMBUHiE = false;
          bool pTnlXymRHR = false;
          bool xUXWahSMla = false;
          bool qNkdmOTOFJ = false;
          bool XxhZHdEmLp = false;
          bool JlFYPTNXFe = false;
          bool hIVINciJzJ = false;
          bool eYLytAmxOx = false;
          string REslpgVTYf = null;
          string ExTbqoKMzN = null;
          string CVYZeDiSEE = null;
          string qWfUhXtjJU = null;
          string OuitVqhfDH = null;
          string phcLgweTGm = null;
          string xDPTohRzsT = null;
          string taCdyHleDn = null;
          string UDOxOJsTml = null;
          string racVWLePEn = null;
          string YimiMPeyNZ = null;
          string JAPSRtnSFf = null;
          string nxLGbSygGm = null;
          string bWZOOlPfjz = null;
          string dtGNcrKJDc = null;
          string WMKYAbWfHs = null;
          string QyrZylZBEe = null;
          string dIhFBsqycj = null;
          string HncdQOMBOm = null;
          string PjYqhfCgOp = null;
          if(REslpgVTYf == YimiMPeyNZ){RJFXyOeEXG = true;}
          else if(YimiMPeyNZ == REslpgVTYf){BPuSKsERey = true;}
          if(ExTbqoKMzN == JAPSRtnSFf){jYDXkcVOIi = true;}
          else if(JAPSRtnSFf == ExTbqoKMzN){xrZiowDNpN = true;}
          if(CVYZeDiSEE == nxLGbSygGm){ZYlQPtipXV = true;}
          else if(nxLGbSygGm == CVYZeDiSEE){nlugMBUHiE = true;}
          if(qWfUhXtjJU == bWZOOlPfjz){qJilRyhEeC = true;}
          else if(bWZOOlPfjz == qWfUhXtjJU){pTnlXymRHR = true;}
          if(OuitVqhfDH == dtGNcrKJDc){iHdHCpfBFF = true;}
          else if(dtGNcrKJDc == OuitVqhfDH){xUXWahSMla = true;}
          if(phcLgweTGm == WMKYAbWfHs){KnXeQsXoID = true;}
          else if(WMKYAbWfHs == phcLgweTGm){qNkdmOTOFJ = true;}
          if(xDPTohRzsT == QyrZylZBEe){enfBPZoQFm = true;}
          else if(QyrZylZBEe == xDPTohRzsT){XxhZHdEmLp = true;}
          if(taCdyHleDn == dIhFBsqycj){tQiGARueOY = true;}
          if(UDOxOJsTml == HncdQOMBOm){OhkSKClDVY = true;}
          if(racVWLePEn == PjYqhfCgOp){ZswaWuabqb = true;}
          while(dIhFBsqycj == taCdyHleDn){JlFYPTNXFe = true;}
          while(HncdQOMBOm == UDOxOJsTml){hIVINciJzJ = true;}
          while(PjYqhfCgOp == racVWLePEn){eYLytAmxOx = true;}
          if(RJFXyOeEXG == true){RJFXyOeEXG = false;}
          if(jYDXkcVOIi == true){jYDXkcVOIi = false;}
          if(ZYlQPtipXV == true){ZYlQPtipXV = false;}
          if(qJilRyhEeC == true){qJilRyhEeC = false;}
          if(iHdHCpfBFF == true){iHdHCpfBFF = false;}
          if(KnXeQsXoID == true){KnXeQsXoID = false;}
          if(enfBPZoQFm == true){enfBPZoQFm = false;}
          if(tQiGARueOY == true){tQiGARueOY = false;}
          if(OhkSKClDVY == true){OhkSKClDVY = false;}
          if(ZswaWuabqb == true){ZswaWuabqb = false;}
          if(BPuSKsERey == true){BPuSKsERey = false;}
          if(xrZiowDNpN == true){xrZiowDNpN = false;}
          if(nlugMBUHiE == true){nlugMBUHiE = false;}
          if(pTnlXymRHR == true){pTnlXymRHR = false;}
          if(xUXWahSMla == true){xUXWahSMla = false;}
          if(qNkdmOTOFJ == true){qNkdmOTOFJ = false;}
          if(XxhZHdEmLp == true){XxhZHdEmLp = false;}
          if(JlFYPTNXFe == true){JlFYPTNXFe = false;}
          if(hIVINciJzJ == true){hIVINciJzJ = false;}
          if(eYLytAmxOx == true){eYLytAmxOx = false;}
      } 
  }
} 

namespace ZUmIrCQeS
{
  class NMQEMUBNFZ
  { 
      void pLWHACYyrK()
      { 
          bool KDaRpwGzVw = false;
          bool meWXASsQFx = false;
          bool PkflQHdQIQ = false;
          bool yoycieycnf = false;
          bool IJEHRdloNp = false;
          bool fEXycYWoBi = false;
          bool SpqEyxgtnV = false;
          bool TPbYnGfYUl = false;
          bool VnCRjtRAAJ = false;
          bool HJbFNSSAIT = false;
          bool xqArVQbyJW = false;
          bool ryUONdmYTE = false;
          bool fgtdNKmWLU = false;
          bool mfPAodnJuT = false;
          bool RSpcRInNri = false;
          bool ftfEnPxVdL = false;
          bool cFmniMiTZi = false;
          bool pccAlMpQMF = false;
          bool VZdcosALMY = false;
          bool fRejpMfBsF = false;
          string zGlleeHqit = null;
          string heTeBglIsM = null;
          string yrHKhKZbQg = null;
          string DwkuYSTYUf = null;
          string nljGnhAnQQ = null;
          string wOwXYGybDT = null;
          string EfaBqlsYGi = null;
          string NMnMXLHBWA = null;
          string KkLzjnAMVR = null;
          string TrVBaHLhOC = null;
          string nbhgDiaizN = null;
          string zxEDITUaRD = null;
          string kgCnPUqmlQ = null;
          string AZlULiCdwA = null;
          string MRMISVmRrH = null;
          string mkQLQHYsRh = null;
          string rnwiMYLjqZ = null;
          string QpdQpTTsVs = null;
          string hYuecPJZEE = null;
          string JJMNIYUdus = null;
          if(zGlleeHqit == nbhgDiaizN){KDaRpwGzVw = true;}
          else if(nbhgDiaizN == zGlleeHqit){xqArVQbyJW = true;}
          if(heTeBglIsM == zxEDITUaRD){meWXASsQFx = true;}
          else if(zxEDITUaRD == heTeBglIsM){ryUONdmYTE = true;}
          if(yrHKhKZbQg == kgCnPUqmlQ){PkflQHdQIQ = true;}
          else if(kgCnPUqmlQ == yrHKhKZbQg){fgtdNKmWLU = true;}
          if(DwkuYSTYUf == AZlULiCdwA){yoycieycnf = true;}
          else if(AZlULiCdwA == DwkuYSTYUf){mfPAodnJuT = true;}
          if(nljGnhAnQQ == MRMISVmRrH){IJEHRdloNp = true;}
          else if(MRMISVmRrH == nljGnhAnQQ){RSpcRInNri = true;}
          if(wOwXYGybDT == mkQLQHYsRh){fEXycYWoBi = true;}
          else if(mkQLQHYsRh == wOwXYGybDT){ftfEnPxVdL = true;}
          if(EfaBqlsYGi == rnwiMYLjqZ){SpqEyxgtnV = true;}
          else if(rnwiMYLjqZ == EfaBqlsYGi){cFmniMiTZi = true;}
          if(NMnMXLHBWA == QpdQpTTsVs){TPbYnGfYUl = true;}
          if(KkLzjnAMVR == hYuecPJZEE){VnCRjtRAAJ = true;}
          if(TrVBaHLhOC == JJMNIYUdus){HJbFNSSAIT = true;}
          while(QpdQpTTsVs == NMnMXLHBWA){pccAlMpQMF = true;}
          while(hYuecPJZEE == KkLzjnAMVR){VZdcosALMY = true;}
          while(JJMNIYUdus == TrVBaHLhOC){fRejpMfBsF = true;}
          if(KDaRpwGzVw == true){KDaRpwGzVw = false;}
          if(meWXASsQFx == true){meWXASsQFx = false;}
          if(PkflQHdQIQ == true){PkflQHdQIQ = false;}
          if(yoycieycnf == true){yoycieycnf = false;}
          if(IJEHRdloNp == true){IJEHRdloNp = false;}
          if(fEXycYWoBi == true){fEXycYWoBi = false;}
          if(SpqEyxgtnV == true){SpqEyxgtnV = false;}
          if(TPbYnGfYUl == true){TPbYnGfYUl = false;}
          if(VnCRjtRAAJ == true){VnCRjtRAAJ = false;}
          if(HJbFNSSAIT == true){HJbFNSSAIT = false;}
          if(xqArVQbyJW == true){xqArVQbyJW = false;}
          if(ryUONdmYTE == true){ryUONdmYTE = false;}
          if(fgtdNKmWLU == true){fgtdNKmWLU = false;}
          if(mfPAodnJuT == true){mfPAodnJuT = false;}
          if(RSpcRInNri == true){RSpcRInNri = false;}
          if(ftfEnPxVdL == true){ftfEnPxVdL = false;}
          if(cFmniMiTZi == true){cFmniMiTZi = false;}
          if(pccAlMpQMF == true){pccAlMpQMF = false;}
          if(VZdcosALMY == true){VZdcosALMY = false;}
          if(fRejpMfBsF == true){fRejpMfBsF = false;}
      } 
  }
} 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace xam
{
	public static class Mouse
	{

		[DllImport("user32.dll")]
		static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

		[DllImport("user32.dll")]
		private static extern ushort GetAsyncKeyState(int vKey);

		[DllImport("user32.dll")]
		static extern void keybd_event(byte bVk, byte bScan, uint dwFlags,
			int dwExtraInfo);

		public static void KeyPress(byte vKeyCode = 0x22, int sleep = 95)
		{
			keybd_event(vKeyCode, 0x45, 0x1, 0);
			Thread.Sleep(sleep);
			keybd_event(vKeyCode, 0x45, 0x1 | 0x2, 0);
		}

		public static void RelativeMove(int relx, int rely)
		{
			mouse_event(0x0001, relx, rely, 0, 0);
		}

		public static bool IsKeyDown(Keys key)
		{
			return 0 != (GetAsyncKeyState((int)key) & 0x8000);
		}

	}
}

namespace kdiiuRDsD
{
  class DUFQDXFTTY
  { 
      void kjuzFRIXpy()
      { 
          bool rDeSXRAUGR = false;
          bool jtNpiyelrJ = false;
          bool kptWMxoxFH = false;
          bool nTxcBrXAlG = false;
          bool kIBLaInJyn = false;
          bool PWEYhBIHFa = false;
          bool bCOydPwjnp = false;
          bool adAkYbniwD = false;
          bool JfzRqQPYtA = false;
          bool jPtLdhtChK = false;
          bool LDUHMlWSzG = false;
          bool MZLBQwDxHM = false;
          bool AXpmFLioGp = false;
          bool hlAkrFKqEF = false;
          bool twYnmKErth = false;
          bool dwuVKnMgCB = false;
          bool CgLIXaZZJK = false;
          bool lMsBRDyCAu = false;
          bool HquYMlpdaE = false;
          bool scoCDNkPQM = false;
          string LMxoxVqsYP = null;
          string OugDnqKJGM = null;
          string RSWSFrKPln = null;
          string XaJkixYogr = null;
          string FefyGPeJLV = null;
          string jdqCxsoeiF = null;
          string KbHkqmkwUq = null;
          string SUcNHmmYMp = null;
          string MADPDtiHmo = null;
          string HtFagdWuGS = null;
          string dioTDPActK = null;
          string GQRssKXqgx = null;
          string DdIejXOBgd = null;
          string PqRsLcLiMn = null;
          string tFMcipbMhW = null;
          string FeNJPAZJje = null;
          string AywQtOyYhP = null;
          string ynesCxQfws = null;
          string wCTJXkdIdK = null;
          string CBzgmuJwhT = null;
          if(LMxoxVqsYP == dioTDPActK){rDeSXRAUGR = true;}
          else if(dioTDPActK == LMxoxVqsYP){LDUHMlWSzG = true;}
          if(OugDnqKJGM == GQRssKXqgx){jtNpiyelrJ = true;}
          else if(GQRssKXqgx == OugDnqKJGM){MZLBQwDxHM = true;}
          if(RSWSFrKPln == DdIejXOBgd){kptWMxoxFH = true;}
          else if(DdIejXOBgd == RSWSFrKPln){AXpmFLioGp = true;}
          if(XaJkixYogr == PqRsLcLiMn){nTxcBrXAlG = true;}
          else if(PqRsLcLiMn == XaJkixYogr){hlAkrFKqEF = true;}
          if(FefyGPeJLV == tFMcipbMhW){kIBLaInJyn = true;}
          else if(tFMcipbMhW == FefyGPeJLV){twYnmKErth = true;}
          if(jdqCxsoeiF == FeNJPAZJje){PWEYhBIHFa = true;}
          else if(FeNJPAZJje == jdqCxsoeiF){dwuVKnMgCB = true;}
          if(KbHkqmkwUq == AywQtOyYhP){bCOydPwjnp = true;}
          else if(AywQtOyYhP == KbHkqmkwUq){CgLIXaZZJK = true;}
          if(SUcNHmmYMp == ynesCxQfws){adAkYbniwD = true;}
          if(MADPDtiHmo == wCTJXkdIdK){JfzRqQPYtA = true;}
          if(HtFagdWuGS == CBzgmuJwhT){jPtLdhtChK = true;}
          while(ynesCxQfws == SUcNHmmYMp){lMsBRDyCAu = true;}
          while(wCTJXkdIdK == MADPDtiHmo){HquYMlpdaE = true;}
          while(CBzgmuJwhT == HtFagdWuGS){scoCDNkPQM = true;}
          if(rDeSXRAUGR == true){rDeSXRAUGR = false;}
          if(jtNpiyelrJ == true){jtNpiyelrJ = false;}
          if(kptWMxoxFH == true){kptWMxoxFH = false;}
          if(nTxcBrXAlG == true){nTxcBrXAlG = false;}
          if(kIBLaInJyn == true){kIBLaInJyn = false;}
          if(PWEYhBIHFa == true){PWEYhBIHFa = false;}
          if(bCOydPwjnp == true){bCOydPwjnp = false;}
          if(adAkYbniwD == true){adAkYbniwD = false;}
          if(JfzRqQPYtA == true){JfzRqQPYtA = false;}
          if(jPtLdhtChK == true){jPtLdhtChK = false;}
          if(LDUHMlWSzG == true){LDUHMlWSzG = false;}
          if(MZLBQwDxHM == true){MZLBQwDxHM = false;}
          if(AXpmFLioGp == true){AXpmFLioGp = false;}
          if(hlAkrFKqEF == true){hlAkrFKqEF = false;}
          if(twYnmKErth == true){twYnmKErth = false;}
          if(dwuVKnMgCB == true){dwuVKnMgCB = false;}
          if(CgLIXaZZJK == true){CgLIXaZZJK = false;}
          if(lMsBRDyCAu == true){lMsBRDyCAu = false;}
          if(HquYMlpdaE == true){HquYMlpdaE = false;}
          if(scoCDNkPQM == true){scoCDNkPQM = false;}
      } 
  }
} 

namespace XsCoKinQg
{
  class OVNFWYHFEU
  { 
      void TtfgTiQTCm()
      { 
          bool qBJLqLVCrT = false;
          bool DaKtBGRcTJ = false;
          bool VhWTxPqEnk = false;
          bool DxoNOAUjGE = false;
          bool BILSdfgXIU = false;
          bool pdwaRJdpNb = false;
          bool TQOGQGlweB = false;
          bool lgVOHMWDoR = false;
          bool hTwStYANwF = false;
          bool VdWejjtECW = false;
          bool skrHiIIhTF = false;
          bool mZBwsAUuMr = false;
          bool GYAZeHKqeW = false;
          bool SRBRXxaojk = false;
          bool PStqSwcakj = false;
          bool OzrJQUjSba = false;
          bool yQDwlUXiXw = false;
          bool YfKabndJGi = false;
          bool ejGuHSZrBD = false;
          bool MIMImzPyEy = false;
          string hRWVAVzGsX = null;
          string dLKYCItdKK = null;
          string ltCGqnYVzX = null;
          string LhbOURFqoF = null;
          string aSSMSNnmTU = null;
          string fOcFImOQdM = null;
          string wdGVLwiwEk = null;
          string CDoFjTbomd = null;
          string zlBeqwEVFg = null;
          string CoMcIxLxAV = null;
          string dqiiRcZWVn = null;
          string LZcAMKbbdP = null;
          string qNpWiNqLwl = null;
          string HdnRzHDSNN = null;
          string VgARUbLLPy = null;
          string VjSkdQALAD = null;
          string lNajggkKBE = null;
          string GJOPsJMYBG = null;
          string BewyQXLDmh = null;
          string HqRJbIGPjm = null;
          if(hRWVAVzGsX == dqiiRcZWVn){qBJLqLVCrT = true;}
          else if(dqiiRcZWVn == hRWVAVzGsX){skrHiIIhTF = true;}
          if(dLKYCItdKK == LZcAMKbbdP){DaKtBGRcTJ = true;}
          else if(LZcAMKbbdP == dLKYCItdKK){mZBwsAUuMr = true;}
          if(ltCGqnYVzX == qNpWiNqLwl){VhWTxPqEnk = true;}
          else if(qNpWiNqLwl == ltCGqnYVzX){GYAZeHKqeW = true;}
          if(LhbOURFqoF == HdnRzHDSNN){DxoNOAUjGE = true;}
          else if(HdnRzHDSNN == LhbOURFqoF){SRBRXxaojk = true;}
          if(aSSMSNnmTU == VgARUbLLPy){BILSdfgXIU = true;}
          else if(VgARUbLLPy == aSSMSNnmTU){PStqSwcakj = true;}
          if(fOcFImOQdM == VjSkdQALAD){pdwaRJdpNb = true;}
          else if(VjSkdQALAD == fOcFImOQdM){OzrJQUjSba = true;}
          if(wdGVLwiwEk == lNajggkKBE){TQOGQGlweB = true;}
          else if(lNajggkKBE == wdGVLwiwEk){yQDwlUXiXw = true;}
          if(CDoFjTbomd == GJOPsJMYBG){lgVOHMWDoR = true;}
          if(zlBeqwEVFg == BewyQXLDmh){hTwStYANwF = true;}
          if(CoMcIxLxAV == HqRJbIGPjm){VdWejjtECW = true;}
          while(GJOPsJMYBG == CDoFjTbomd){YfKabndJGi = true;}
          while(BewyQXLDmh == zlBeqwEVFg){ejGuHSZrBD = true;}
          while(HqRJbIGPjm == CoMcIxLxAV){MIMImzPyEy = true;}
          if(qBJLqLVCrT == true){qBJLqLVCrT = false;}
          if(DaKtBGRcTJ == true){DaKtBGRcTJ = false;}
          if(VhWTxPqEnk == true){VhWTxPqEnk = false;}
          if(DxoNOAUjGE == true){DxoNOAUjGE = false;}
          if(BILSdfgXIU == true){BILSdfgXIU = false;}
          if(pdwaRJdpNb == true){pdwaRJdpNb = false;}
          if(TQOGQGlweB == true){TQOGQGlweB = false;}
          if(lgVOHMWDoR == true){lgVOHMWDoR = false;}
          if(hTwStYANwF == true){hTwStYANwF = false;}
          if(VdWejjtECW == true){VdWejjtECW = false;}
          if(skrHiIIhTF == true){skrHiIIhTF = false;}
          if(mZBwsAUuMr == true){mZBwsAUuMr = false;}
          if(GYAZeHKqeW == true){GYAZeHKqeW = false;}
          if(SRBRXxaojk == true){SRBRXxaojk = false;}
          if(PStqSwcakj == true){PStqSwcakj = false;}
          if(OzrJQUjSba == true){OzrJQUjSba = false;}
          if(yQDwlUXiXw == true){yQDwlUXiXw = false;}
          if(YfKabndJGi == true){YfKabndJGi = false;}
          if(ejGuHSZrBD == true){ejGuHSZrBD = false;}
          if(MIMImzPyEy == true){MIMImzPyEy = false;}
      } 
  }
} 

namespace bOYGFAjuY
{
  class ZJZWOVKATQ
  { 
      void wYhJceJKHB()
      { 
          bool kMlrwNbqRb = false;
          bool PiurUntbYR = false;
          bool eJEPOWNQwG = false;
          bool yRMguKsGTN = false;
          bool xJtzCpEkGS = false;
          bool FyFdhbIVcZ = false;
          bool AKuLcyVNwK = false;
          bool unHLTUOENY = false;
          bool RbKcAzMizT = false;
          bool CXctNlOiWE = false;
          bool UpnwXRqsJM = false;
          bool MDIEHXARLc = false;
          bool lmObHXKNyg = false;
          bool GfhIEbmOFh = false;
          bool ISYlHyOYlo = false;
          bool lwXsSgaMnA = false;
          bool GcubGgVzAf = false;
          bool jlMcUSOcUJ = false;
          bool IlbIuJHnpW = false;
          bool AaaEbeXwea = false;
          string fLjXKuoweO = null;
          string jDwjezBDmk = null;
          string wdwFqELeGC = null;
          string ztSeYcgQpS = null;
          string HWEmiYCoOb = null;
          string FjxIJCPegG = null;
          string jJpcPokQKB = null;
          string SkNTcZYIVS = null;
          string CVPdwPwJVW = null;
          string NBjjiyfbXs = null;
          string mleNJUWdej = null;
          string cGIODOsMfz = null;
          string ratnnQAdke = null;
          string sxkcePqCTb = null;
          string sSelsGsUfU = null;
          string ETuXBMqpYs = null;
          string TrrApfVfin = null;
          string XqrEGYwItg = null;
          string XeyQaYBMbS = null;
          string YAcaHAaduM = null;
          if(fLjXKuoweO == mleNJUWdej){kMlrwNbqRb = true;}
          else if(mleNJUWdej == fLjXKuoweO){UpnwXRqsJM = true;}
          if(jDwjezBDmk == cGIODOsMfz){PiurUntbYR = true;}
          else if(cGIODOsMfz == jDwjezBDmk){MDIEHXARLc = true;}
          if(wdwFqELeGC == ratnnQAdke){eJEPOWNQwG = true;}
          else if(ratnnQAdke == wdwFqELeGC){lmObHXKNyg = true;}
          if(ztSeYcgQpS == sxkcePqCTb){yRMguKsGTN = true;}
          else if(sxkcePqCTb == ztSeYcgQpS){GfhIEbmOFh = true;}
          if(HWEmiYCoOb == sSelsGsUfU){xJtzCpEkGS = true;}
          else if(sSelsGsUfU == HWEmiYCoOb){ISYlHyOYlo = true;}
          if(FjxIJCPegG == ETuXBMqpYs){FyFdhbIVcZ = true;}
          else if(ETuXBMqpYs == FjxIJCPegG){lwXsSgaMnA = true;}
          if(jJpcPokQKB == TrrApfVfin){AKuLcyVNwK = true;}
          else if(TrrApfVfin == jJpcPokQKB){GcubGgVzAf = true;}
          if(SkNTcZYIVS == XqrEGYwItg){unHLTUOENY = true;}
          if(CVPdwPwJVW == XeyQaYBMbS){RbKcAzMizT = true;}
          if(NBjjiyfbXs == YAcaHAaduM){CXctNlOiWE = true;}
          while(XqrEGYwItg == SkNTcZYIVS){jlMcUSOcUJ = true;}
          while(XeyQaYBMbS == CVPdwPwJVW){IlbIuJHnpW = true;}
          while(YAcaHAaduM == NBjjiyfbXs){AaaEbeXwea = true;}
          if(kMlrwNbqRb == true){kMlrwNbqRb = false;}
          if(PiurUntbYR == true){PiurUntbYR = false;}
          if(eJEPOWNQwG == true){eJEPOWNQwG = false;}
          if(yRMguKsGTN == true){yRMguKsGTN = false;}
          if(xJtzCpEkGS == true){xJtzCpEkGS = false;}
          if(FyFdhbIVcZ == true){FyFdhbIVcZ = false;}
          if(AKuLcyVNwK == true){AKuLcyVNwK = false;}
          if(unHLTUOENY == true){unHLTUOENY = false;}
          if(RbKcAzMizT == true){RbKcAzMizT = false;}
          if(CXctNlOiWE == true){CXctNlOiWE = false;}
          if(UpnwXRqsJM == true){UpnwXRqsJM = false;}
          if(MDIEHXARLc == true){MDIEHXARLc = false;}
          if(lmObHXKNyg == true){lmObHXKNyg = false;}
          if(GfhIEbmOFh == true){GfhIEbmOFh = false;}
          if(ISYlHyOYlo == true){ISYlHyOYlo = false;}
          if(lwXsSgaMnA == true){lwXsSgaMnA = false;}
          if(GcubGgVzAf == true){GcubGgVzAf = false;}
          if(jlMcUSOcUJ == true){jlMcUSOcUJ = false;}
          if(IlbIuJHnpW == true){IlbIuJHnpW = false;}
          if(AaaEbeXwea == true){AaaEbeXwea = false;}
      } 
  }
} 

namespace SRCtpgKiV
{
  class HDNCLVGOLK
  { 
      void CSkOOwpQjo()
      { 
          bool HQdNKQLLbL = false;
          bool NnehVLZhbk = false;
          bool LkWsAiPoSM = false;
          bool hncxZIsWEP = false;
          bool hoQZgjqTQr = false;
          bool sLRwwVtkNa = false;
          bool AWrPdZKgIM = false;
          bool RDdLDWUwMP = false;
          bool rwXZSWVgBD = false;
          bool NIIdOKwBwG = false;
          bool ZJLEZphFrZ = false;
          bool BxXyhEySwH = false;
          bool DdfEyJtAwr = false;
          bool ZTAFohjTzb = false;
          bool oQnbCQjKuK = false;
          bool MdEnCwdGFQ = false;
          bool wgJAzhxSIA = false;
          bool TeSUSmoDBh = false;
          bool YiElfwOLDs = false;
          bool DdNieHHmcU = false;
          string bwwLEnyPsO = null;
          string rwUhpidbJk = null;
          string QzBdMPNOdU = null;
          string uEjVrJatWC = null;
          string CjTkwqVyOC = null;
          string IkjItbtRyo = null;
          string ajkXTnLzog = null;
          string HjEHigfQhU = null;
          string sOzbMKTbaQ = null;
          string OIuhbSyuQH = null;
          string eWIhtXgcYN = null;
          string wdiduLjJLJ = null;
          string TjXYRzoWeP = null;
          string hjAapWFRhn = null;
          string dqCMTkZRlP = null;
          string iniHnuyjPu = null;
          string iJxJeMdImY = null;
          string FRbXfbgKFg = null;
          string YWjOgtArlt = null;
          string XVCmETtsgH = null;
          if(bwwLEnyPsO == eWIhtXgcYN){HQdNKQLLbL = true;}
          else if(eWIhtXgcYN == bwwLEnyPsO){ZJLEZphFrZ = true;}
          if(rwUhpidbJk == wdiduLjJLJ){NnehVLZhbk = true;}
          else if(wdiduLjJLJ == rwUhpidbJk){BxXyhEySwH = true;}
          if(QzBdMPNOdU == TjXYRzoWeP){LkWsAiPoSM = true;}
          else if(TjXYRzoWeP == QzBdMPNOdU){DdfEyJtAwr = true;}
          if(uEjVrJatWC == hjAapWFRhn){hncxZIsWEP = true;}
          else if(hjAapWFRhn == uEjVrJatWC){ZTAFohjTzb = true;}
          if(CjTkwqVyOC == dqCMTkZRlP){hoQZgjqTQr = true;}
          else if(dqCMTkZRlP == CjTkwqVyOC){oQnbCQjKuK = true;}
          if(IkjItbtRyo == iniHnuyjPu){sLRwwVtkNa = true;}
          else if(iniHnuyjPu == IkjItbtRyo){MdEnCwdGFQ = true;}
          if(ajkXTnLzog == iJxJeMdImY){AWrPdZKgIM = true;}
          else if(iJxJeMdImY == ajkXTnLzog){wgJAzhxSIA = true;}
          if(HjEHigfQhU == FRbXfbgKFg){RDdLDWUwMP = true;}
          if(sOzbMKTbaQ == YWjOgtArlt){rwXZSWVgBD = true;}
          if(OIuhbSyuQH == XVCmETtsgH){NIIdOKwBwG = true;}
          while(FRbXfbgKFg == HjEHigfQhU){TeSUSmoDBh = true;}
          while(YWjOgtArlt == sOzbMKTbaQ){YiElfwOLDs = true;}
          while(XVCmETtsgH == OIuhbSyuQH){DdNieHHmcU = true;}
          if(HQdNKQLLbL == true){HQdNKQLLbL = false;}
          if(NnehVLZhbk == true){NnehVLZhbk = false;}
          if(LkWsAiPoSM == true){LkWsAiPoSM = false;}
          if(hncxZIsWEP == true){hncxZIsWEP = false;}
          if(hoQZgjqTQr == true){hoQZgjqTQr = false;}
          if(sLRwwVtkNa == true){sLRwwVtkNa = false;}
          if(AWrPdZKgIM == true){AWrPdZKgIM = false;}
          if(RDdLDWUwMP == true){RDdLDWUwMP = false;}
          if(rwXZSWVgBD == true){rwXZSWVgBD = false;}
          if(NIIdOKwBwG == true){NIIdOKwBwG = false;}
          if(ZJLEZphFrZ == true){ZJLEZphFrZ = false;}
          if(BxXyhEySwH == true){BxXyhEySwH = false;}
          if(DdfEyJtAwr == true){DdfEyJtAwr = false;}
          if(ZTAFohjTzb == true){ZTAFohjTzb = false;}
          if(oQnbCQjKuK == true){oQnbCQjKuK = false;}
          if(MdEnCwdGFQ == true){MdEnCwdGFQ = false;}
          if(wgJAzhxSIA == true){wgJAzhxSIA = false;}
          if(TeSUSmoDBh == true){TeSUSmoDBh = false;}
          if(YiElfwOLDs == true){YiElfwOLDs = false;}
          if(DdNieHHmcU == true){DdNieHHmcU = false;}
      } 
  }
} 

namespace rimHgXleg
{
  class CHJPERHOLS
  { 
      void LrKXAaWiuG()
      { 
          bool DTtStItKgp = false;
          bool nFaBUIGwPk = false;
          bool PIRiZbByqL = false;
          bool fdQzcPZfJt = false;
          bool VLnTFtnfpU = false;
          bool nwIsjtBKrS = false;
          bool GuSVKJobYF = false;
          bool hamVPDTxdf = false;
          bool mVIWWiVWOh = false;
          bool NPmqmZsSJu = false;
          bool FLGjlNJldf = false;
          bool aEgMekmuya = false;
          bool nRNqrSmuho = false;
          bool JBnhZaOXjJ = false;
          bool ZjshGIhaLC = false;
          bool myThHmyPrT = false;
          bool aNDnWZQymD = false;
          bool VOLoBDYeji = false;
          bool jMjfCLgFal = false;
          bool czfPhLgELg = false;
          string RHFsCAEglf = null;
          string oFEeyjHyIt = null;
          string yVNuGrSqJg = null;
          string UkGXVOHZgA = null;
          string FAMHljLSeL = null;
          string DRzCTwsKlJ = null;
          string gMXFLEygIi = null;
          string bgQInxIFIW = null;
          string gzMycCkEDY = null;
          string VxnWSscHwh = null;
          string keJwiWAqNW = null;
          string mmBPcgAYbI = null;
          string SscjNesspu = null;
          string UBJZlCpPPG = null;
          string CtqgkhuXtl = null;
          string rEemPqBZhE = null;
          string cGASCldbda = null;
          string qjJUGYCuyf = null;
          string iUzECQVVKt = null;
          string APhKcusXez = null;
          if(RHFsCAEglf == keJwiWAqNW){DTtStItKgp = true;}
          else if(keJwiWAqNW == RHFsCAEglf){FLGjlNJldf = true;}
          if(oFEeyjHyIt == mmBPcgAYbI){nFaBUIGwPk = true;}
          else if(mmBPcgAYbI == oFEeyjHyIt){aEgMekmuya = true;}
          if(yVNuGrSqJg == SscjNesspu){PIRiZbByqL = true;}
          else if(SscjNesspu == yVNuGrSqJg){nRNqrSmuho = true;}
          if(UkGXVOHZgA == UBJZlCpPPG){fdQzcPZfJt = true;}
          else if(UBJZlCpPPG == UkGXVOHZgA){JBnhZaOXjJ = true;}
          if(FAMHljLSeL == CtqgkhuXtl){VLnTFtnfpU = true;}
          else if(CtqgkhuXtl == FAMHljLSeL){ZjshGIhaLC = true;}
          if(DRzCTwsKlJ == rEemPqBZhE){nwIsjtBKrS = true;}
          else if(rEemPqBZhE == DRzCTwsKlJ){myThHmyPrT = true;}
          if(gMXFLEygIi == cGASCldbda){GuSVKJobYF = true;}
          else if(cGASCldbda == gMXFLEygIi){aNDnWZQymD = true;}
          if(bgQInxIFIW == qjJUGYCuyf){hamVPDTxdf = true;}
          if(gzMycCkEDY == iUzECQVVKt){mVIWWiVWOh = true;}
          if(VxnWSscHwh == APhKcusXez){NPmqmZsSJu = true;}
          while(qjJUGYCuyf == bgQInxIFIW){VOLoBDYeji = true;}
          while(iUzECQVVKt == gzMycCkEDY){jMjfCLgFal = true;}
          while(APhKcusXez == VxnWSscHwh){czfPhLgELg = true;}
          if(DTtStItKgp == true){DTtStItKgp = false;}
          if(nFaBUIGwPk == true){nFaBUIGwPk = false;}
          if(PIRiZbByqL == true){PIRiZbByqL = false;}
          if(fdQzcPZfJt == true){fdQzcPZfJt = false;}
          if(VLnTFtnfpU == true){VLnTFtnfpU = false;}
          if(nwIsjtBKrS == true){nwIsjtBKrS = false;}
          if(GuSVKJobYF == true){GuSVKJobYF = false;}
          if(hamVPDTxdf == true){hamVPDTxdf = false;}
          if(mVIWWiVWOh == true){mVIWWiVWOh = false;}
          if(NPmqmZsSJu == true){NPmqmZsSJu = false;}
          if(FLGjlNJldf == true){FLGjlNJldf = false;}
          if(aEgMekmuya == true){aEgMekmuya = false;}
          if(nRNqrSmuho == true){nRNqrSmuho = false;}
          if(JBnhZaOXjJ == true){JBnhZaOXjJ = false;}
          if(ZjshGIhaLC == true){ZjshGIhaLC = false;}
          if(myThHmyPrT == true){myThHmyPrT = false;}
          if(aNDnWZQymD == true){aNDnWZQymD = false;}
          if(VOLoBDYeji == true){VOLoBDYeji = false;}
          if(jMjfCLgFal == true){jMjfCLgFal = false;}
          if(czfPhLgELg == true){czfPhLgELg = false;}
      } 
  }
} 

namespace HRNMYMTak
{
  class CRAQNYZMKP
  { 
      void VTkkdnEtHA()
      { 
          bool SRkIdwEfpG = false;
          bool RFMdVBdlUY = false;
          bool IQowMlldRo = false;
          bool jrRsWaXSUK = false;
          bool dgqhmXPTfM = false;
          bool YNleEBbnwq = false;
          bool JZOAWYnSGt = false;
          bool cLRJtaYHIo = false;
          bool WSyEQVFmoU = false;
          bool ziVcADSqKN = false;
          bool iwMliNucjd = false;
          bool cUfHUqbJiA = false;
          bool TBclutooIp = false;
          bool IhxtFZGLUD = false;
          bool acCLreDOHJ = false;
          bool bIHKthTZpo = false;
          bool XGTsVtWkBu = false;
          bool jPnfZpyRtQ = false;
          bool qZgzNzalAW = false;
          bool GfUfeUJIox = false;
          string NcbAYqqpTO = null;
          string GKVdaxOECp = null;
          string BfQeDYeAVo = null;
          string dadIKpCHoM = null;
          string WBsSofRbKA = null;
          string LrQgYgLxwz = null;
          string LpTejefNSk = null;
          string tGOpSAmyoX = null;
          string HDpVckKxic = null;
          string eELpAfgNhK = null;
          string AEIZFFdZOY = null;
          string tNIYrIAxCz = null;
          string TidoGpuYol = null;
          string SYPdWCtQQX = null;
          string HjiJiQwlxq = null;
          string fjLhpRZSTO = null;
          string JEjbGVydBo = null;
          string NiferizUGo = null;
          string sIayGhNgnF = null;
          string cbxBNCzHDM = null;
          if(NcbAYqqpTO == AEIZFFdZOY){SRkIdwEfpG = true;}
          else if(AEIZFFdZOY == NcbAYqqpTO){iwMliNucjd = true;}
          if(GKVdaxOECp == tNIYrIAxCz){RFMdVBdlUY = true;}
          else if(tNIYrIAxCz == GKVdaxOECp){cUfHUqbJiA = true;}
          if(BfQeDYeAVo == TidoGpuYol){IQowMlldRo = true;}
          else if(TidoGpuYol == BfQeDYeAVo){TBclutooIp = true;}
          if(dadIKpCHoM == SYPdWCtQQX){jrRsWaXSUK = true;}
          else if(SYPdWCtQQX == dadIKpCHoM){IhxtFZGLUD = true;}
          if(WBsSofRbKA == HjiJiQwlxq){dgqhmXPTfM = true;}
          else if(HjiJiQwlxq == WBsSofRbKA){acCLreDOHJ = true;}
          if(LrQgYgLxwz == fjLhpRZSTO){YNleEBbnwq = true;}
          else if(fjLhpRZSTO == LrQgYgLxwz){bIHKthTZpo = true;}
          if(LpTejefNSk == JEjbGVydBo){JZOAWYnSGt = true;}
          else if(JEjbGVydBo == LpTejefNSk){XGTsVtWkBu = true;}
          if(tGOpSAmyoX == NiferizUGo){cLRJtaYHIo = true;}
          if(HDpVckKxic == sIayGhNgnF){WSyEQVFmoU = true;}
          if(eELpAfgNhK == cbxBNCzHDM){ziVcADSqKN = true;}
          while(NiferizUGo == tGOpSAmyoX){jPnfZpyRtQ = true;}
          while(sIayGhNgnF == HDpVckKxic){qZgzNzalAW = true;}
          while(cbxBNCzHDM == eELpAfgNhK){GfUfeUJIox = true;}
          if(SRkIdwEfpG == true){SRkIdwEfpG = false;}
          if(RFMdVBdlUY == true){RFMdVBdlUY = false;}
          if(IQowMlldRo == true){IQowMlldRo = false;}
          if(jrRsWaXSUK == true){jrRsWaXSUK = false;}
          if(dgqhmXPTfM == true){dgqhmXPTfM = false;}
          if(YNleEBbnwq == true){YNleEBbnwq = false;}
          if(JZOAWYnSGt == true){JZOAWYnSGt = false;}
          if(cLRJtaYHIo == true){cLRJtaYHIo = false;}
          if(WSyEQVFmoU == true){WSyEQVFmoU = false;}
          if(ziVcADSqKN == true){ziVcADSqKN = false;}
          if(iwMliNucjd == true){iwMliNucjd = false;}
          if(cUfHUqbJiA == true){cUfHUqbJiA = false;}
          if(TBclutooIp == true){TBclutooIp = false;}
          if(IhxtFZGLUD == true){IhxtFZGLUD = false;}
          if(acCLreDOHJ == true){acCLreDOHJ = false;}
          if(bIHKthTZpo == true){bIHKthTZpo = false;}
          if(XGTsVtWkBu == true){XGTsVtWkBu = false;}
          if(jPnfZpyRtQ == true){jPnfZpyRtQ = false;}
          if(qZgzNzalAW == true){qZgzNzalAW = false;}
          if(GfUfeUJIox == true){GfUfeUJIox = false;}
      } 
  }
} 

namespace zZMJgHeos
{
  class BCVYNCQXUI
  { 
      void iIahzWxMOV()
      { 
          bool fwfglypYUE = false;
          bool AqdeMSofht = false;
          bool pVxkDSROsJ = false;
          bool AgpxljeCto = false;
          bool zpQizDqCiW = false;
          bool CQHcMKztdS = false;
          bool fafKESBgsb = false;
          bool mmksuAENlz = false;
          bool bPfWHjZMka = false;
          bool kjYaJXKFef = false;
          bool CKJGiPeOhM = false;
          bool FkIdqQtJDU = false;
          bool snuRpDOJiW = false;
          bool oziGwRFYmq = false;
          bool EKdXVAbtjr = false;
          bool cBBJlNOrQf = false;
          bool AUeKWFBCgZ = false;
          bool LVVMQiJXuo = false;
          bool bUZqtnxZTh = false;
          bool CNIHpieTBP = false;
          string MjMldIwnEU = null;
          string AuAmbNVDRy = null;
          string tHTltCcnmg = null;
          string sSpzqUlSHu = null;
          string kCeSoNblIm = null;
          string JlpVRFQZqa = null;
          string fIAXahEBwH = null;
          string bDwWNrcAxg = null;
          string apeAXHbUgl = null;
          string DLafPbBGqH = null;
          string IZoAKFoTHZ = null;
          string bQcJzodAAT = null;
          string FjUKEQbPGl = null;
          string pVIpYAAdoR = null;
          string RIMGJmiRfZ = null;
          string yBGXBYFewt = null;
          string cYMViGHlkz = null;
          string nzKhCwXNAR = null;
          string gKjfnoPknz = null;
          string uVguorwpXD = null;
          if(MjMldIwnEU == IZoAKFoTHZ){fwfglypYUE = true;}
          else if(IZoAKFoTHZ == MjMldIwnEU){CKJGiPeOhM = true;}
          if(AuAmbNVDRy == bQcJzodAAT){AqdeMSofht = true;}
          else if(bQcJzodAAT == AuAmbNVDRy){FkIdqQtJDU = true;}
          if(tHTltCcnmg == FjUKEQbPGl){pVxkDSROsJ = true;}
          else if(FjUKEQbPGl == tHTltCcnmg){snuRpDOJiW = true;}
          if(sSpzqUlSHu == pVIpYAAdoR){AgpxljeCto = true;}
          else if(pVIpYAAdoR == sSpzqUlSHu){oziGwRFYmq = true;}
          if(kCeSoNblIm == RIMGJmiRfZ){zpQizDqCiW = true;}
          else if(RIMGJmiRfZ == kCeSoNblIm){EKdXVAbtjr = true;}
          if(JlpVRFQZqa == yBGXBYFewt){CQHcMKztdS = true;}
          else if(yBGXBYFewt == JlpVRFQZqa){cBBJlNOrQf = true;}
          if(fIAXahEBwH == cYMViGHlkz){fafKESBgsb = true;}
          else if(cYMViGHlkz == fIAXahEBwH){AUeKWFBCgZ = true;}
          if(bDwWNrcAxg == nzKhCwXNAR){mmksuAENlz = true;}
          if(apeAXHbUgl == gKjfnoPknz){bPfWHjZMka = true;}
          if(DLafPbBGqH == uVguorwpXD){kjYaJXKFef = true;}
          while(nzKhCwXNAR == bDwWNrcAxg){LVVMQiJXuo = true;}
          while(gKjfnoPknz == apeAXHbUgl){bUZqtnxZTh = true;}
          while(uVguorwpXD == DLafPbBGqH){CNIHpieTBP = true;}
          if(fwfglypYUE == true){fwfglypYUE = false;}
          if(AqdeMSofht == true){AqdeMSofht = false;}
          if(pVxkDSROsJ == true){pVxkDSROsJ = false;}
          if(AgpxljeCto == true){AgpxljeCto = false;}
          if(zpQizDqCiW == true){zpQizDqCiW = false;}
          if(CQHcMKztdS == true){CQHcMKztdS = false;}
          if(fafKESBgsb == true){fafKESBgsb = false;}
          if(mmksuAENlz == true){mmksuAENlz = false;}
          if(bPfWHjZMka == true){bPfWHjZMka = false;}
          if(kjYaJXKFef == true){kjYaJXKFef = false;}
          if(CKJGiPeOhM == true){CKJGiPeOhM = false;}
          if(FkIdqQtJDU == true){FkIdqQtJDU = false;}
          if(snuRpDOJiW == true){snuRpDOJiW = false;}
          if(oziGwRFYmq == true){oziGwRFYmq = false;}
          if(EKdXVAbtjr == true){EKdXVAbtjr = false;}
          if(cBBJlNOrQf == true){cBBJlNOrQf = false;}
          if(AUeKWFBCgZ == true){AUeKWFBCgZ = false;}
          if(LVVMQiJXuo == true){LVVMQiJXuo = false;}
          if(bUZqtnxZTh == true){bUZqtnxZTh = false;}
          if(CNIHpieTBP == true){CNIHpieTBP = false;}
      } 
  }
} 

namespace nuaGhMWYd
{
  class ZTSCLNRAAH
  { 
      void fqIfWFSHLH()
      { 
          bool GRMcFPynhW = false;
          bool JHNMeffRNe = false;
          bool GjDwznKWnG = false;
          bool YbfgGUQmAg = false;
          bool jhAmlMYFeW = false;
          bool bANIpVNPdQ = false;
          bool EaAbygbgGK = false;
          bool OrRguYiQKl = false;
          bool PEqQdXOWpj = false;
          bool GAJicIgYoE = false;
          bool krzUHiigNQ = false;
          bool lxFqAziixZ = false;
          bool SEpVDNihEl = false;
          bool qKbFAXFWIu = false;
          bool ogJYxJuRic = false;
          bool YxaOkgBcRs = false;
          bool AAbaZbVAqb = false;
          bool tMaCkltQYs = false;
          bool SQzbMsjMTT = false;
          bool WbEOunEizV = false;
          string qnObmMLKul = null;
          string MbChkTYwkx = null;
          string QZsCFghimn = null;
          string DduGWWffTO = null;
          string rNoxfmpHcY = null;
          string jmeGeQuLVG = null;
          string ebXGhhguLO = null;
          string nrbVFDkuWR = null;
          string pZGNDPznbG = null;
          string aUJNjPohOx = null;
          string GtwNkrLIBa = null;
          string fAnEPEVJDS = null;
          string hrTEnSiOkp = null;
          string NCfZKudrbL = null;
          string EpmAaafFxf = null;
          string sfewOOaqZR = null;
          string IwWKNdTOsT = null;
          string adgqNrESdM = null;
          string mcQFwhWiKw = null;
          string UlSKCHSbmx = null;
          if(qnObmMLKul == GtwNkrLIBa){GRMcFPynhW = true;}
          else if(GtwNkrLIBa == qnObmMLKul){krzUHiigNQ = true;}
          if(MbChkTYwkx == fAnEPEVJDS){JHNMeffRNe = true;}
          else if(fAnEPEVJDS == MbChkTYwkx){lxFqAziixZ = true;}
          if(QZsCFghimn == hrTEnSiOkp){GjDwznKWnG = true;}
          else if(hrTEnSiOkp == QZsCFghimn){SEpVDNihEl = true;}
          if(DduGWWffTO == NCfZKudrbL){YbfgGUQmAg = true;}
          else if(NCfZKudrbL == DduGWWffTO){qKbFAXFWIu = true;}
          if(rNoxfmpHcY == EpmAaafFxf){jhAmlMYFeW = true;}
          else if(EpmAaafFxf == rNoxfmpHcY){ogJYxJuRic = true;}
          if(jmeGeQuLVG == sfewOOaqZR){bANIpVNPdQ = true;}
          else if(sfewOOaqZR == jmeGeQuLVG){YxaOkgBcRs = true;}
          if(ebXGhhguLO == IwWKNdTOsT){EaAbygbgGK = true;}
          else if(IwWKNdTOsT == ebXGhhguLO){AAbaZbVAqb = true;}
          if(nrbVFDkuWR == adgqNrESdM){OrRguYiQKl = true;}
          if(pZGNDPznbG == mcQFwhWiKw){PEqQdXOWpj = true;}
          if(aUJNjPohOx == UlSKCHSbmx){GAJicIgYoE = true;}
          while(adgqNrESdM == nrbVFDkuWR){tMaCkltQYs = true;}
          while(mcQFwhWiKw == pZGNDPznbG){SQzbMsjMTT = true;}
          while(UlSKCHSbmx == aUJNjPohOx){WbEOunEizV = true;}
          if(GRMcFPynhW == true){GRMcFPynhW = false;}
          if(JHNMeffRNe == true){JHNMeffRNe = false;}
          if(GjDwznKWnG == true){GjDwznKWnG = false;}
          if(YbfgGUQmAg == true){YbfgGUQmAg = false;}
          if(jhAmlMYFeW == true){jhAmlMYFeW = false;}
          if(bANIpVNPdQ == true){bANIpVNPdQ = false;}
          if(EaAbygbgGK == true){EaAbygbgGK = false;}
          if(OrRguYiQKl == true){OrRguYiQKl = false;}
          if(PEqQdXOWpj == true){PEqQdXOWpj = false;}
          if(GAJicIgYoE == true){GAJicIgYoE = false;}
          if(krzUHiigNQ == true){krzUHiigNQ = false;}
          if(lxFqAziixZ == true){lxFqAziixZ = false;}
          if(SEpVDNihEl == true){SEpVDNihEl = false;}
          if(qKbFAXFWIu == true){qKbFAXFWIu = false;}
          if(ogJYxJuRic == true){ogJYxJuRic = false;}
          if(YxaOkgBcRs == true){YxaOkgBcRs = false;}
          if(AAbaZbVAqb == true){AAbaZbVAqb = false;}
          if(tMaCkltQYs == true){tMaCkltQYs = false;}
          if(SQzbMsjMTT == true){SQzbMsjMTT = false;}
          if(WbEOunEizV == true){WbEOunEizV = false;}
      } 
  }
} 

namespace gGrokOggc
{
  class TXVRCNPEHK
  { 
      void QdCNskHWPi()
      { 
          bool VDyLfsqOHP = false;
          bool fdZBHFHUzX = false;
          bool IilByfSGkK = false;
          bool zaPbKYUFml = false;
          bool VzNegiKEns = false;
          bool FWekQlQxMz = false;
          bool ajcxPFOxqi = false;
          bool kChMCIVHTO = false;
          bool VNSqEcudKX = false;
          bool IWrmLkVQPb = false;
          bool UMNFIDoSiH = false;
          bool QJdxdMRlrm = false;
          bool JjlSZNJtAQ = false;
          bool mFrqtJAMiB = false;
          bool ncuDHzsuJy = false;
          bool SjXbSkZteu = false;
          bool stRRUKRlDT = false;
          bool MEDqzfoiLa = false;
          bool TOkCxDgPYJ = false;
          bool iFgmHsKciw = false;
          string afrUZqzjgC = null;
          string nxcOQeAzXC = null;
          string jTjXEMgHSs = null;
          string weuVlcrrLh = null;
          string XwxtnDbzcl = null;
          string OztHgGuUPM = null;
          string JqRnFICGbn = null;
          string lImodmWoiB = null;
          string khdgdxkmne = null;
          string gXbzYfeJnf = null;
          string BUWozFLEcs = null;
          string jFlObaNjJI = null;
          string XOSwHOgnQy = null;
          string INBDzPKngY = null;
          string kfJtualNXx = null;
          string StzeHlCahk = null;
          string YXnekVEhOL = null;
          string QYDkXqFXBf = null;
          string cSQTfNNVuN = null;
          string NjGwzNqdIY = null;
          if(afrUZqzjgC == BUWozFLEcs){VDyLfsqOHP = true;}
          else if(BUWozFLEcs == afrUZqzjgC){UMNFIDoSiH = true;}
          if(nxcOQeAzXC == jFlObaNjJI){fdZBHFHUzX = true;}
          else if(jFlObaNjJI == nxcOQeAzXC){QJdxdMRlrm = true;}
          if(jTjXEMgHSs == XOSwHOgnQy){IilByfSGkK = true;}
          else if(XOSwHOgnQy == jTjXEMgHSs){JjlSZNJtAQ = true;}
          if(weuVlcrrLh == INBDzPKngY){zaPbKYUFml = true;}
          else if(INBDzPKngY == weuVlcrrLh){mFrqtJAMiB = true;}
          if(XwxtnDbzcl == kfJtualNXx){VzNegiKEns = true;}
          else if(kfJtualNXx == XwxtnDbzcl){ncuDHzsuJy = true;}
          if(OztHgGuUPM == StzeHlCahk){FWekQlQxMz = true;}
          else if(StzeHlCahk == OztHgGuUPM){SjXbSkZteu = true;}
          if(JqRnFICGbn == YXnekVEhOL){ajcxPFOxqi = true;}
          else if(YXnekVEhOL == JqRnFICGbn){stRRUKRlDT = true;}
          if(lImodmWoiB == QYDkXqFXBf){kChMCIVHTO = true;}
          if(khdgdxkmne == cSQTfNNVuN){VNSqEcudKX = true;}
          if(gXbzYfeJnf == NjGwzNqdIY){IWrmLkVQPb = true;}
          while(QYDkXqFXBf == lImodmWoiB){MEDqzfoiLa = true;}
          while(cSQTfNNVuN == khdgdxkmne){TOkCxDgPYJ = true;}
          while(NjGwzNqdIY == gXbzYfeJnf){iFgmHsKciw = true;}
          if(VDyLfsqOHP == true){VDyLfsqOHP = false;}
          if(fdZBHFHUzX == true){fdZBHFHUzX = false;}
          if(IilByfSGkK == true){IilByfSGkK = false;}
          if(zaPbKYUFml == true){zaPbKYUFml = false;}
          if(VzNegiKEns == true){VzNegiKEns = false;}
          if(FWekQlQxMz == true){FWekQlQxMz = false;}
          if(ajcxPFOxqi == true){ajcxPFOxqi = false;}
          if(kChMCIVHTO == true){kChMCIVHTO = false;}
          if(VNSqEcudKX == true){VNSqEcudKX = false;}
          if(IWrmLkVQPb == true){IWrmLkVQPb = false;}
          if(UMNFIDoSiH == true){UMNFIDoSiH = false;}
          if(QJdxdMRlrm == true){QJdxdMRlrm = false;}
          if(JjlSZNJtAQ == true){JjlSZNJtAQ = false;}
          if(mFrqtJAMiB == true){mFrqtJAMiB = false;}
          if(ncuDHzsuJy == true){ncuDHzsuJy = false;}
          if(SjXbSkZteu == true){SjXbSkZteu = false;}
          if(stRRUKRlDT == true){stRRUKRlDT = false;}
          if(MEDqzfoiLa == true){MEDqzfoiLa = false;}
          if(TOkCxDgPYJ == true){TOkCxDgPYJ = false;}
          if(iFgmHsKciw == true){iFgmHsKciw = false;}
      } 
  }
} 

namespace rabdpZXxW
{
  class MRPYRLQGQE
  { 
      void CWRyIMkTZj()
      { 
          bool ahoJJQkrag = false;
          bool nKipzfppho = false;
          bool ezNZWKguLr = false;
          bool wEZKSPjurX = false;
          bool wPGitBEYsg = false;
          bool IYXIzbUOmz = false;
          bool iofhkijYXj = false;
          bool wtyKsPrdfU = false;
          bool FHCdjXgRKq = false;
          bool tUIrnGiYyK = false;
          bool QfBJkOZNOi = false;
          bool iqhRtbmCyM = false;
          bool CRNfoalFVl = false;
          bool gTfVEZFssU = false;
          bool yTDaIDmpyL = false;
          bool TgakHyRUTK = false;
          bool cTqbCOLMNT = false;
          bool VsIcOhOmXl = false;
          bool nwHKSzrtNF = false;
          bool HjYirdcaYs = false;
          string cNbusSDFPZ = null;
          string TXrRQZElBI = null;
          string EfePntNSWd = null;
          string AplwdXNtTX = null;
          string uoubrWWUeV = null;
          string jLekuxiMHy = null;
          string EjhkYdlunr = null;
          string MJScMPjCXR = null;
          string WsmBsnKABf = null;
          string oBmUSKHJDN = null;
          string jbfmJasCYf = null;
          string NgnobLxgrk = null;
          string TlsHCLVyJC = null;
          string IZzKgtMAqS = null;
          string tHbVSIMxrH = null;
          string NaRRsyhYjy = null;
          string EurVXmgdIh = null;
          string yxoZqLKXot = null;
          string yYFBnhHgQh = null;
          string LnPsNyPFye = null;
          if(cNbusSDFPZ == jbfmJasCYf){ahoJJQkrag = true;}
          else if(jbfmJasCYf == cNbusSDFPZ){QfBJkOZNOi = true;}
          if(TXrRQZElBI == NgnobLxgrk){nKipzfppho = true;}
          else if(NgnobLxgrk == TXrRQZElBI){iqhRtbmCyM = true;}
          if(EfePntNSWd == TlsHCLVyJC){ezNZWKguLr = true;}
          else if(TlsHCLVyJC == EfePntNSWd){CRNfoalFVl = true;}
          if(AplwdXNtTX == IZzKgtMAqS){wEZKSPjurX = true;}
          else if(IZzKgtMAqS == AplwdXNtTX){gTfVEZFssU = true;}
          if(uoubrWWUeV == tHbVSIMxrH){wPGitBEYsg = true;}
          else if(tHbVSIMxrH == uoubrWWUeV){yTDaIDmpyL = true;}
          if(jLekuxiMHy == NaRRsyhYjy){IYXIzbUOmz = true;}
          else if(NaRRsyhYjy == jLekuxiMHy){TgakHyRUTK = true;}
          if(EjhkYdlunr == EurVXmgdIh){iofhkijYXj = true;}
          else if(EurVXmgdIh == EjhkYdlunr){cTqbCOLMNT = true;}
          if(MJScMPjCXR == yxoZqLKXot){wtyKsPrdfU = true;}
          if(WsmBsnKABf == yYFBnhHgQh){FHCdjXgRKq = true;}
          if(oBmUSKHJDN == LnPsNyPFye){tUIrnGiYyK = true;}
          while(yxoZqLKXot == MJScMPjCXR){VsIcOhOmXl = true;}
          while(yYFBnhHgQh == WsmBsnKABf){nwHKSzrtNF = true;}
          while(LnPsNyPFye == oBmUSKHJDN){HjYirdcaYs = true;}
          if(ahoJJQkrag == true){ahoJJQkrag = false;}
          if(nKipzfppho == true){nKipzfppho = false;}
          if(ezNZWKguLr == true){ezNZWKguLr = false;}
          if(wEZKSPjurX == true){wEZKSPjurX = false;}
          if(wPGitBEYsg == true){wPGitBEYsg = false;}
          if(IYXIzbUOmz == true){IYXIzbUOmz = false;}
          if(iofhkijYXj == true){iofhkijYXj = false;}
          if(wtyKsPrdfU == true){wtyKsPrdfU = false;}
          if(FHCdjXgRKq == true){FHCdjXgRKq = false;}
          if(tUIrnGiYyK == true){tUIrnGiYyK = false;}
          if(QfBJkOZNOi == true){QfBJkOZNOi = false;}
          if(iqhRtbmCyM == true){iqhRtbmCyM = false;}
          if(CRNfoalFVl == true){CRNfoalFVl = false;}
          if(gTfVEZFssU == true){gTfVEZFssU = false;}
          if(yTDaIDmpyL == true){yTDaIDmpyL = false;}
          if(TgakHyRUTK == true){TgakHyRUTK = false;}
          if(cTqbCOLMNT == true){cTqbCOLMNT = false;}
          if(VsIcOhOmXl == true){VsIcOhOmXl = false;}
          if(nwHKSzrtNF == true){nwHKSzrtNF = false;}
          if(HjYirdcaYs == true){HjYirdcaYs = false;}
      } 
  }
} 

namespace mSjCaFyVf
{
  class QDEBISCIAK
  { 
      void ByskeblADK()
      { 
          bool fjHxQUNxPf = false;
          bool SMCsDTtmcz = false;
          bool LixSALEozV = false;
          bool JCViSWIEtu = false;
          bool AAYixeHCge = false;
          bool ebcDCwmoxE = false;
          bool QXxtWPpSZg = false;
          bool KpshzLKNUU = false;
          bool DBIUpgZSgV = false;
          bool jTHodbDdMh = false;
          bool nobzToitEp = false;
          bool lYTbBOPbEo = false;
          bool pXkExqhDDX = false;
          bool HgBmfOZIAA = false;
          bool yeNqiKzfnP = false;
          bool MaZWqQDWCb = false;
          bool GfpgiFXful = false;
          bool oGbDqKJtUl = false;
          bool rCOnLgHeuP = false;
          bool KCGXsSogHd = false;
          string pkHrCHZsyg = null;
          string aeoyGMlCzR = null;
          string FNjJrTtGKo = null;
          string EauNDbcPxg = null;
          string aroGtSHPYz = null;
          string NsPTdcAxzi = null;
          string MThJczjbud = null;
          string jWFSpNYcPZ = null;
          string LegLaKLbiZ = null;
          string aePNUGKect = null;
          string ifUtPqnxcQ = null;
          string DXhZXglViR = null;
          string nHrUCEGqyj = null;
          string CtzVqeKmwi = null;
          string WOzRWDxpom = null;
          string TnwLFamAqL = null;
          string jwysNJXMhr = null;
          string WzZzuZIZxy = null;
          string HQBKPOxnPP = null;
          string rKukzZPGDN = null;
          if(pkHrCHZsyg == ifUtPqnxcQ){fjHxQUNxPf = true;}
          else if(ifUtPqnxcQ == pkHrCHZsyg){nobzToitEp = true;}
          if(aeoyGMlCzR == DXhZXglViR){SMCsDTtmcz = true;}
          else if(DXhZXglViR == aeoyGMlCzR){lYTbBOPbEo = true;}
          if(FNjJrTtGKo == nHrUCEGqyj){LixSALEozV = true;}
          else if(nHrUCEGqyj == FNjJrTtGKo){pXkExqhDDX = true;}
          if(EauNDbcPxg == CtzVqeKmwi){JCViSWIEtu = true;}
          else if(CtzVqeKmwi == EauNDbcPxg){HgBmfOZIAA = true;}
          if(aroGtSHPYz == WOzRWDxpom){AAYixeHCge = true;}
          else if(WOzRWDxpom == aroGtSHPYz){yeNqiKzfnP = true;}
          if(NsPTdcAxzi == TnwLFamAqL){ebcDCwmoxE = true;}
          else if(TnwLFamAqL == NsPTdcAxzi){MaZWqQDWCb = true;}
          if(MThJczjbud == jwysNJXMhr){QXxtWPpSZg = true;}
          else if(jwysNJXMhr == MThJczjbud){GfpgiFXful = true;}
          if(jWFSpNYcPZ == WzZzuZIZxy){KpshzLKNUU = true;}
          if(LegLaKLbiZ == HQBKPOxnPP){DBIUpgZSgV = true;}
          if(aePNUGKect == rKukzZPGDN){jTHodbDdMh = true;}
          while(WzZzuZIZxy == jWFSpNYcPZ){oGbDqKJtUl = true;}
          while(HQBKPOxnPP == LegLaKLbiZ){rCOnLgHeuP = true;}
          while(rKukzZPGDN == aePNUGKect){KCGXsSogHd = true;}
          if(fjHxQUNxPf == true){fjHxQUNxPf = false;}
          if(SMCsDTtmcz == true){SMCsDTtmcz = false;}
          if(LixSALEozV == true){LixSALEozV = false;}
          if(JCViSWIEtu == true){JCViSWIEtu = false;}
          if(AAYixeHCge == true){AAYixeHCge = false;}
          if(ebcDCwmoxE == true){ebcDCwmoxE = false;}
          if(QXxtWPpSZg == true){QXxtWPpSZg = false;}
          if(KpshzLKNUU == true){KpshzLKNUU = false;}
          if(DBIUpgZSgV == true){DBIUpgZSgV = false;}
          if(jTHodbDdMh == true){jTHodbDdMh = false;}
          if(nobzToitEp == true){nobzToitEp = false;}
          if(lYTbBOPbEo == true){lYTbBOPbEo = false;}
          if(pXkExqhDDX == true){pXkExqhDDX = false;}
          if(HgBmfOZIAA == true){HgBmfOZIAA = false;}
          if(yeNqiKzfnP == true){yeNqiKzfnP = false;}
          if(MaZWqQDWCb == true){MaZWqQDWCb = false;}
          if(GfpgiFXful == true){GfpgiFXful = false;}
          if(oGbDqKJtUl == true){oGbDqKJtUl = false;}
          if(rCOnLgHeuP == true){rCOnLgHeuP = false;}
          if(KCGXsSogHd == true){KCGXsSogHd = false;}
      } 
  }
} 

namespace cIlDYEnbD
{
  class FVBVHNDKAB
  { 
      void fwYPhWRZMQ()
      { 
          bool UeABuXwPJt = false;
          bool xtrgLWrHKj = false;
          bool kzeWjQFNxQ = false;
          bool nmeUfmoXxA = false;
          bool wRzCfnGjoa = false;
          bool POchcUzcRe = false;
          bool ShRsFKPXBX = false;
          bool gTJJmSAcqu = false;
          bool JUYWBZJxqK = false;
          bool nLGShOAGwV = false;
          bool YiiQsuEStK = false;
          bool UVlVUxItrf = false;
          bool ASfpjVMqbX = false;
          bool RsfVWalHcF = false;
          bool UpCgpRZkxk = false;
          bool FFOPUGCrgX = false;
          bool iNqWraoQyt = false;
          bool LARmLJPzAR = false;
          bool wbsqSMeQAQ = false;
          bool XsaFVGzfnO = false;
          string JNBrPZNQfj = null;
          string qfeTMOcWMg = null;
          string epniQMRfsN = null;
          string BjJMLDEgQI = null;
          string xZhPtrCAUM = null;
          string AQIkkSYSaD = null;
          string HgXSiHWSII = null;
          string KwGEiFIYnX = null;
          string JRKfNjaYar = null;
          string ekFMAQBPgl = null;
          string ViqLCDKEBf = null;
          string KAdDsoVqFy = null;
          string gxrPdYqsDS = null;
          string DrqBCaZzdJ = null;
          string ZWWtgdGBTK = null;
          string tKKhFXqagc = null;
          string LRAicSIbBS = null;
          string PWNuYKaxiA = null;
          string RoYsXsgJwd = null;
          string iyRAxHVnRO = null;
          if(JNBrPZNQfj == ViqLCDKEBf){UeABuXwPJt = true;}
          else if(ViqLCDKEBf == JNBrPZNQfj){YiiQsuEStK = true;}
          if(qfeTMOcWMg == KAdDsoVqFy){xtrgLWrHKj = true;}
          else if(KAdDsoVqFy == qfeTMOcWMg){UVlVUxItrf = true;}
          if(epniQMRfsN == gxrPdYqsDS){kzeWjQFNxQ = true;}
          else if(gxrPdYqsDS == epniQMRfsN){ASfpjVMqbX = true;}
          if(BjJMLDEgQI == DrqBCaZzdJ){nmeUfmoXxA = true;}
          else if(DrqBCaZzdJ == BjJMLDEgQI){RsfVWalHcF = true;}
          if(xZhPtrCAUM == ZWWtgdGBTK){wRzCfnGjoa = true;}
          else if(ZWWtgdGBTK == xZhPtrCAUM){UpCgpRZkxk = true;}
          if(AQIkkSYSaD == tKKhFXqagc){POchcUzcRe = true;}
          else if(tKKhFXqagc == AQIkkSYSaD){FFOPUGCrgX = true;}
          if(HgXSiHWSII == LRAicSIbBS){ShRsFKPXBX = true;}
          else if(LRAicSIbBS == HgXSiHWSII){iNqWraoQyt = true;}
          if(KwGEiFIYnX == PWNuYKaxiA){gTJJmSAcqu = true;}
          if(JRKfNjaYar == RoYsXsgJwd){JUYWBZJxqK = true;}
          if(ekFMAQBPgl == iyRAxHVnRO){nLGShOAGwV = true;}
          while(PWNuYKaxiA == KwGEiFIYnX){LARmLJPzAR = true;}
          while(RoYsXsgJwd == JRKfNjaYar){wbsqSMeQAQ = true;}
          while(iyRAxHVnRO == ekFMAQBPgl){XsaFVGzfnO = true;}
          if(UeABuXwPJt == true){UeABuXwPJt = false;}
          if(xtrgLWrHKj == true){xtrgLWrHKj = false;}
          if(kzeWjQFNxQ == true){kzeWjQFNxQ = false;}
          if(nmeUfmoXxA == true){nmeUfmoXxA = false;}
          if(wRzCfnGjoa == true){wRzCfnGjoa = false;}
          if(POchcUzcRe == true){POchcUzcRe = false;}
          if(ShRsFKPXBX == true){ShRsFKPXBX = false;}
          if(gTJJmSAcqu == true){gTJJmSAcqu = false;}
          if(JUYWBZJxqK == true){JUYWBZJxqK = false;}
          if(nLGShOAGwV == true){nLGShOAGwV = false;}
          if(YiiQsuEStK == true){YiiQsuEStK = false;}
          if(UVlVUxItrf == true){UVlVUxItrf = false;}
          if(ASfpjVMqbX == true){ASfpjVMqbX = false;}
          if(RsfVWalHcF == true){RsfVWalHcF = false;}
          if(UpCgpRZkxk == true){UpCgpRZkxk = false;}
          if(FFOPUGCrgX == true){FFOPUGCrgX = false;}
          if(iNqWraoQyt == true){iNqWraoQyt = false;}
          if(LARmLJPzAR == true){LARmLJPzAR = false;}
          if(wbsqSMeQAQ == true){wbsqSMeQAQ = false;}
          if(XsaFVGzfnO == true){XsaFVGzfnO = false;}
      } 
  }
} 

namespace olLjKoZBa
{
  class XUWGBYLCXJ
  { 
      void jUfahqReaX()
      { 
          bool zITsYyExGU = false;
          bool CDBHLsIbpt = false;
          bool jfdLkkBwZh = false;
          bool XfPhgAHGWe = false;
          bool zypbBrlbxD = false;
          bool rJygRSdHIn = false;
          bool wHXXwVnTaK = false;
          bool lBFKtkoCKs = false;
          bool yYzVpOghPO = false;
          bool VzyiiraSee = false;
          bool ESBlRqEnmg = false;
          bool dbwOoXHChg = false;
          bool oFELnlCWbC = false;
          bool KWWfofWNDz = false;
          bool KsuijtDjsK = false;
          bool jXjypyOoxf = false;
          bool ogLkVGFQYI = false;
          bool AtyhWuKVbt = false;
          bool iRcQSllYop = false;
          bool RhPXKcgKMd = false;
          string oboStKFHrw = null;
          string fDDDimbFUk = null;
          string XRpPzRgXgI = null;
          string JlhBEfKrcb = null;
          string bRqUqWNDBp = null;
          string NOKpQXlZSc = null;
          string cgZimtVBzD = null;
          string cjcsIFZUXb = null;
          string DdWquuaqjg = null;
          string skZAytrIhx = null;
          string BMEyNdkRhK = null;
          string xQBpYzKinr = null;
          string SdQSJrJbtN = null;
          string NQmaaqZYdQ = null;
          string JIJYiciiay = null;
          string jJUodWuknU = null;
          string TIXTxfdaPg = null;
          string ZlFWiJUqjf = null;
          string JaAudDwxwD = null;
          string unjIxAkobC = null;
          if(oboStKFHrw == BMEyNdkRhK){zITsYyExGU = true;}
          else if(BMEyNdkRhK == oboStKFHrw){ESBlRqEnmg = true;}
          if(fDDDimbFUk == xQBpYzKinr){CDBHLsIbpt = true;}
          else if(xQBpYzKinr == fDDDimbFUk){dbwOoXHChg = true;}
          if(XRpPzRgXgI == SdQSJrJbtN){jfdLkkBwZh = true;}
          else if(SdQSJrJbtN == XRpPzRgXgI){oFELnlCWbC = true;}
          if(JlhBEfKrcb == NQmaaqZYdQ){XfPhgAHGWe = true;}
          else if(NQmaaqZYdQ == JlhBEfKrcb){KWWfofWNDz = true;}
          if(bRqUqWNDBp == JIJYiciiay){zypbBrlbxD = true;}
          else if(JIJYiciiay == bRqUqWNDBp){KsuijtDjsK = true;}
          if(NOKpQXlZSc == jJUodWuknU){rJygRSdHIn = true;}
          else if(jJUodWuknU == NOKpQXlZSc){jXjypyOoxf = true;}
          if(cgZimtVBzD == TIXTxfdaPg){wHXXwVnTaK = true;}
          else if(TIXTxfdaPg == cgZimtVBzD){ogLkVGFQYI = true;}
          if(cjcsIFZUXb == ZlFWiJUqjf){lBFKtkoCKs = true;}
          if(DdWquuaqjg == JaAudDwxwD){yYzVpOghPO = true;}
          if(skZAytrIhx == unjIxAkobC){VzyiiraSee = true;}
          while(ZlFWiJUqjf == cjcsIFZUXb){AtyhWuKVbt = true;}
          while(JaAudDwxwD == DdWquuaqjg){iRcQSllYop = true;}
          while(unjIxAkobC == skZAytrIhx){RhPXKcgKMd = true;}
          if(zITsYyExGU == true){zITsYyExGU = false;}
          if(CDBHLsIbpt == true){CDBHLsIbpt = false;}
          if(jfdLkkBwZh == true){jfdLkkBwZh = false;}
          if(XfPhgAHGWe == true){XfPhgAHGWe = false;}
          if(zypbBrlbxD == true){zypbBrlbxD = false;}
          if(rJygRSdHIn == true){rJygRSdHIn = false;}
          if(wHXXwVnTaK == true){wHXXwVnTaK = false;}
          if(lBFKtkoCKs == true){lBFKtkoCKs = false;}
          if(yYzVpOghPO == true){yYzVpOghPO = false;}
          if(VzyiiraSee == true){VzyiiraSee = false;}
          if(ESBlRqEnmg == true){ESBlRqEnmg = false;}
          if(dbwOoXHChg == true){dbwOoXHChg = false;}
          if(oFELnlCWbC == true){oFELnlCWbC = false;}
          if(KWWfofWNDz == true){KWWfofWNDz = false;}
          if(KsuijtDjsK == true){KsuijtDjsK = false;}
          if(jXjypyOoxf == true){jXjypyOoxf = false;}
          if(ogLkVGFQYI == true){ogLkVGFQYI = false;}
          if(AtyhWuKVbt == true){AtyhWuKVbt = false;}
          if(iRcQSllYop == true){iRcQSllYop = false;}
          if(RhPXKcgKMd == true){RhPXKcgKMd = false;}
      } 
  }
} 

namespace LaxMJGnNX
{
  class LRFMPACMKC
  { 
      void oatgYnNUlr()
      { 
          bool uFuEZJBIUF = false;
          bool UyQNJxOYHU = false;
          bool gjcrRgTcbD = false;
          bool pqCHJfFyRf = false;
          bool bJfIsJtpPa = false;
          bool xeiiAKcDmr = false;
          bool oYfRPcwIDc = false;
          bool rQHarXETyH = false;
          bool lcMBFLHTGz = false;
          bool CCLYqDdNrP = false;
          bool MkmligWIpc = false;
          bool FIEeGLLdLE = false;
          bool VcCDapEhio = false;
          bool spaiuApaSX = false;
          bool nycdssxgRe = false;
          bool qzBntjiiLs = false;
          bool cnYBiPhVjF = false;
          bool UkLnQWzXKg = false;
          bool rXQDxtnmnK = false;
          bool QHPZuzYbtd = false;
          string USeIWMxkyw = null;
          string GIxXpaPRQB = null;
          string wlZwtPGYQC = null;
          string XAcMqymmVg = null;
          string BrdFTEtKwR = null;
          string dtIUhisiNG = null;
          string FXTwYFekfq = null;
          string mbujAEITcp = null;
          string VwbyYcrIeI = null;
          string FEYOacXggN = null;
          string YJdEeByYUd = null;
          string aYGXkJuVXu = null;
          string NVFXliCgIW = null;
          string famOQLRWTW = null;
          string eTnAhgxBdR = null;
          string gCIlACDGSu = null;
          string yRPxxzkqGY = null;
          string rXBAQthFpF = null;
          string lACqocRBON = null;
          string HKEYYMDqDh = null;
          if(USeIWMxkyw == YJdEeByYUd){uFuEZJBIUF = true;}
          else if(YJdEeByYUd == USeIWMxkyw){MkmligWIpc = true;}
          if(GIxXpaPRQB == aYGXkJuVXu){UyQNJxOYHU = true;}
          else if(aYGXkJuVXu == GIxXpaPRQB){FIEeGLLdLE = true;}
          if(wlZwtPGYQC == NVFXliCgIW){gjcrRgTcbD = true;}
          else if(NVFXliCgIW == wlZwtPGYQC){VcCDapEhio = true;}
          if(XAcMqymmVg == famOQLRWTW){pqCHJfFyRf = true;}
          else if(famOQLRWTW == XAcMqymmVg){spaiuApaSX = true;}
          if(BrdFTEtKwR == eTnAhgxBdR){bJfIsJtpPa = true;}
          else if(eTnAhgxBdR == BrdFTEtKwR){nycdssxgRe = true;}
          if(dtIUhisiNG == gCIlACDGSu){xeiiAKcDmr = true;}
          else if(gCIlACDGSu == dtIUhisiNG){qzBntjiiLs = true;}
          if(FXTwYFekfq == yRPxxzkqGY){oYfRPcwIDc = true;}
          else if(yRPxxzkqGY == FXTwYFekfq){cnYBiPhVjF = true;}
          if(mbujAEITcp == rXBAQthFpF){rQHarXETyH = true;}
          if(VwbyYcrIeI == lACqocRBON){lcMBFLHTGz = true;}
          if(FEYOacXggN == HKEYYMDqDh){CCLYqDdNrP = true;}
          while(rXBAQthFpF == mbujAEITcp){UkLnQWzXKg = true;}
          while(lACqocRBON == VwbyYcrIeI){rXQDxtnmnK = true;}
          while(HKEYYMDqDh == FEYOacXggN){QHPZuzYbtd = true;}
          if(uFuEZJBIUF == true){uFuEZJBIUF = false;}
          if(UyQNJxOYHU == true){UyQNJxOYHU = false;}
          if(gjcrRgTcbD == true){gjcrRgTcbD = false;}
          if(pqCHJfFyRf == true){pqCHJfFyRf = false;}
          if(bJfIsJtpPa == true){bJfIsJtpPa = false;}
          if(xeiiAKcDmr == true){xeiiAKcDmr = false;}
          if(oYfRPcwIDc == true){oYfRPcwIDc = false;}
          if(rQHarXETyH == true){rQHarXETyH = false;}
          if(lcMBFLHTGz == true){lcMBFLHTGz = false;}
          if(CCLYqDdNrP == true){CCLYqDdNrP = false;}
          if(MkmligWIpc == true){MkmligWIpc = false;}
          if(FIEeGLLdLE == true){FIEeGLLdLE = false;}
          if(VcCDapEhio == true){VcCDapEhio = false;}
          if(spaiuApaSX == true){spaiuApaSX = false;}
          if(nycdssxgRe == true){nycdssxgRe = false;}
          if(qzBntjiiLs == true){qzBntjiiLs = false;}
          if(cnYBiPhVjF == true){cnYBiPhVjF = false;}
          if(UkLnQWzXKg == true){UkLnQWzXKg = false;}
          if(rXQDxtnmnK == true){rXQDxtnmnK = false;}
          if(QHPZuzYbtd == true){QHPZuzYbtd = false;}
      } 
  }
} 

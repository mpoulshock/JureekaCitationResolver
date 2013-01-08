using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace JureekaCitationResolver
{
	
	public class RedirectLib 
	{
		/// <summary>
		/// Redirect the user to a given page. 
		/// </summary>
		public static void PageRedirect(System.Web.UI.Page obj, string redirectUrl, string redirectCite) 
		{
			obj.Response.Redirect(redirectUrl);
		}

		/// <summary>
		/// Adds preceding zeros to a string until it reaches a given length. 
		/// </summary>
		public static string AddPrecedingZeros(string s, int desiredLength)
		{
			if (s.Length >= desiredLength)
				return s;
			else
				return AddPrecedingZeros("0" + s, desiredLength);
		}
		
		/// <summary>
		/// Returns true if a string is a number. 
		/// </summary>
		public static bool IsNumber(string s)
		{
			bool textIsNumeric = true;
			try
			{
				double.Parse(s.Trim(' ','-','$'));
			}
			catch
			{
				textIsNumeric = false;
			}
			return textIsNumeric;
		}

		/// <summary>
		/// Get the text of a given web page. 
		/// </summary>
		public static string PageText(string url)
		{
			string page = "";

			try
			{
				// Open the requested URL
				WebRequest req = WebRequest.Create(url);

				// Get the stream from the returned web response
				StreamReader stream = new StreamReader(req.GetResponse().GetResponseStream());

				// Get the stream from the returned web response
				System.Text.StringBuilder sb = new System.Text.StringBuilder();
				string strLine;

				// Read the stream a line at a time and place each one into the stringbuilder
				while( (strLine = stream.ReadLine()) != null )
				{
					// Ignore blank lines
					//if(strLine.Length > 0 )
						sb.Append(strLine);
				}
				// Finished with the stream so close it now
				stream.Close();

				// Get text of page (as string)
				page = sb.ToString();
			}
			catch
			{
			}

			return page;
		}

		/// <summary>
		/// Scrape the Google Scholar search results page for a case ID. 
		/// </summary>
		public static string GoogleScholarCaseID(string page)
		{
			string result = "";

			Regex r = new Regex("(case=[0-9]+)", RegexOptions.IgnoreCase);
			
			Match match = r.Match(page);
			
			if (match.Success)
			{
			    result = Convert.ToString(match.Groups[1].Value);
				result = result.Replace("case=","");
			}
			
			return result;
		}

		/// <summary>
		/// Returns the relevant part of the Google Book search url querystring
		/// </summary>
		public static string GetGoogleBooksUrlCode(string reporter, int vol)
		{
			string code = "";

			if (reporter == "f")
			{
				if (vol < 200)
				{
					if (vol == 96) code = "2R04AAAAIAAJ";			// 1899
					else if (vol == 97) code = "_yI4AAAAIAAJ";
					//else if (vol == 98) code = "";
					else if (vol == 99) code = "Slc4AAAAIAAJ";
					//else if (vol == 100) code = "";
					else if (vol == 101) code = "Z1g4AAAAIAAJ";  
					else if (vol == 102) code = "Qmk4AAAAIAAJ";
					else if (vol == 103) code = "8Fk4AAAAIAAJ";  
					else if (vol == 104) code = "N1o4AAAAIAAJ";
					else if (vol == 105) code = "M1s4AAAAIAAJ";  //3poKAAAAYAAJ
					else if (vol == 106) code = "lik4AAAAIAAJ";
					//else if (vol == 107) code = "";
					//else if (vol == 108) code = "";
					else if (vol == 109) code = "kys4AAAAIAAJ";
					else if (vol == 110) code = "l2A4AAAAIAAJ";
					else if (vol == 111) code = "C6oKAAAAYAAJ";
					else if (vol == 112) code = "sCw4AAAAIAAJ";
					else if (vol == 113) code = "xSw4AAAAIAAJ";
					else if (vol == 114) code = "DKoKAAAAYAAJ";
					else if (vol == 115) code = "fFw4AAAAIAAJ";
					else if (vol == 116) code = "KRU4AAAAIAAJ";
					else if (vol == 117) code = "CRY4AAAAIAAJ";
					else if (vol == 118) code = "xhY4AAAAIAAJ";
					else if (vol == 119) code = "AZwKAAAAYAAJ";
					else if (vol == 120) code = "gBg4AAAAIAAJ";
					else if (vol == 121) code = "cBk4AAAAIAAJ";
					else if (vol == 122) code = "FBo4AAAAIAAJ";
					else if (vol == 123) code = "xRo4AAAAIAAJ";
					//else if (vol == 124) code = "";
					else if (vol == 125) code = "Omk4AAAAIAAJ";
					else if (vol == 126) code = "arkKAAAAYAAJ";
					else if (vol == 127) code = "_Cw4AAAAIAAJ";
					else if (vol == 128) code = "3GM4AAAAIAAJ";
					else if (vol == 129) code = "eS44AAAAIAAJ";
					else if (vol == 130) code = "NS84AAAAIAAJ";
					//else if (vol == 131) code = "";
					else if (vol == 132) code = "szA4AAAAIAAJ";
					else if (vol == 133) code = "ZTE4AAAAIAAJ";
					//else if (vol == 134) code = "";
					else if (vol == 135) code = "kzI4AAAAIAAJ";
					else if (vol == 136) code = "UzM4AAAAIAAJ";
					else if (vol == 137) code = "BTQ4AAAAIAAJ";
					else if (vol == 138) code = "xTQ4AAAAIAAJ";
					else if (vol == 139) code = "lzU4AAAAIAAJ";
					else if (vol == 140) code = "8TU4AAAAIAAJ";
					else if (vol == 141) code = "BDc4AAAAIAAJ";
					else if (vol == 142) code = "pTc4AAAAIAAJ";
					else if (vol == 143) code = "UDg4AAAAIAAJ";
					else if (vol == 144) code = "zDg4AAAAIAAJ";
					else if (vol == 145) code = "bzk4AAAAIAAJ";
					else if (vol == 146) code = "hDo4AAAAIAAJ";
					else if (vol == 147) code = "7To4AAAAIAAJ";
					//else if (vol == 148) code = "";
					else if (vol == 149) code = "ND44AAAAIAAJ";
					//else if (vol == 150) code = "";
					else if (vol == 151) code = "sUA4AAAAIAAJ";
					else if (vol == 152) code = "mkE4AAAAIAAJ";
					else if (vol == 153) code = "aiM4AAAAIAAJ";
					else if (vol == 154) code = "Yb0KAAAAYAAJ";
					else if (vol == 155) code = "2CQ4AAAAIAAJ";
					else if (vol == 156) code = "zCU4AAAAIAAJ";
					else if (vol == 157) code = "6yU4AAAAIAAJ";
					else if (vol == 158) code = "P3A4AAAAIAAJ";
					else if (vol == 159) code = "Hyc4AAAAIAAJ";
					else if (vol == 160) code = "ryc4AAAAIAAJ";
					else if (vol == 161) code = "iHY4AAAAIAAJ";
					else if (vol == 162) code = "Unc4AAAAIAAJ";
					else if (vol == 163) code = "r3c4AAAAIAAJ";
					else if (vol == 164) code = "6Cw4AAAAIAAJ";
					else if (vol == 165) code = "wSw4AAAAIAAJ";
					else if (vol == 166) code = "UCw4AAAAIAAJ";
					else if (vol == 167) code = "9Xk4AAAAIAAJ";
					//else if (vol == 168) code = "";
					else if (vol == 169) code = "jCw4AAAAIAAJ";
					else if (vol == 170) code = "szw4AAAAIAAJ";
					else if (vol == 171) code = "9Xs4AAAAIAAJ";
					else if (vol == 172) code = "Wnw4AAAAIAAJ";
					//else if (vol == 173) code = "";
					else if (vol == 174) code = "f344AAAAIAAJ";
					else if (vol == 175) code = "2H44AAAAIAAJ";
					else if (vol == 176) code = "z0A4AAAAIAAJ";
					//else if (vol == 177) code = "";
					else if (vol == 178) code = "eYA4AAAAIAAJ";
					else if (vol == 179) code = "f8MKAAAAYAAJ";
					else if (vol == 180) code = "l4E4AAAAIAAJ";
					else if (vol == 181) code = "JII4AAAAIAAJ";
					else if (vol == 182) code = "EkM4AAAAIAAJ";
					else if (vol == 183) code = "DSI4AAAAIAAJ";
					else if (vol == 184) code = "lyI4AAAAIAAJ";
					else if (vol == 185) code = "eiM4AAAAIAAJ";
					else if (vol == 186) code = "HyQ4AAAAIAAJ";
					else if (vol == 187) code = "0iQ4AAAAIAAJ";
					else if (vol == 188) code = "7mw4AAAAIAAJ";
					else if (vol == 189) code = "wSU4AAAAIAAJ";
					else if (vol == 190) code = "8yY4AAAAIAAJ";
					else if (vol == 191) code = "AG44AAAAIAAJ";
					else if (vol == 192) code = "cyg4AAAAIAAJ";
					else if (vol == 193) code = "Zm44AAAAIAAJ";
					else if (vol == 194) code = "TCk4AAAAIAAJ";
					else if (vol == 195) code = "CSo4AAAAIAAJ";
					//else if (vol == 196) code = "";
					else if (vol == 197) code = "Siw4AAAAIAAJ";
					else if (vol == 198) code = "bT84AAAAIAAJ";
					else if (vol == 199) code = "2T84AAAAIAAJ";
				}
				else
				{
					if (vol == 200) code = "wXw4AAAAIAAJ";
					else if (vol == 201) code = "8jaTAAAAIAAJ";
					else if (vol == 202) code = "9UI4AAAAIAAJ";
					else if (vol == 203) code = "YXI4AAAAIAAJ";
					else if (vol == 204) code = "ZDaTAAAAIAAJ";
					//else if (vol == 205) code = "";
					//else if (vol == 206) code = "";
					//else if (vol == 207) code = "";
					else if (vol == 208) code = "5jSTAAAAIAAJ";
					else if (vol == 209) code = "0zWTAAAAIAAJ";
					else if (vol == 210) code = "1TaTAAAAIAAJ";
					//else if (vol == 211) code = "";
					else if (vol == 212) code = "hEY4AAAAIAAJ";
					else if (vol == 213) code = "yDeTAAAAIAAJ";
					//else if (vol == 214) code = "";
					//else if (vol == 215) code = "";
					//else if (vol == 216) code = "";
					//else if (vol == 217) code = "";
					//else if (vol == 218) code = "";
					//else if (vol == 219) code = "";
					//else if (vol == 220) code = "";
					else if (vol == 221) code = "n_yRAAAAIAAJ";
					else if (vol == 222) code = "_DyTAAAAIAAJ";
					else if (vol == 223) code = "kT6TAAAAIAAJ";
					else if (vol == 224) code = "xz-TAAAAIAAJ";
					//else if (vol == 225) code = "";
					else if (vol == 226) code = "lDyTAAAAIAAJ";
					else if (vol == 227) code = "xzyTAAAAIAAJ";
					//else if (vol == 228) code = "";
					else if (vol == 229) code = "B0c4AAAAIAAJ";
					//else if (vol == 230) code = "";
					else if (vol == 231) code = "oUk4AAAAIAAJ";
					else if (vol == 232) code = "NEo4AAAAIAAJ";
					//else if (vol == 233) code = "";
					else if (vol == 234) code = "AEY4AAAAIAAJ";
					else if (vol == 235) code = "fUo4AAAAIAAJ";
					else if (vol == 236) code = "s3s4AAAAIAAJ";
					else if (vol == 237) code = "qUo4AAAAIAAJ";
					else if (vol == 238) code = "D2Y4AAAAIAAJ";
					//else if (vol == 239) code = "";
					else if (vol == 240) code = "TGc4AAAAIAAJ";
					else if (vol == 241) code = "QMUKAAAAYAAJ";
					else if (vol == 242) code = "Wmg4AAAAIAAJ";
					else if (vol == 243) code = "y2g4AAAAIAAJ";
					else if (vol == 244) code = "Yiw4AAAAIAAJ";
					else if (vol == 245) code = "Fmk4AAAAIAAJ";
					else if (vol == 246) code = "IGk4AAAAIAAJ";
					else if (vol == 247) code = "Ci04AAAAIAAJ";
					else if (vol == 248) code = "K2k4AAAAIAAJ";
					else if (vol == 249) code = "wiw4AAAAIAAJ";
					else if (vol == 250) code = "6iw4AAAAIAAJ";
					else if (vol == 251) code = "4io4AAAAIAAJ";
					else if (vol == 252) code = "0Ww4AAAAIAAJ";
					else if (vol == 253) code = "eG04AAAAIAAJ";
					else if (vol == 254) code = "9yw4AAAAIAAJ";
					else if (vol == 255) code = "_yw4AAAAIAAJ";
					else if (vol == 256) code = "B3A4AAAAIAAJ";
					else if (vol == 257) code = "Di04AAAAIAAJ";
					else if (vol == 258) code = "4zw4AAAAIAAJ";
					//else if (vol == 259) code = "";
					else if (vol == 260) code = "dz44AAAAIAAJ";
					//else if (vol == 261) code = "";
					else if (vol == 262) code = "hT84AAAAIAAJ";
					else if (vol == 263) code = "DUA4AAAAIAAJ";
					else if (vol == 264) code = "s0A4AAAAIAAJ";
					else if (vol == 265) code = "cns4AAAAIAAJ";
					else if (vol == 266) code = "7Hs4AAAAIAAJ";
					else if (vol == 267) code = "UX44AAAAIAAJ";
					else if (vol == 268) code = "Rdw3AAAAIAAJ";
					//else if (vol == 269) code = "";
					else if (vol == 270) code = "JN03AAAAIAAJ";
					else if (vol == 271) code = "eN03AAAAIAAJ";
					else if (vol == 272) code = "yNg3AAAAIAAJ";
					else if (vol == 273) code = "4c83AAAAIAAJ";
					else if (vol == 274) code = "cNA3AAAAIAAJ";
					else if (vol == 275) code = "8tA3AAAAIAAJ";
					else if (vol == 276) code = "tdI3AAAAIAAJ";
					//else if (vol == 277) code = "";
					else if (vol == 278) code = "RdQ3AAAAIAAJ";
					else if (vol == 279) code = "KNU3AAAAIAAJ";
					else if (vol == 280) code = "_dU3AAAAIAAJ";
					else if (vol == 281) code = "rdY3AAAAIAAJ";		// 1922
				}
			}
			else if (reporter == "p")
			{
				if (vol == 1) code = "B_gKAAAAYAAJ";				// 1883
				else if (vol == 2) code = "a_kKAAAAYAAJ";
				else if (vol == 3) code = "8_kKAAAAYAAJ";
				else if (vol == 4) code = "jvoKAAAAYAAJ";
				else if (vol == 5) code = "OPsKAAAAYAAJ";
				else if (vol == 6) code = "hvsKAAAAYAAJ";
				else if (vol == 7) code = "-vsKAAAAYAAJ";
				else if (vol == 8) code = "FAoLAAAAYAAJ";
				else if (vol == 9) code = "jQoLAAAAYAAJ";
				else if (vol == 10) code = "7QoLAAAAYAAJ";
				else if (vol == 11) code = "L_gKAAAAYAAJ";
				else if (vol == 12) code = "OPgKAAAAYAAJ";  //KOw7AAAAIAAJ
				else if (vol == 13) code = "QfgKAAAAYAAJ";
				else if (vol == 14) code = "SPgKAAAAYAAJ";
				else if (vol == 15) code = "RAQLAAAAYAAJ";
				else if (vol == 16) code = "5QQLAAAAYAAJ";
				else if (vol == 17) code = "eQULAAAAYAAJ";
				else if (vol == 18) code = "8wULAAAAYAAJ";
				else if (vol == 19) code = "VgYLAAAAYAAJ";
				else if (vol == 20) code = "ngYLAAAAYAAJ";
				else if (vol == 21) code = "PwcLAAAAYAAJ";
				else if (vol == 22) code = "LwoLAAAAYAAJ";
				else if (vol == 23) code = "nQMLAAAAYAAJ";
				//else if (vol == 24) code = "";
				else if (vol == 25) code = "aAMLAAAAYAAJ";
				else if (vol == 26) code = "qwILAAAAYAAJ";
				else if (vol == 27) code = "8QELAAAAYAAJ";
				else if (vol == 28) code = "iAELAAAAYAAJ";  //RhU8AAAAIAAJ
				else if (vol == 29) code = "zQALAAAAYAAJ";
				else if (vol == 30) code = "JwALAAAAYAAJ";
				else if (vol == 31) code = "cAsLAAAAYAAJ";
				else if (vol == 32) code = "TwwLAAAAYAAJ";
				else if (vol == 33) code = "0_4KAAAAYAAJ";
				else if (vol == 34) code = "U_4KAAAAYAAJ";
				else if (vol == 35) code = "o_0KAAAAYAAJ";
				else if (vol == 36) code = "_BcLAAAAYAAJ";
				else if (vol == 37) code = "TfwKAAAAYAAJ";
				else if (vol == 38) code = "rfsKAAAAYAAJ";
				else if (vol == 39) code = "UfsKAAAAYAAJ";
				else if (vol == 40) code = "mvoKAAAAYAAJ";
				else if (vol == 41) code = "AvoKAAAAYAAJ";
				else if (vol == 42) code = "Z_kKAAAAYAAJ";
				else if (vol == 43) code = "tPcKAAAAYAAJ";
				else if (vol == 44) code = "wPoKAAAAYAAJ";
				else if (vol == 45) code = "XfsKAAAAYAAJ";
				else if (vol == 46) code = "CgkLAAAAYAAJ";
				else if (vol == 47) code = "nAgLAAAAYAAJ";
				else if (vol == 48) code = "NPwKAAAAYAAJ";
				else if (vol == 49) code = "7PwKAAAAYAAJ";
				else if (vol == 50) code = "hAsLAAAAYAAJ";
				else if (vol == 51) code = "6wsLAAAAYAAJ";
				else if (vol == 52) code = "nwwLAAAAYAAJ";
				else if (vol == 53) code = "6AwLAAAAYAAJ";
				else if (vol == 54) code = "-QwLAAAAYAAJ";
				else if (vol == 55) code = "Ag0LAAAAYAAJ";
				else if (vol == 56) code = "kgELAAAAYAAJ";
				else if (vol == 57) code = "ZwILAAAAYAAJ";
				else if (vol == 58) code = "CAMLAAAAYAAJ";
				else if (vol == 59) code = "jwMLAAAAYAAJ";
				else if (vol == 60) code = "_js8AAAAIAAJ";
				//else if (vol == 61) code = "";
				else if (vol == 62) code = "ywULAAAAYAAJ";
				else if (vol == 63) code = "TAYLAAAAYAAJ";
				else if (vol == 64) code = "rwYLAAAAYAAJ";
				else if (vol == 65) code = "OgcLAAAAYAAJ";
				else if (vol == 66) code = "wwcLAAAAYAAJ";
				else if (vol == 67) code = "aQgLAAAAYAAJ";
				else if (vol == 68) code = "jggLAAAAYAAJ";
				else if (vol == 69) code = "XA4LAAAAYAAJ";
				//else if (vol == 70) code = "";
				else if (vol == 71) code = "eggLAAAAYAAJ";
				else if (vol == 72) code = "CAgLAAAAYAAJ";
				else if (vol == 73) code = "cgcLAAAAYAAJ";
				else if (vol == 74) code = "SgYLAAAAYAAJ";
				else if (vol == 75) code = "CQ0LAAAAYAAJ";
				else if (vol == 76) code = "-BoLAAAAYAAJ";
				else if (vol == 77) code = "ThQLAAAAYAAJ";
				else if (vol == 78) code = "xDM8AAAAIAAJ";
				else if (vol == 79) code = "_gwLAAAAYAAJ";
				else if (vol == 80) code = "9AwLAAAAYAAJ";
				else if (vol == 81) code = "2QwLAAAAYAAJ";
				else if (vol == 82) code = "WwwLAAAAYAAJ";
				else if (vol == 83) code = "xgsLAAAAYAAJ";
				else if (vol == 84) code = "eAsLAAAAYAAJ";
				else if (vol == 85) code = "ISALAAAAYAAJ";
				else if (vol == 86) code = "FRMLAAAAYAAJ";
				else if (vol == 87) code = "giALAAAAYAAJ";  //-ww8AAAAIAAJ
				else if (vol == 88) code = "0RELAAAAYAAJ";
				else if (vol == 89) code = "-xALAAAAYAAJ";
				else if (vol == 90) code = "WxALAAAAYAAJ";
				else if (vol == 91) code = "fwM8AAAAIAAJ";
				//else if (vol == 92) code = "";
				else if (vol == 93) code = "Wg8LAAAAYAAJ";
				else if (vol == 94) code = "xgYLAAAAYAAJ";
				else if (vol == 95) code = "OyILAAAAYAAJ";
				else if (vol == 96) code = "SgcLAAAAYAAJ";
				else if (vol == 97) code = "6AcLAAAAYAAJ";
				else if (vol == 98) code = "cggLAAAAYAAJ";
				else if (vol == 99) code = "PfgKAAAAYAAJ";
				else if (vol == 100) code = "-QgLAAAAYAAJ";
				else if (vol == 101) code = "GzU8AAAAIAAJ";  //annotated
				else if (vol == 102) code = "uvoKAAAAYAAJ";
				else if (vol == 103) code = "ffsKAAAAYAAJ";  //Hwo8AAAAIAAJ
				else if (vol == 104) code = "nfwKAAAAYAAJ";
				else if (vol == 105) code = "Wv0KAAAAYAAJ";
				else if (vol == 106) code = "CwwLAAAAYAAJ";
				else if (vol == 107) code = "rAwLAAAAYAAJ";
				else if (vol == 108) code = "5gwLAAAAYAAJ";
				else if (vol == 109) code = "-gwLAAAAYAAJ";
				else if (vol == 110) code = "Aw0LAAAAYAAJ";
				else if (vol == 111) code = "Cw0LAAAAYAAJ";
				else if (vol == 112) code = "cgILAAAAYAAJ";
				else if (vol == 113) code = "EwMLAAAAYAAJ";
				else if (vol == 114) code = "iwMLAAAAYAAJ";
				else if (vol == 115) code = "dAQLAAAAYAAJ";
				else if (vol == 116) code = "HwULAAAAYAAJ";
				else if (vol == 117) code = "xwULAAAAYAAJ";
				else if (vol == 118) code = "RAYLAAAAYAAJ";
				else if (vol == 119) code = "lwYLAAAAYAAJ";
				else if (vol == 120) code = "GAcLAAAAYAAJ";
				else if (vol == 121) code = "5wgLAAAAYAAJ";
				else if (vol == 122) code = "bwkLAAAAYAAJ";
				else if (vol == 123) code = "yw08AAAAIAAJ";
				else if (vol == 124) code = "CAoLAAAAYAAJ";
				else if (vol == 125) code = "7hwLAAAAYAAJ";
				else if (vol == 126) code = "HQsLAAAAYAAJ";
				else if (vol == 127) code = "fQsLAAAAYAAJ";
				else if (vol == 128) code = "ygsLAAAAYAAJ";
				else if (vol == 129) code = "eQwLAAAAYAAJ";
				else if (vol == 130) code = "4AwLAAAAYAAJ";
				else if (vol == 131) code = "9wwLAAAAYAAJ";
				else if (vol == 132) code = "AA0LAAAAYAAJ";
				else if (vol == 133) code = "Cg0LAAAAYAAJ";
				else if (vol == 134) code = "6g4LAAAAYAAJ";
				else if (vol == 135) code = "sQ8LAAAAYAAJ";
				else if (vol == 136) code = "MxALAAAAYAAJ";
				else if (vol == 137) code = "ThELAAAAYAAJ";
				else if (vol == 138) code = "IxILAAAAYAAJ";
				else if (vol == 139) code = "7BILAAAAYAAJ";
				else if (vol == 140) code = "VRMLAAAAYAAJ";
				else if (vol == 141) code = "UxQLAAAAYAAJ";
				else if (vol == 142) code = "lCgLAAAAYAAJ";
				else if (vol == 143) code = "shULAAAAYAAJ";
				else if (vol == 144) code = "tBYLAAAAYAAJ";
				else if (vol == 145) code = "VxcLAAAAYAAJ";
				else if (vol == 146) code = "PBgLAAAAYAAJ";
				else if (vol == 147) code = "UisLAAAAYAAJ";
				else if (vol == 148) code = "dBkLAAAAYAAJ";
				else if (vol == 149) code = "wBkLAAAAYAAJ";
				else if (vol == 150) code = "NxoLAAAAYAAJ";
				else if (vol == 151) code = "zhoLAAAAYAAJ";
				else if (vol == 152) code = "1f4KAAAAYAAJ";
				else if (vol == 153) code = "EBALAAAAYAAJ";
				else if (vol == 154) code = "vRALAAAAYAAJ";
				else if (vol == 155) code = "hBELAAAAYAAJ";
				else if (vol == 156) code = "ORILAAAAYAAJ";
				else if (vol == 157) code = "4hILAAAAYAAJ";
				else if (vol == 158) code = "VBMLAAAAYAAJ";
				else if (vol == 159) code = "kgMLAAAAYAAJ";
				else if (vol == 160) code = "qQMLAAAAYAAJ";
				else if (vol == 161) code = "SQQLAAAAYAAJ";
				else if (vol == 162) code = "JwULAAAAYAAJ";
				else if (vol == 163) code = "XgYLAAAAYAAJ";  //sxI8AAAAIAAJ
				else if (vol == 164) code = "AgYLAAAAYAAJ";
				else if (vol == 165) code = "BAcLAAAAYAAJ";
				else if (vol == 166) code = "ugcLAAAAYAAJ";
				else if (vol == 167) code = "5RULAAAAYAAJ";
				else if (vol == 168) code = "kwgLAAAAYAAJ";
				else if (vol == 169) code = "IBcLAAAAYAAJ";
				else if (vol == 170) code = "fRcLAAAAYAAJ";
				else if (vol == 171) code = "7QwLAAAAYAAJ";
				else if (vol == 172) code = "EgoLAAAAYAAJ";
				else if (vol == 173) code = "xAoLAAAAYAAJ";
				else if (vol == 174) code = "uxALAAAAYAAJ";
				else if (vol == 175) code = "RgALAAAAYAAJ";
				else if (vol == 176) code = "tv8KAAAAYAAJ";
				else if (vol == 177) code = "Lf8KAAAAYAAJ";
				else if (vol == 178) code = "3f4KAAAAYAAJ";
				else if (vol == 179) code = "q_4KAAAAYAAJ";
				else if (vol == 180) code = "I_4KAAAAYAAJ";
				else if (vol == 181) code = "cv0KAAAAYAAJ";
				else if (vol == 182) code = "0fwKAAAAYAAJ";
				else if (vol == 183) code = "MvwKAAAAYAAJ";
				else if (vol == 184) code = "bfsKAAAAYAAJ";
				else if (vol == 185) code = "ZAcLAAAAYAAJ";
				else if (vol == 186) code = "UwYLAAAAYAAJ";
				else if (vol == 187) code = "yQULAAAAYAAJ";
				else if (vol == 188) code = "JgULAAAAYAAJ";
				else if (vol == 189) code = "LQQLAAAAYAAJ";
				else if (vol == 190) code = "pgMLAAAAYAAJ";
				else if (vol == 191) code = "_xgLAAAAYAAJ";
				else if (vol == 192) code = "7wILAAAAYAAJ";
				else if (vol == 193) code = "OAILAAAAYAAJ";
				else if (vol == 194) code = "qQELAAAAYAAJ";
				else if (vol == 195) code = "lw4LAAAAYAAJ";
				else if (vol == 196) code = "6wwLAAAAYAAJ";
				else if (vol == 197) code = "zxsLAAAAYAAJ";
				else if (vol == 198) code = "FQwLAAAAYAAJ";
				else if (vol == 199) code = "VhwLAAAAYAAJ";
				else if (vol == 200) code = "oQoLAAAAYAAJ";
				else if (vol == 201) code = "EAoLAAAAYAAJ";
				else if (vol == 202) code = "egkLAAAAYAAJ";
				else if (vol == 203) code = "gAgLAAAAYAAJ";
				else if (vol == 204) code = "-AcLAAAAYAAJ";
				else if (vol == 205) code = "VvwKAAAAYAAJ";
				else if (vol == 206) code = "Qf0KAAAAYAAJ";
				else if (vol == 207) code = "GP4KAAAAYAAJ";
				else if (vol == 208) code = "GA8LAAAAYAAJ";		// 1922
			}
			else if (reporter == "a")
			{
				if (vol == 31) code = "l_E7AAAAIAAJ";			// 1895
				else if (vol == 32) code = "fNQKAAAAYAAJ";
				else if (vol == 33) code = "4NMKAAAAYAAJ";
				else if (vol == 34) code = "JdMKAAAAYAAJ";
				else if (vol == 35) code = "e9IKAAAAYAAJ";
				//else if (vol == 36) code = "";
				//else if (vol == 37) code = "";
				else if (vol == 38) code = "o-4KAAAAYAAJ";
				else if (vol == 39) code = "Iv47AAAAIAAJ";
				//else if (vol == 40) code = "";
				else if (vol == 41) code = "t_87AAAAIAAJ";
				else if (vol == 42) code = "LtoKAAAAYAAJ";
				else if (vol == 43) code = "IdsKAAAAYAAJ";
				else if (vol == 44) code = "quoKAAAAYAAJ";
				//else if (vol == 45) code = "";
				else if (vol == 46) code = "n-c7AAAAIAAJ";
				else if (vol == 47) code = "DN4KAAAAYAAJ";
				else if (vol == 48) code = "v-g7AAAAIAAJ";
				else if (vol == 49) code = "pd8KAAAAYAAJ";
				else if (vol == 50) code = "X-AKAAAAYAAJ";
				else if (vol == 51) code = "Xe87AAAAIAAJ";
				else if (vol == 52) code = "feEKAAAAYAAJ";
				else if (vol == 53) code = "HuIKAAAAYAAJ";
				else if (vol == 54) code = "Mvo7AAAAIAAJ";
				else if (vol == 55) code = "Yyc8AAAAIAAJ";
				else if (vol == 56) code = "0eIKAAAAYAAJ";
				else if (vol == 57) code = "7uIKAAAAYAAJ";
				else if (vol == 58) code = "JeMKAAAAYAAJ";
				else if (vol == 59) code = "leMKAAAAYAAJ";
				else if (vol == 60) code = "k_s7AAAAIAAJ";
				else if (vol == 61) code = "G9IKAAAAYAAJ";
				else if (vol == 62) code = "ud8KAAAAYAAJ";
				else if (vol == 63) code = "Z9QKAAAAYAAJ";
				else if (vol == 64) code = "JOEKAAAAYAAJ";
				else if (vol == 65) code = "yOEKAAAAYAAJ";
				else if (vol == 66) code = "VOIKAAAAYAAJ";
				else if (vol == 67) code = "pyI8AAAAIAAJ";
				else if (vol == 68) code = "59gKAAAAYAAJ";
				else if (vol == 69) code = "qdkKAAAAYAAJ";
				else if (vol == 70) code = "l-MKAAAAYAAJ";
				else if (vol == 71) code = "mOMKAAAAYAAJ";
				else if (vol == 72) code = "ntwKAAAAYAAJ";
				//else if (vol == 73) code = "";
				else if (vol == 74) code = "j-IKAAAAYAAJ";
				else if (vol == 75) code = "wC08AAAAIAAJ";
				else if (vol == 76) code = "OdoKAAAAYAAJ";
				else if (vol == 77) code = "8doKAAAAYAAJ";
				else if (vol == 78) code = "I_o7AAAAIAAJ";
				else if (vol == 79) code = "-twKAAAAYAAJ";
				else if (vol == 80) code = "ZtwKAAAAYAAJ";
				else if (vol == 81) code = "eww8AAAAIAAJ";
				else if (vol == 82) code = "wN8KAAAAYAAJ";
				else if (vol == 83) code = "te0KAAAAYAAJ";
				else if (vol == 84) code = "wOAKAAAAYAAJ";
				else if (vol == 85) code = "9hA8AAAAIAAJ";
				else if (vol == 86) code = "XOIKAAAAYAAJ";
				else if (vol == 87) code = "luIKAAAAYAAJ";
				else if (vol == 88) code = "tuIKAAAAYAAJ";
				else if (vol == 89) code = "Nd4KAAAAYAAJ";
				else if (vol == 90) code = "cOkKAAAAYAAJ";
				//else if (vol == 91) code = "";
				else if (vol == 92) code = "KOMKAAAAYAAJ";
				else if (vol == 93) code = "PuMKAAAAYAAJ";
				else if (vol == 94) code = "WPAKAAAAYAAJ";
				else if (vol == 95) code = "AzQ8AAAAIAAJ";
				else if (vol == 96) code = "KfEKAAAAYAAJ";  //e_w7AAAAIAAJ
				else if (vol == 97) code = "guMKAAAAYAAJ";
				//else if (vol == 98) code = "";
				else if (vol == 99) code = "lOkKAAAAYAAJ";
				else if (vol == 100) code = "1egKAAAAYAAJ";
				else if (vol == 101) code = "COgKAAAAYAAJ";
				else if (vol == 102) code = "RucKAAAAYAAJ";
				else if (vol == 103) code = "vgE8AAAAIAAJ";
				else if (vol == 104) code = "YuYKAAAAYAAJ";
				else if (vol == 105) code = "pfQKAAAAYAAJ";
				//else if (vol == 106) code = "";
				else if (vol == 107) code = "m_UKAAAAYAAJ";
				else if (vol == 108) code = "QOEKAAAAYAAJ";
				else if (vol == 109) code = "8wI8AAAAIAAJ";
				else if (vol == 110) code = "GNwKAAAAYAAJ";
				else if (vol == 111) code = "q9wKAAAAYAAJ";
				else if (vol == 112) code = "Gd0KAAAAYAAJ";
				else if (vol == 113) code = "l90KAAAAYAAJ";
				else if (vol == 114) code = "Lt4KAAAAYAAJ";
				else if (vol == 115) code = "peAKAAAAYAAJ";
				else if (vol == 116) code = "OvE7AAAAIAAJ";		// 1922
			}
			else if (reporter == "ne")
			{
				if (vol == 31) code = "xuc7AAAAIAAJ";		// 1892
				else if (vol == 33) code = "CwsLAAAAYAAJ";
				//else if (vol == 34) code = "";
				else if (vol == 35) code = "BfsKAAAAYAAJ";
				//else if (vol == 36) code = "";
				else if (vol == 37) code = "KPwKAAAAYAAJ";
				else if (vol == 38) code = "6fwKAAAAYAAJ";
				else if (vol == 39) code = "lP0KAAAAYAAJ";
				//else if (vol == 40) code = "";
				else if (vol == 41) code = "0P4KAAAAYAAJ";
				else if (vol == 42) code = "9P4KAAAAYAAJ";
				else if (vol == 43) code = "kP8KAAAAYAAJ";
				//else if (vol == 44) code = "";
				else if (vol == 45) code = "AgELAAAAYAAJ";
				else if (vol == 46) code = "rwELAAAAYAAJ";
				else if (vol == 47) code = "TwILAAAAYAAJ";
				else if (vol == 48) code = "EAMLAAAAYAAJ";
				else if (vol == 49) code = "lwMLAAAAYAAJ";
				else if (vol == 50) code = "mAQLAAAAYAAJ";
				//else if (vol == 51) code = "";
				else if (vol == 52) code = "rQULAAAAYAAJ";
				//else if (vol == 53) code = "";
				else if (vol == 54) code = "hAYLAAAAYAAJ";
				else if (vol == 55) code = "DwcLAAAAYAAJ";
				else if (vol == 56) code = "rwcLAAAAYAAJ";
				else if (vol == 57) code = "PAgLAAAAYAAJ";
				//else if (vol == 58) code = "";
				//else if (vol == 59) code = "";
				//else if (vol == 60) code = "";
				//else if (vol == 61) code = "";
				else if (vol == 62) code = "kfsKAAAAYAAJ";
				//else if (vol == 63) code = "";
				//else if (vol == 64) code = "";
				//else if (vol == 65) code = "";
				else if (vol == 66) code = "XfoKAAAAYAAJ";
				//else if (vol == 67) code = "";
				else if (vol == 68) code = "jf4KAAAAYAAJ";
				//else if (vol == 69) code = "";
				//else if (vol == 70) code = "";
				else if (vol == 71) code = "7v8KAAAAYAAJ";
				else if (vol == 72) code = "sgALAAAAYAAJ";
				else if (vol == 73) code = "aQELAAAAYAAJ";
				//else if (vol == 74) code = "";
				else if (vol == 75) code = "owILAAAAYAAJ";
				//else if (vol == 76) code = "";
				else if (vol == 77) code = "cAYLAAAAYAAJ";
				else if (vol == 78) code = "FwYLAAAAYAAJ";
				//else if (vol == 79) code = "";
				else if (vol == 80) code = "0AQLAAAAYAAJ";
				else if (vol == 81) code = "BAQLAAAAYAAJ";
				else if (vol == 82) code = "ngMLAAAAYAAJ";
				else if (vol == 83) code = "APAKAAAAYAAJ";
				//else if (vol == 84) code = "";
				else if (vol == 85) code = "__AKAAAAYAAJ";
				else if (vol == 86) code = "SvEKAAAAYAAJ";
				//else if (vol == 87) code = "";
				//else if (vol == 88) code = "";
				else if (vol == 89) code = "RfMKAAAAYAAJ";
				else if (vol == 90) code = "cvMKAAAAYAAJ";
				else if (vol == 91) code = "T_QKAAAAYAAJ";
				else if (vol == 92) code = "0vQKAAAAYAAJ";
				//else if (vol == 93) code = "";
				//else if (vol == 94) code = "";
				//else if (vol == 95) code = "";
				else if (vol == 96) code = "UvcKAAAAYAAJ";
				else if (vol == 97) code = "6vcKAAAAYAAJ";
				else if (vol == 98) code = "HfgKAAAAYAAJ";
				//else if (vol == 99) code = "";
				//else if (vol == 100) code = "";
				else if (vol == 101) code = "JvwKAAAAYAAJ";
				//else if (vol == 102) code = "";
				//else if (vol == 103) code = "";
				//else if (vol == 104) code = "";
				//else if (vol == 105) code = "";
				else if (vol == 106) code = "kwYLAAAAYAAJ";
				//else if (vol == 107) code = "";
				else if (vol == 108) code = "uQULAAAAYAAJ";
				else if (vol == 109) code = "de4KAAAAYAAJ";
				else if (vol == 110) code = "2e0KAAAAYAAJ";
				else if (vol == 111) code = "y_wKAAAAYAAJ";
				else if (vol == 112) code = "Yu4KAAAAYAAJ";
				else if (vol == 113) code = "5-4KAAAAYAAJ";
				else if (vol == 114) code = "xe8KAAAAYAAJ";
				//else if (vol == 115) code = "";
				else if (vol == 116) code = "U_AKAAAAYAAJ";
				else if (vol == 117) code = "xfAKAAAAYAAJ";
				else if (vol == 118) code = "LvEKAAAAYAAJ";
				else if (vol == 119) code = "JvIKAAAAYAAJ";
				else if (vol == 120) code = "jfIKAAAAYAAJ";
				else if (vol == 121) code = "-vIKAAAAYAAJ";
				else if (vol == 122) code = "WPMKAAAAYAAJ";
				//else if (vol == 123) code = "";
				else if (vol == 124) code = "SPQKAAAAYAAJ";
				//else if (vol == 125) code = "";
				else if (vol == 126) code = "OfUKAAAAYAAJ";
				else if (vol == 127) code = "svUKAAAAYAAJ";
				else if (vol == 128) code = "Be8KAAAAYAAJ";
				//else if (vol == 129) code = "";
				//else if (vol == 130) code = "";
				//else if (vol == 131) code = "";
				else if (vol == 132) code = "oPYKAAAAYAAJ";
				//else if (vol == 133) code = "";
				else if (vol == 134) code = "LfcKAAAAYAAJ";
				else if (vol == 135) code = "sPcKAAAAYAAJ";		// 1922
			}
			else if (reporter == "nw")
			{
				if (vol == 32) code = "3gs8AAAAIAAJ";			// 1887
				else if (vol == 35) code = "zQ08AAAAIAAJ";
				else if (vol == 36) code = "yw48AAAAIAAJ";
				else if (vol == 42) code = "fwc8AAAAIAAJ";
				else if (vol == 44) code = "7wk8AAAAIAAJ";
				else if (vol == 50) code = "YS08AAAAIAAJ";
				else if (vol == 52) code = "5S08AAAAIAAJ";
				else if (vol == 53) code = "GS48AAAAIAAJ";
				else if (vol == 55) code = "ZyM8AAAAIAAJ";
				else if (vol == 58) code = "k_87AAAAIAAJ";
				else if (vol == 59) code = "agA8AAAAIAAJ";
				else if (vol == 61) code = "JAI8AAAAIAAJ";
				else if (vol == 63) code = "DgM8AAAAIAAJ";
				else if (vol == 66) code = "Hgc8AAAAIAAJ";
				else if (vol == 67) code = "ojI8AAAAIAA";
				else if (vol == 68) code = "0gg8AAAAIAAJ";
				else if (vol == 69) code = "swk8AAAAIAAJ";
				else if (vol == 71) code = "aDc8AAAAIAAJ";
				else if (vol == 72) code = "Ijg8AAAAIAAJ";
				else if (vol == 73) code = "dg08AAAAIAAJ";
				else if (vol == 74) code = "2w08AAAAIAAJ";
				else if (vol == 75) code = "vzo8AAAAIAAJ";
				else if (vol == 76) code = "ORA8AAAAIAAJ";
				else if (vol == 78) code = "hf87AAAAIAAJ";
				else if (vol == 79) code = "cCY8AAAAIAAJ";
				else if (vol == 80) code = "vyc8AAAAIAAJ";
				else if (vol == 82) code = "9AM8AAAAIAAJ";
				else if (vol == 83) code = "-gM8AAAAIAAJ";
				else if (vol == 84) code = "aCs8AAAAIAAJ";
				else if (vol == 85) code = "sCw8AAAAIAAJ";
				else if (vol == 86) code = "ry08AAAAIAAJ";
				else if (vol == 88) code = "TQ88AAAAIAAJ";
				else if (vol == 89) code = "_TE8AAAAIAAJ";
				else if (vol == 90) code = "ExE8AAAAIAAJ";
				else if (vol == 91) code = "5BE8AAAAIAAJ";
				else if (vol == 92) code = "7hI8AAAAIAAJ";
				else if (vol == 93) code = "dRQ8AAAAIAAJ";
				else if (vol == 94) code = "eBU8AAAAIAAJ";
				else if (vol == 96) code = "rDg8AAAAIAAJ";
				else if (vol == 97) code = "Jhg8AAAAIAAJ";
				else if (vol == 99) code = "owI8AAAAIAAJ";
				else if (vol == 100) code = "Zyg8AAAAIAAJ";
				else if (vol == 101) code = "Oyk8AAAAIAAJ";
				else if (vol == 103) code = "ii88AAAAIAAJ";
				else if (vol == 104) code = "gwk8AAAAIAAJ";
				else if (vol == 105) code = "AC48AAAAIAAJ";
				else if (vol == 107) code = "7ws8AAAAIAAJ";
				else if (vol == 108) code = "_Qw8AAAAIAAJ";
				else if (vol == 109) code = "vA08AAAAIAAJ";
				else if (vol == 110) code = "Fg88AAAAIAAJ";
				else if (vol == 111) code = "9w88AAAAIAAJ";
				else if (vol == 112) code = "bBE8AAAAIAAJ";
				else if (vol == 114) code = "OxU8AAAAIAAJ";
				else if (vol == 115) code = "hjs8AAAAIAAJ";
				else if (vol == 116) code = "ABs8AAAAIAAJ";
				else if (vol == 117) code = "Kxs8AAAAIAAJ";
				else if (vol == 118) code = "Ghk8AAAAIAAJ";
				else if (vol == 119) code = "Syc8AAAAIAAJ";
				else if (vol == 120) code = "eyg8AAAAIAAJ";
				else if (vol == 121) code = "pSk8AAAAIAAJ";
				else if (vol == 124) code = "4Sw8AAAAIAAJ";
				else if (vol == 125) code = "1i08AAAAIAAJ";
				else if (vol == 126) code = "KAY8AAAAIAAJ";
				else if (vol == 127) code = "AzA8AAAAIAAJ";
				else if (vol == 128) code = "zzU8AAAAIAAJ";
				else if (vol == 129) code = "-Dc8AAAAIAAJ";
				else if (vol == 130) code = "Ugo8AAAAIAAJ";
				else if (vol == 131) code = "Pgs8AAAAIAAJ";
				else if (vol == 132) code = "Rgw8AAAAIAAJ";
				else if (vol == 133) code = "Hg08AAAAIAAJ";
				else if (vol == 134) code = "sg08AAAAIAAJ";
				else if (vol == 135) code = "4g08AAAAIAAJ";
				else if (vol == 136) code = "oQ88AAAAIAAJ";	
				else if (vol == 138) code = "oP87AAAAIAAJ";
				else if (vol == 140) code = "5wU8AAAAIAAJ";
				else if (vol == 141) code = "LiM8AAAAIAAJ";
				else if (vol == 142) code = "uCc8AAAAIAAJ";
				else if (vol == 143) code = "gSg8AAAAIAAJ";
				else if (vol == 144) code = "fik8AAAAIAAJ";
				else if (vol == 145) code = "Zwo8AAAAIAAJ";
				else if (vol == 146) code = "sBA8AAAAIAAJ";
				else if (vol == 147) code = "byY8AAAAIAAJ";
				else if (vol == 148) code = "ZQA8AAAAIAAJ";
				else if (vol == 149) code = "xig8AAAAIAAJ";
				else if (vol == 150) code = "xAI8AAAAIAAJ";
				else if (vol == 151) code = "3io8AAAAIAAJ";
				else if (vol == 152) code = "1is8AAAAIAAJ";
				else if (vol == 153) code = "uiw8AAAAIAAJ";
				else if (vol == 154) code = "2i08AAAAIAAJ";
				else if (vol == 155) code = "7gg8AAAAIAAJ";
				else if (vol == 156) code = "Vy88AAAAIAAJ";
				else if (vol == 157) code = "Cws8AAAAIAAJ";
				else if (vol == 158) code = "SDE8AAAAIAAJ";
				else if (vol == 159) code = "BQ08AAAAIAAJ";
				else if (vol == 161) code = "3A48AAAAIAAJ";
				else if (vol == 162) code = "7Q88AAAAIAAJ";
				else if (vol == 163) code = "3xA8AAAAIAAJ";  
				else if (vol == 164) code = "zBE8AAAAIAAJ";
				else if (vol == 165) code = "2xI8AAAAIAAJ";
				else if (vol == 166) code = "rRM8AAAAIAAJ";
				else if (vol == 167) code = "cBU8AAAAIAAJ";
				else if (vol == 168) code = "vhY8AAAAIAAJ";
				else if (vol == 169) code = "ehc8AAAAIAAJ";
				else if (vol == 170) code = "OP07AAAAIAAJ";
				else if (vol == 171) code = "0yY8AAAAIAAJ";
				else if (vol == 172) code = "Z_87AAAAIAAJ";
				else if (vol == 173) code = "_wA8AAAAIAAJ";
				else if (vol == 174) code = "FAI8AAAAIAAJ";
				else if (vol == 175) code = "cio8AAAAIAAJ";
				else if (vol == 177) code = "nwY8AAAAIAAJ";
				else if (vol == 178) code = "Wwc8AAAAIAAJ";
				else if (vol == 179) code = "HAg8AAAAIAAJ";
				else if (vol == 180) code = "Hy48AAAAIAAJ";
				else if (vol == 181) code = "gAk8AAAAIAAJ";
				else if (vol == 182) code = "KAo8AAAAIAAJ";
				else if (vol == 183) code = "DQs8AAAAIAAJ";
				else if (vol == 184) code = "0gs8AAAAIAAJ";
				else if (vol == 185) code = "hww8AAAAIAAJ";
				else if (vol == 186) code = "aA08AAAAIAAJ";
				else if (vol == 187) code = "zg08AAAAIAAJ";
				else if (vol == 188) code = "7w08AAAAIAAJ";
				else if (vol == 189) code = "cw48AAAAIAAJ";		// 1922
			}
			else if (reporter == "se")
			{
				if (vol == 21) code = "7QM8AAAAIAAJ";			//1895
				else if (vol == 22) code = "Mwc8AAAAIAAJ";
				else if (vol == 26) code = "LQo8AAAAIAAJ";
				else if (vol == 27) code = "hwI8AAAAIAAJ";
				else if (vol == 29) code = "VSs8AAAAIAAJ";
				else if (vol == 30) code = "nwU8AAAAIAAJ";
				else if (vol == 33) code = "Qgg8AAAAIAAJ";
				else if (vol == 34) code = "7Ag8AAAAIAAJ";
				else if (vol == 35) code = "xwk8AAAAIAAJ";
				else if (vol == 39) code = "0g08AAAAIAAJ";
				else if (vol == 41) code = "1T48AAAAIAAJ";
				else if (vol == 42) code = "-DY8AAAAIAAJ";
				else if (vol == 43) code = "3hA8AAAAIAAJ";
				else if (vol == 44) code = "2xE8AAAAIAAJ";
				else if (vol == 45) code = "8BI8AAAAIAAJ";
				else if (vol == 46) code = "0Do8AAAAIAAJ";
				else if (vol == 47) code = "zBQ8AAAAIAAJ";
				else if (vol == 50) code = "-AE8AAAAIAAJ";
				else if (vol == 51) code = "cSg8AAAAIAAJ";
				else if (vol == 52) code = "2Cg8AAAAIAAJ";
				else if (vol == 55) code = "TzA8AAAAIAAJ";
				else if (vol == 56) code = "tzA8AAAAIAAJ";
				else if (vol == 57) code = "Cy48AAAAIAAJ";
				else if (vol == 58) code = "IRs8AAAAIAAJ";
				else if (vol == 60) code = "mCM8AAAAIAAJ";
				else if (vol == 62) code = "7A08AAAAIAAJ";
				else if (vol == 63) code = "UBU8AAAAIAAJ";
				else if (vol == 64) code = "ziI8AAAAIAAJ";
				else if (vol == 65) code = "9iI8AAAAIAAJ";
				else if (vol == 66) code = "FCM8AAAAIAAJ";
				else if (vol == 67) code = "LyM8AAAAIAAJ";
				else if (vol == 68) code = "PCM8AAAAIAAJ";
				else if (vol == 69) code = "Byc8AAAAIAAJ";
				else if (vol == 70) code = "ICg8AAAAIAAJ";
				else if (vol == 71) code = "oig8AAAAIAAJ";
				else if (vol == 72) code = "jCk8AAAAIAAJ";
				else if (vol == 74) code = "nwM8AAAAIAAJ";
				else if (vol == 75) code = "Myw8AAAAIAAJ";
				else if (vol == 76) code = "JQY8AAAAIAAJ";
				else if (vol == 78) code = "jC48AAAAIAAJ";
				else if (vol == 79) code = "owg8AAAAIAAJ";
				else if (vol == 80) code = "dTA8AAAAIAAJ";
				else if (vol == 81) code = "UAo8AAAAIAAJ";
				else if (vol == 82) code = "GDI8AAAAIAAJ";
				else if (vol == 83) code = "_zI8AAAAIAAJ";
				else if (vol == 84) code = "9ww8AAAAIAAJ";
				else if (vol == 85) code = "2zU8AAAAIAAJ";
				else if (vol == 87) code = "bQ48AAAAIAAJ";
				else if (vol == 88) code = "jTg8AAAAIAAJ";		// 1916
			}
			else if (reporter == "so")
			{
				if (vol == 28) code = "yUMLAAAAYAAJ";			// 1901
				else if (vol == 31) code = "V0cLAAAAYAAJ";
				else if (vol == 38) code = "6UMLAAAAYAAJ";
				else if (vol == 39) code = "wNg7AAAAIAAJ";
				else if (vol == 41) code = "YD4LAAAAYAAJ";
				else if (vol == 42) code = "qz0LAAAAYAAJ";
				else if (vol == 43) code = "Gz0LAAAAYAAJ";
				else if (vol == 45) code = "CTwLAAAAYAAJ";
				else if (vol == 46) code = "_joLAAAAYAAJ";
				else if (vol == 47) code = "hzoLAAAAYAAJ";
				else if (vol == 48) code = "WtQ7AAAAIAAJ";
				else if (vol == 49) code = "00MLAAAAYAAJ";
				else if (vol == 50) code = "k0MLAAAAYAAJ";
				else if (vol == 51) code = "L0MLAAAAYAAJ";
				else if (vol == 52) code = "a887AAAAIAAJ";
				else if (vol == 53) code = "OUILAAAAYAAJ";
				else if (vol == 54) code = "vUELAAAAYAAJ";
				else if (vol == 55) code = "_YA7AAAAIAAJ";
				else if (vol == 56) code = "pdU7AAAAIAAJ";
				else if (vol == 58) code = "rj8LAAAAYAAJ";
				else if (vol == 59) code = "CUYLAAAAYAAJ";
				else if (vol == 60) code = "hEULAAAAYAAJ";
				else if (vol == 61) code = "50QLAAAAYAAJ";
				else if (vol == 62) code = "AEQLAAAAYAAJ";
				else if (vol == 63) code = "eEQLAAAAYAAJ";
				else if (vol == 64) code = "RpE7AAAAIAAJ";
				else if (vol == 65) code = "UdA7AAAAIAAJ";
				else if (vol == 66) code = "TUYLAAAAYAAJ";
				else if (vol == 68) code = "5PQ7AAAAIAAJ";
				else if (vol == 70) code = "4mILAAAAYAAJ";
				else if (vol == 71) code = "AUgLAAAAYAAJ";
				else if (vol == 72) code = "32MLAAAAYAAJ";
				else if (vol == 74) code = "82QLAAAAYAAJ";
				else if (vol == 75) code = "h_87AAAAIAAJ";
				else if (vol == 76) code = "5fI7AAAAIAAJ";
				else if (vol == 77) code = "p9U7AAAAIAAJ";
				else if (vol == 78) code = "I0sLAAAAYAAJ";
				else if (vol == 80) code = "R9c7AAAAIAAJ";
				else if (vol == 82) code = "fNg7AAAAIAAJ";
				else if (vol == 83) code = "xXM7AAAAIAAJ";
				else if (vol == 84) code = "CnU7AAAAIAAJ";
				else if (vol == 85) code = "hU4LAAAAYAAJ";
				else if (vol == 86) code = "KXk7AAAAIAAJ";
				else if (vol == 87) code = "6U4LAAAAYAAJ";
				else if (vol == 88) code = "hNQ7AAAAIAAJ";
				else if (vol == 89) code = "5U8LAAAAYAAJ";
				else if (vol == 90) code = "clALAAAAYAAJ";
				else if (vol == 91) code = "y1ALAAAAYAAJ";
				else if (vol == 92) code = "YFELAAAAYAAJ";		// 1922
			}
			else if (reporter == "sw")
			{
				if (vol == 45) code = "XhoLAAAAYAAJ";			// 1898
				else if (vol == 59) code = "3gw8AAAAIAAJ";
				else if (vol == 61) code = "4w08AAAAIAAJ";
				else if (vol == 71) code = "Dho8AAAAIAAJ";
				else if (vol == 72) code = "7xg8AAAAIAAJ";
				else if (vol == 76) code = "4g88AAAAIAAJ";
				else if (vol == 85) code = "QCwLAAAAYAAJ";
				else if (vol == 92) code = "qDELAAAAYAAJ";		// 1906
				else if (vol == 93) code = "A-w7AAAAIAAJ";
				else if (vol == 97) code = "YQk8AAAAIAAJ";
				else if (vol == 98) code = "Ygo8AAAAIAAJ";
				else if (vol == 100) code = "gAw8AAAAIAAJ";
				else if (vol == 102) code = "zw08AAAAIAAJ";
				else if (vol == 107) code = "LYA7AAAAIAAJ";
				else if (vol == 108) code = "cTALAAAAYAAJ";
				else if (vol == 109) code = "2YQ7AAAAIAAJ";
				else if (vol == 111) code = "znw7AAAAIAAJ";
				else if (vol == 113) code = "EnQ7AAAAIAAJ";
				else if (vol == 115) code = "Doc7AAAAIAAJ";
				else if (vol == 116) code = "Uok7AAAAIAAJ";
				else if (vol == 117) code = "eYs7AAAAIAAJ";
				else if (vol == 119) code = "5447AAAAIAAJ";
				else if (vol == 120) code = "KJA7AAAAIAAJ";
				else if (vol == 121) code = "hZE7AAAAIAAJ";
				else if (vol == 122) code = "KJI7AAAAIAAJ";
				else if (vol == 124) code = "lDgLAAAAYAAJ";
				else if (vol == 125) code = "VzkLAAAAYAAJ";
				else if (vol == 127) code = "mXg7AAAAIAAJ";
				else if (vol == 128) code = "Eno7AAAAIAAJ";
				else if (vol == 129) code = "E3o7AAAAIAAJ";
				else if (vol == 131) code = "pH87AAAAIAAJ";
				else if (vol == 132) code = "C4M7AAAAIAAJ";
				else if (vol == 133) code = "VYY7AAAAIAAJ";
				else if (vol == 134) code = "sIU7AAAAIAAJ";
				else if (vol == 135) code = "0YY7AAAAIAAJ";
				else if (vol == 136) code = "fT4LAAAAYAAJ";
				else if (vol == 139) code = "WTELAAAAYAAJ";
				else if (vol == 140) code = "row7AAAAIAAJ";
				else if (vol == 141) code = "DY47AAAAIAAJ";
				else if (vol == 142) code = "gjMLAAAAYAAJ";
				else if (vol == 146) code = "UIM7AAAAIAAJ";
				else if (vol == 147) code = "L4U7AAAAIAAJ";
				else if (vol == 148) code = "VIY7AAAAIAAJ";
				else if (vol == 149) code = "Pok7AAAAIAAJ";
				else if (vol == 150) code = "jHk7AAAAIAAJ";
				else if (vol == 151) code = "KjgLAAAAYAAJ";
				else if (vol == 153) code = "QpE7AAAAIAAJ";
				else if (vol == 154) code = "szsLAAAAYAAJ";
				else if (vol == 155) code = "QtA7AAAAIAAJ";
				else if (vol == 156) code = "19E7AAAAIAAJ";
				else if (vol == 157) code = "hz0LAAAAYAAJ";
				else if (vol == 159) code = "Lfk7AAAAIAAJ";
				else if (vol == 160) code = "v-Q7AAAAIAAJ";
				else if (vol == 161) code = "Z1ALAAAAYAAJ";
				else if (vol == 162) code = "bTULAAAAYAAJ";
				else if (vol == 163) code = "KTYLAAAAYAAJ";
				else if (vol == 164) code = "bv07AAAAIAAJ";
				else if (vol == 165) code = "a307AAAAIAAJ";
				else if (vol == 166) code = "WH07AAAAIAAJ";
				else if (vol == 167) code = "8DgLAAAAYAAJ";
				else if (vol == 168) code = "GYA7AAAAIAAJ";
				else if (vol == 169) code = "YII7AAAAIAAJ";
				else if (vol == 170) code = "ajsLAAAAYAAJ";
				else if (vol == 171) code = "fYU7AAAAIAAJ";
				else if (vol == 172) code = "4zwLAAAAYAAJ";
				else if (vol == 173) code = "Kok7AAAAIAAJ";
				else if (vol == 174) code = "2os7AAAAIAAJ";
				else if (vol == 175) code = "JY07AAAAIAAJ";
				else if (vol == 177) code = "vz8LAAAAYAAJ";
				else if (vol == 178) code = "gvo7AAAAIAAJ";
				else if (vol == 179) code = "U9I7AAAAIAAJ";
				else if (vol == 180) code = "UPw7AAAAIAAJ";
				else if (vol == 181) code = "_fw7AAAAIAAJ";
				else if (vol == 183) code = "s9k7AAAAIAAJ";
				else if (vol == 184) code = "6FkLAAAAYAAJ";
				else if (vol == 185) code = "-do7AAAAIAAJ";
				else if (vol == 186) code = "pts7AAAAIAAJ";
				else if (vol == 187) code = "5HY7AAAAIAAJ";
				else if (vol == 188) code = "sUMLAAAAYAAJ";
				else if (vol == 190) code = "vs47AAAAIAAJ";
				else if (vol == 191) code = "t887AAAAIAAJ";
				else if (vol == 193) code = "rdE7AAAAIAAJ";
				else if (vol == 195) code = "DJE7AAAAIAAJ";
				else if (vol == 196) code = "MY87AAAAIAAJ";
				else if (vol == 197) code = "g407AAAAIAAJ";
				else if (vol == 198) code = "Q4w7AAAAIAAJ";
				else if (vol == 199) code = "hYo7AAAAIAAJ";
				else if (vol == 200) code = "Rog7AAAAIAAJ";
				else if (vol == 201) code = "7oU7AAAAIAAJ";
				else if (vol == 202) code = "roQ7AAAAIAAJ";
				else if (vol == 203) code = "74I7AAAAIAAJ";
				else if (vol == 204) code = "VPo7AAAAIAAJ";
				else if (vol == 205) code = "l2ILAAAAYAAJ";
				else if (vol == 206) code = "edQ7AAAAIAAJ";
				else if (vol == 207) code = "YdU7AAAAIAAJ";
				else if (vol == 208) code = "nVALAAAAYAAJ";
				else if (vol == 210) code = "vNc7AAAAIAAJ";
				else if (vol == 211) code = "Ctg7AAAAIAAJ";
				else if (vol == 212) code = "GkYLAAAAYAAJ";
				else if (vol == 213) code = "jUULAAAAYAAJ";
				else if (vol == 214) code = "kXY7AAAAIAAJ";
				else if (vol == 215) code = "kHc7AAAAIAAJ";
				else if (vol == 216) code = "h3g7AAAAIAAJ";
				else if (vol == 217) code = "l3k7AAAAIAAJ";
				else if (vol == 218) code = "gXo7AAAAIAAJ";
				else if (vol == 219) code = "SXs7AAAAIAAJ";
				else if (vol == 221) code = "AIE7AAAAIAAJ";
				else if (vol == 222) code = "-n07AAAAIAAJ";
				else if (vol == 223) code = "bII7AAAAIAAJ";
				else if (vol == 224) code = "V4M7AAAAIAAJ";
				else if (vol == 225) code = "-oU7AAAAIAAJ";
				else if (vol == 226) code = "D4c7AAAAIAAJ";
				else if (vol == 227) code = "XIg7AAAAIAAJ";
				else if (vol == 228) code = "NYk7AAAAIAAJ";
				else if (vol == 229) code = "m4o7AAAAIAAJ";
				else if (vol == 230) code = "Uow7AAAAIAAJ";
				else if (vol == 231) code = "8Y07AAAAIAAJ";
				else if (vol == 232) code = "W_w7AAAAIAAJ";
				else if (vol == 233) code = "QdM7AAAAIAAJ";
				else if (vol == 234) code = "6VMLAAAAYAAJ";
				else if (vol == 235) code = "oVQLAAAAYAAJ";
				else if (vol == 236) code = "8UcLAAAAYAAJ";
				else if (vol == 237) code = "is87AAAAIAAJ";
				else if (vol == 238) code = "6ZA7AAAAIAAJ";
				else if (vol == 239) code = "NI87AAAAIAAJ";
				else if (vol == 240) code = "zs47AAAAIAAJ";
				else if (vol == 241) code = "3EoLAAAAYAAJ";
				else if (vol == 242) code = "TM87AAAAIAAJ";		// 1922
			}

			return code;
		}


		//**********************************************************************
		// ArabicToRoman()
		//**********************************************************************
		public static string ArabicToRoman(int nr)
		{
			String sArabicToRoman = "";
			if (nr >= 889)
			{
				sArabicToRoman = "M" + ArabicToRoman(nr - 1000);
			}
			else if (nr >= 389)
			{
				sArabicToRoman = "D" + ArabicToRoman((nr - 500));
			}
			else if (nr >= 89)
			{
				sArabicToRoman = "C" + ArabicToRoman((nr - 100));
			}
			else if (nr >= 39)
			{
				sArabicToRoman = "L" + ArabicToRoman((nr - 50));
			}
			else if (nr >= 9)
			{
				sArabicToRoman = "X" + ArabicToRoman((nr - 10));
			}
			else if (nr >= 4)
			{
				sArabicToRoman = "V" + ArabicToRoman((nr - 5));
			}
			else if (nr >= 1)
			{
				sArabicToRoman = "I" + ArabicToRoman((nr - 1));
			}
			else if (nr <= -889)
			{
				sArabicToRoman = "M" + ArabicToRoman(nr + 1000);
			}
			else if (nr <= -389)
			{
				sArabicToRoman = "D" + ArabicToRoman(nr + 500);
			}
			else if (nr <= -89)
			{
				sArabicToRoman = "C" + ArabicToRoman(nr + 100);
			}
			else if (nr <= -39)
			{
				sArabicToRoman = "L" + ArabicToRoman(nr + 50);
			}
			else if (nr <= -9)
			{
				sArabicToRoman = "X" + ArabicToRoman(nr + 10);
			}
			else if (nr <= -4)
			{
				sArabicToRoman = "V" + ArabicToRoman(nr + 5);
			}
			else if (nr <= -1)
			{
				sArabicToRoman = "I" + ArabicToRoman(nr + 1);
			}

			return sArabicToRoman;
		}

	}
}

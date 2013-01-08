using System;
using System.Web.UI;

namespace JureekaCitationResolver
{
	public partial class Intl : System.Web.UI.Page
	{
		private void Page_Load(object sender, System.EventArgs e)
		{
			string docType = Convert.ToString(Request.QueryString["doc"]);
			
			
			// INTERNATIONAL LEGAL MATERIALS
			
			// United Nations Charter (last checked 11/18/10)
			
			if (docType == "UNCharter")
			{
				string art = Convert.ToString(Request.QueryString["art"]);
				if (art == "undefined")
				{
					RedirectLib.PageRedirect(this,"http://www.un.org/en/documents/charter/index.shtml", "UN Charter");
				}
				else
				{
					RedirectLib.PageRedirect(this,"http://www.yale.edu/lawweb/avalon/un/unchart.htm#art" + art, "UN Charter, art. " + art);
				}
			}
			
			// Decisions of the International Court of Justice (ICJ) (last checked 7/17/11)
			
			if (docType == "ICJ")
			{
				// http://www.worldlii.org/int/cases/ICJ/2004/52.html
				//string caseNo = Convert.ToString(Request.QueryString["case"]);
				
				int year = Convert.ToInt32(Request.QueryString["year"]);
				RedirectLib.PageRedirect(this,"http://www.worldlii.org/int/cases/ICJ/" + year + "/", "");
				//RedirectLib.PageRedirect(this,"http://www.worldlii.org/int/cases/ICJ/" + year + "/" + caseNo + ".html", "");
			}
			
			// Decisions of the Permanent Court of International Justice (predecessor to ICJ) (last checked 11/18/10)
			
			else if (docType == "PCIJ")
			{
				string series = Convert.ToString(Request.QueryString["ser"]);
				series=series.Replace("/","");
				series=series.ToLower();

				string no = Convert.ToString(Request.QueryString["no"]);
				if (no.Length == 1)
					no = "0" + no; 

				if (series == "a")
				{
					RedirectLib.PageRedirect(this,"http://www.icj-cij.org/pcij/index.php?p1=9&p2=1&p3=0&co=A" + no, "PCIJ Ser. A");
				}
				else if (series == "b")
				{
					RedirectLib.PageRedirect(this,"http://www.icj-cij.org/pcij/index.php?p1=9&p2=2&p3=1&co=B" + no, "PCIJ Ser. B");
				}
				else if (series == "ab")
				{
					RedirectLib.PageRedirect(this,"http://www.icj-cij.org/pcij/index.php?p1=9&p2=3&p3=2&co=A/B" + no, "PCIJ Ser. AB");
				}
				else
				{
					RedirectLib.PageRedirect(this,"http://www.icj-cij.org/pcij/index.php?p1=9", "PCIJ");
				}
			}
			
			// European Community Reports (needs to be checked)
			
			else if (docType == "ECR")
			{
				string year = Convert.ToString(Request.QueryString["year"]);
				string page = Convert.ToString(Request.QueryString["page"]);
				string part = Convert.ToString(Request.QueryString["part"]);
				string cite = "[" + year + "] ECR-" + part + " " + page;

				if (part == "II")
				{
					RedirectLib.PageRedirect(this,"http://europa.eu.int/eur-lex/lex/Result.do?T1=" + year + "&T2=" + page + "&T3=V2&RechType=RECH_recueil&Submit=Search", cite);
				}
				else
				{
					RedirectLib.PageRedirect(this,"http://europa.eu.int/eur-lex/lex/Result.do?T1=" + year + "&T2=" + page + "&T3=V1&RechType=RECH_recueil&Submit=Search", cite);
				}
			}
			
			// European Court of Human Rights (last checked 11/18/10)
			
			else if (docType == "ECtHR")
			{
				RedirectLib.PageRedirect(this,"http://cmiskp.echr.coe.int/tkp197/search.asp?skin=hudoc-en", "Eur.Ct.H.R.");
			}
			
			// Official Journal of the European Community (needs to be checked)
			
			else if (docType == "OJEU")
			{
				int year = Convert.ToInt32(Request.QueryString["year"]);
				string series = Convert.ToString(Request.QueryString["ser"]);
				string issue = Convert.ToString(Request.QueryString["issue"]);
				string page = Convert.ToString(Request.QueryString["page"]);
				string cite = year + " O.J. (" + series + " " + issue + ") " + page;

				if (year > 1997)
				{
					if (issue.Length == 1)
					{
						issue = "00" + issue;
					}
					else if (issue.Length == 2)
					{
						issue = "0" + issue;
					}

					RedirectLib.PageRedirect(this,"http://eur-lex.europa.eu/JOHtml.do?uri=OJ:" + series + ":" + year + ":" + issue + ":SOM:EN:HTML", cite);
				}
				else
				{
					series=series.ToLower();
					RedirectLib.PageRedirect(this,"http://eur-lex.europa.eu/Result.do?aaaa=" + year + "&mm=&jj=&type=" + series + "&nnn=" + issue + "&pppp=" + page + "&RechType=RECH_reference_pub&Submit=Search", cite);
				}
			}
			
			// Inter-American Court of Human Rights (needs to be checked)
			
			else if (docType == "IACtHR")
			{
				string ser = Convert.ToString(Request.QueryString["ser"]);
				string no = Convert.ToString(Request.QueryString["no"]);
				string cite = "IACtHR, Ser. " + ser + ", no. " + no;

				if (no.Length == 1)
					no = "0" + no;
				if (ser == "A")
					RedirectLib.PageRedirect(this,"http://www.corteidh.or.cr/docs/opiniones/seriea_" + no + "_ing.pdf", cite);
				if (ser == "C")
					RedirectLib.PageRedirect(this,"http://www.corteidh.or.cr/docs/casos/articulos/seriec_" + no + "_ing.pdf", cite);
			}
			
			// UN General Assembly Resolutions (needs to be checked)
			
			else if (docType == "UNGARes")
			{
				int session = Convert.ToInt32(Request.QueryString["session"]);
				string cite = "UN G.A. Res. " + session;

				if (session < 36)
					RedirectLib.PageRedirect(this,"http://www.un.org/documents/ga/res/" + session + "/ares" + session + ".htm", cite);
				else if (session < 52)
					RedirectLib.PageRedirect(this,"http://www.un.org/Depts/dhl/res/resa" + session + ".htm", cite);
				else if (session < 62)
					RedirectLib.PageRedirect(this,"http://www.un.org/Depts/dhl/resguide/r" + session + ".htm", cite);
				else
					RedirectLib.PageRedirect(this,"http://www.un.org/ga/" + session + "/resolutions.shtml", cite);
			}
			
			// United Nations documents (needs to be checked)
			
			else if (docType == "UNDoc")
			{
				string doc = Convert.ToString(Request.QueryString["docsymbol"]);
				doc=doc.TrimEnd('.');
				doc=doc.Replace("/","%2F");
				RedirectLib.PageRedirect(this,"http://unbisnet.un.org:8080/ipac20/ipac.jsp?menu=search&aspect=power&npp=50&ipp=20&spp=20&profile=bibga&ri=7&source=%7E%21horizon&index=.UD&term=%22" + doc + "%22&x=18&y=13&aspect=power", "U.N. Doc. " + doc);
				//UN Doc coding guide: http://www.un.org/Depts/dhl/resguide/symbol.htm
			}
			
			// World Trade Organization documents (needs to be checked)
			
			else if (docType == "WTODoc")
			{
				string doc = Convert.ToString(Request.QueryString["docsymbol"]);
				doc=doc.TrimEnd('.');
				doc=doc.Replace("/","%2F");
				RedirectLib.PageRedirect(this,"http://docsonline.wto.org/gen_searchResult.asp?searchmode=simple&c2=%40meta_Symbol&c3=%40meta_Title&c4=%40Doc_Date&o4=%3E%3D&c5=%40Doc_Date&o5=%3C%3D&c6=%40meta_Serial_Num&c8=%40Derestriction_Date&c9=%40Derestriction_Date&q0=&q4=&q5=&q8=&q9=&q2=" + doc + "&q3=&q6=&countries=&q1=&multiparts=on&scndformat=off&ct=DDFEnglish%2CDDFFrench%2CDDFSpanish&search=Search&searchtype=simple", "WT/" + doc);
			}
			
			// International Labor Oranization documents (needs to be checked)
			
			else if (docType == "ILO")
			{
				string conv = Convert.ToString(Request.QueryString["conv"]);
				if (conv.Length == 1)
					conv = "00" + conv;
				else if (conv.Length == 2)
					conv = "0" + conv;

				RedirectLib.PageRedirect(this,"http://www.ilo.org/ilolex/cgi-lex/convde.pl?C" + conv, "ILO Conv. " + conv);
			}
			
			// Reports of International Arbitral Awards (last checked 11/18/10)
			
			else if (docType == "RIAA")
			{
				int vol = Convert.ToInt32(Request.QueryString["vol"]);
				RedirectLib.PageRedirect(this,"http://untreaty.un.org/cod/riaa/vol_" + RedirectLib.ArabicToRoman(vol) + ".htm", "RIAA " + vol);
				//Homepage: http://www.un.org/law/riaa/
			}
			
			
			
			// AUSTRALIA  (These need to be fixed)

			if (docType == "AustraliaCLR")
			{
				string cite = Convert.ToString(Request.QueryString["cite"]);
				RedirectLib.PageRedirect(this,"http://www.austlii.edu.au/cgi-bin/sinosrch.cgi?method=boolean&meta=%2Fau&mask_path=au%2Fcases%2Fcth%2FHCA&mask_world=&query=%22" + cite + "%22&results=20&submit=Search&rank=on&callback=off&legisopt=&view=relevance&max=", cite);
			}

			
			
			// CANADA (These need to be fixed)
			
			if (docType == "CanadaFedCases")
			{
				string vol = Convert.ToString(Request.QueryString["vol"]);
				string rptr = Convert.ToString(Request.QueryString["rptr"]);
				string page = Convert.ToString(Request.QueryString["page"]);
				string citation = vol + " " + rptr + " " + page;

				string url = "http://www.canlii.org/eliisa/search.do?language=en&searchTitle=Federal&searchPage=eliisa%2FmainPageSearch.vm&text=&id=%22" + vol + "+" + rptr + "+" + page + "%22&caselaw=courts";
				RedirectLib.PageRedirect(this,url,citation);
				
			}
			else if (docType == "CanadaStatutes" || docType == "Regs")
			{
				string cite = Convert.ToString(Request.QueryString["cite"]);
				string url = "http://www.canlii.org/eliisa/search.do?language=en&searchTitle=Federal&searchPage=eliisa%2FjurisdictionSearch.vm&jurisdiction=ca&text=&id=%22" + cite + "%22&legislation=legislation";
				RedirectLib.PageRedirect(this,url,cite);
			}
			else if (docType == "CanadaConst")
			{
				string year = Convert.ToString(Request.QueryString["year"]);
				string cite = "Canadian Constitution Act, " + year;
				if (year == "1867")
					RedirectLib.PageRedirect(this,"http://www.canlii.org/en/ca/const/const1867.html", cite);
				if (year == "1982")
					RedirectLib.PageRedirect(this,"http://www.canlii.org/en/ca/const/const1982.html", cite);
			}

		
			
			// UNITED KINGDOM (last (quickly) checked 11/18/10)

			else if (docType == "UKAppealsCases" || docType == "UKHL" || docType == "UKPC" || docType == "UKQB" || docType == "EWCA" || docType == "EWHC" || docType == "WLR" || docType == "AllER" || docType == "IESC" || docType == "NICA" || docType == "IR")
			{
				string cite = Convert.ToString(Request.QueryString["cite"]);
				string url = "http://www.bailii.org/cgi-bin/find_by_citation.cgi?citation=" + cite;

				RedirectLib.PageRedirect(this,url,cite);
			}
			
			// Else, redirect to upgrade message...
			Response.Redirect("http://www.jureeka.net/Jureeka/Default.aspx");
		}
	
		
		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion

	}
}
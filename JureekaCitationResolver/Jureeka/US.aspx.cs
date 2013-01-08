using System;

namespace JureekaCitationResolver
{
	/// <summary>
	/// Summary description for US.
	/// </summary>
	public partial class US : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label1;
		
		protected string errorMsg = "<p>Sorry to have inconvenienced you.  We have not yet found a free version of that source." +
			"</p><p>Please make sure that you're using the latest version of Jureeka for <a href='https://addons.mozilla.org/en-US/firefox/addon/jureeka-6636/'>Firefox</a> or <a href='https://chrome.google.com/webstore/detail/ediidjmindkcaflpfjgabfaibhngadbb'>Chrome</a>";


//		private void Page_Load(object sender, System.EventArgs e)
//		{
//			try
//			{
//				SendToSource();
//			}
//			catch
//			{
//				Response.Redirect("~/Default.aspx");
//			}
//		}
//
//		private void SendToSource()
		
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Get querystring values
			string docType = Convert.ToString(Request.QueryString["doc"]);			
			string cite = Convert.ToString(Request.QueryString["cite"]);
			
			string sec = "";
			try { sec = Convert.ToString(Request.QueryString["sec"]); } catch { sec = ""; }
			
			
			// U.S. and State Constitutions (need to be rechecked)
			
			if (docType == "Constitutions")
			{
				string juris = Convert.ToString(Request.QueryString["juris"]);
//				string part = Convert.ToString(Request.QueryString["part"]);
//				string art = Convert.ToString(Request.QueryString["art"]);
//				string sec = Convert.ToString(Request.QueryString["sec"]);

				juris=juris.ToLower().Replace(".","").Replace(" ","");
				
				if (juris == "us")
					RedirectLib.PageRedirect(this,"http://topics.law.cornell.edu/constitution", "U.S. Const.");
				else if (juris == "ala")
					RedirectLib.PageRedirect(this,"http://www.legislature.state.al.us/CodeOfAlabama/Constitution/1901/Constitution1901_toc.htm", "Ala. Const.");
				else if (juris == "alaska")
					RedirectLib.PageRedirect(this,"http://ltgov.state.ak.us/constitution.php", "Alaska Const.");
				else if (juris == "ariz")
					RedirectLib.PageRedirect(this,"http://www.azleg.gov/Constitution.asp", "Ariz. Const.");
				else if (juris == "ark")
					RedirectLib.PageRedirect(this,"http://www.arkleg.state.ar.us/data/constitution/ArkansasConstitution1874.pdf", "Ark. Const.");
				else if (juris == "cal")
					RedirectLib.PageRedirect(this,"http://www.leginfo.ca.gov/const-toc.html", "Cal. Const.");
				else if (juris == "colo")
					RedirectLib.PageRedirect(this,"http://www.i2i.org/Publications/ColoradoConstitution/iscolocn.htm#Table%20of%20Contents", "Colo. Const.");
				else if (juris == "conn")
					RedirectLib.PageRedirect(this,"http://www.megalaw.com/ct/ctconstitution.php", "Conn. Const.");
				else if (juris == "del")
					RedirectLib.PageRedirect(this,"http://www.delcode.state.de.us/constitution/index.htm", "Del. Const.");
				else if (juris == "fla")
					RedirectLib.PageRedirect(this,"http://www.leg.state.fl.us/Statutes/index.cfm?Mode=Constitution&Submenu=3&Tab=statutes", "Fla. Const.");
				else if (juris == "ga")
					RedirectLib.PageRedirect(this,"http://sos.georgia.gov/elections/constitution_2007.pdf", "Ga. Const.");
				else if (juris == "haw")
					RedirectLib.PageRedirect(this,"http://www.hawaii.gov/lrb/con/", "Haw. Const.");
				else if (juris == "idaho")
					RedirectLib.PageRedirect(this,"http://www3.state.id.us/idstat/const/constTOC.html", "Idaho Const.");
				else if (juris == "ill")
					RedirectLib.PageRedirect(this,"http://www.ilga.gov/commission/lrb/conmain.htm", "Ill. Const.");
				else if (juris == "ind")
					RedirectLib.PageRedirect(this,"http://www.law.indiana.edu/uslawdocs/inconst.html", "Ind. Const.");
				else if (juris == "iowa")
					RedirectLib.PageRedirect(this,"http://www.legis.state.ia.us/Constitution.html", "Iowa Const.");
				else if (juris == "kan")
					RedirectLib.PageRedirect(this,"http://www.kslib.info/constitution/index.html", "Kan. Const.");
				else if (juris == "ky")
					RedirectLib.PageRedirect(this,"http://www.lrc.state.ky.us/legresou/constitu/intro.htm", "Ky. Const.");
				else if (juris == "la")
					RedirectLib.PageRedirect(this,"http://senate.legis.state.la.us/Documents/Constitution/", "La. Const.");
				else if (juris == "me")
					RedirectLib.PageRedirect(this,"http://janus.state.me.us/legis/const/", "Me. Const.");
				else if (juris == "md")
					RedirectLib.PageRedirect(this,"http://www.msa.md.gov/msa/mdmanual/43const/html/const.html", "Md. Const.");
				else if (juris == "mass")
					RedirectLib.PageRedirect(this,"http://www.mass.gov/legis/const.htm", "Mass. Const.");
				else if (juris == "mich")
					RedirectLib.PageRedirect(this,"http://www.legislature.mi.gov/mileg.aspx?page=getObject&objectName=mcl-Constitution", "Mich. Const.");
				else if (juris == "minn")
					RedirectLib.PageRedirect(this,"http://www.house.leg.state.mn.us/cco/rules/mncon/preamble.htm", "Minn. Const.");
				else if (juris == "miss")
					RedirectLib.PageRedirect(this,"http://www.mscode.com/msconst/", "Miss. Const.");
				else if (juris == "mo")
					RedirectLib.PageRedirect(this,"http://www.moga.mo.gov/const/moconstn.htm", "Mo. Const.");
				else if (juris == "mont")
					RedirectLib.PageRedirect(this,"http://courts.mt.gov/library/72constit.pdf", "Mont. Const.");
				else if (juris == "neb")
					RedirectLib.PageRedirect(this,"http://uniweb.legislature.ne.gov/QS/laws.php?mode=show_con", "Neb. Const.");
				else if (juris == "nev")
					RedirectLib.PageRedirect(this,"http://www.leg.state.nv.us/const/nvconst.html", "Nev. Const.");
				else if (juris == "nh")
					RedirectLib.PageRedirect(this,"http://www.nh.gov/constitution/constitution.html", "N.H. Const.");				
				else if (juris == "nj")
					RedirectLib.PageRedirect(this,"http://www.njleg.state.nj.us/lawsconstitution/constitution.asp", "N.J. Const.");
				else if (juris == "nm")
					RedirectLib.PageRedirect(this,"http://www.conwaygreene.com/nmsu/lpext.dll?f=FifLink&t=document-frame.htm&l=query&iid=3079d651.7afce11c.0.0&q=%5BGroup%20%27nmc%20annotated%27%5D", "N.M. Const.");
				else if (juris == "ny")
					RedirectLib.PageRedirect(this,"http://www.senate.state.ny.us/lbdcinfo/senconstitution.html", "N.Y. Const.");
				else if (juris == "nc")
					RedirectLib.PageRedirect(this,"http://www.ncga.state.nc.us/Legislation/constitution/ncconstitution.html", "N.C. Const.");
				else if (juris == "nd")
					RedirectLib.PageRedirect(this,"http://www.legis.nd.gov/constitution/const.pdf", "N.D. Const.");
				else if (juris == "ohio")
					RedirectLib.PageRedirect(this,"http://www.legislature.state.oh.us/constitution.cfm", "Ohio Const.");
				else if (juris == "okla")
					RedirectLib.PageRedirect(this,"http://oklegal.onenet.net/okcon/index.html", "Okla. Const.");
				else if (juris == "or" || juris == "ore")
					RedirectLib.PageRedirect(this,"http://bluebook.state.or.us/state/constitution/constitution.htm#web", "Or. Const.");
				else if (juris == "pa")
					RedirectLib.PageRedirect(this,"http://www.paconstitution.duq.edu/PAC_C_CURRENT.html", "Pa. Const.");
				else if (juris == "ri")
					RedirectLib.PageRedirect(this,"http://www.rilin.state.ri.us/gen_assembly/RiConstitution/riconst.html", "R.I. Const.");
				else if (juris == "sc")
					RedirectLib.PageRedirect(this,"http://www.scstatehouse.net/scconstitution/scconst.htm", "S.C. Const.");
				else if (juris == "sd")
					RedirectLib.PageRedirect(this,"http://legis.state.sd.us/statutes/Constitution.aspx", "S.D. Const.");
				else if (juris == "tenn")
					RedirectLib.PageRedirect(this,"http://www.tncrimlaw.com/law/constit/index.html", "Tenn. Const.");
				else if (juris == "tex")
					RedirectLib.PageRedirect(this,"http://tlo2.tlc.state.tx.us/txconst/toc.html", "Tex. Const.");
				else if (juris == "utah")
					RedirectLib.PageRedirect(this,"http://law.justia.com/utah/constitution/", "Utah Const.");
				else if (juris == "vt")
					RedirectLib.PageRedirect(this,"http://law.justia.com/vermont/constitution/", "Vt. Const.");
				else if (juris == "va")
					RedirectLib.PageRedirect(this,"http://law.justia.com/virginia/constitution/", "Va. Const.");
				else if (juris == "wash")
					RedirectLib.PageRedirect(this,"http://law.justia.com/washington/constitution/", "Wash. Const.");
				else if (juris == "w va")
					RedirectLib.PageRedirect(this,"http://www.legis.state.wv.us/WVCODE/WV_CON.cfm","");
				else if (juris == "wis")
					RedirectLib.PageRedirect(this,"http://nxt.legis.state.wi.us/nxt/gateway.dll?f=templates&fn=default.htm&vid=WI:Default&d=wiscon&jd=top", "Wis. Const.");
				else if (juris == "wyo")
					RedirectLib.PageRedirect(this,"http://legisweb.state.wy.us/statutes/constitution.aspx?file=titles/Title97/Title97.htm", "Wyo. Const.");
			}
			
			// U.S. Supreme Court cases (last checked 11/18/10)
			
			else if (docType == "U.S.")		
			{
				int vol = Convert.ToInt32(Request.QueryString["vol"]);
				int page = Convert.ToInt32(Request.QueryString["page"]);
				string pinpoint = Convert.ToString(Request.QueryString["pinpoint"]);

				//vols 1-542
				if (vol < 543)
				{
					if (pinpoint != "undefined")
						RedirectLib.PageRedirect(this,"http://supreme.justia.com/us/" + vol + "/" + page + "/case.html#" + pinpoint, "");
					else
						RedirectLib.PageRedirect(this,"http://supreme.justia.com/us/" + vol + "/" + page + "/case.html", "");
				}
				//vols 543-
				else 
				{
					RedirectLib.PageRedirect(this,"http://supreme.justia.com/us/" + vol + "/index.html", "");
				}
			}
			
			// U.S. Code (last checked 11/18/10)
			
			else if (docType == "U.S.C.")
			{
				string v = Convert.ToString(Request.QueryString["vol"]);
				string vol = "";
				if (v.Length == 1)
					vol = "0" + v; 
				else
					vol = v;

				string sec1 = RedirectLib.AddPrecedingZeros(sec, 8);

				string s2 = Convert.ToString(Request.QueryString["sec2"]);
				string sec2 = "----";
				if (s2 != null)
				{
					if (s2.Length == 1)
						sec2 = "---" + s2; 
					else if (s2.Length == 2)
						sec2 = "--" + s2; 
					else if (s2.Length == 3)
						sec2 = "-" + s2; 
					else
						sec2 = "----";
				}

				string s3 = Convert.ToString(Request.QueryString["sec3"]);
				string sec3 = "000";
				if (s3 != "undefined")
				{
					if (s3.Length == 1)
						sec3 = "00" + s3; 
					else if (s3.Length == 2)
						sec3 = "0" + s3;
					else
						sec3 = s3;
				}

				string s4 = Convert.ToString(Request.QueryString["sec4"]);
				string sec4 = "-";
				if (s4 != "undefined")
				{
					sec4 = s4;
				}

				RedirectLib.PageRedirect(this,"http://www.law.cornell.edu/uscode/html/uscode" + vol + "/usc_sec_" + vol + "_" + sec1 + sec2 + sec3 + sec4 + ".html", "");
			}
			
			// Code of Federal Regulations (last checked 11/18/10)
			
			else if (docType == "CFR")		
			{
				string t = Convert.ToString(Request.QueryString["title"]);
				string title = "";
				if (t.Length == 1)
					title = "0" + t; 
				else 
					title = t;
			
				string part = Convert.ToString(Request.QueryString["part"]);

				RedirectLib.PageRedirect(this,"http://ecfr.gpoaccess.gov/cgi/t/text/text-idx?c=ecfr&tpl=/ecfrbrowse/Title" + title + "/" + t + "cfr" + part + "_main_02.tpl", "");
			}
			
			// Federal Register (last checked 11/18/10) 
			
			else if (docType == "FedRegister")
			{
				int vol = Convert.ToInt32(Request.QueryString["vol"]);
				int year = vol + 1935;

				string page = Convert.ToString(Request.QueryString["page"]);
				page=page.Replace(",","");

				RedirectLib.PageRedirect(this,"http://frwebgate.access.gpo.gov/cgi-bin/getpage.cgi?dbname=" + year + "_register&position=all&page=" + page, "");
			}
			
			// Federal Reporters (last checked 11/18/10)
			
			else if (docType == "F1d")
			{
				string vol = Convert.ToString(Request.QueryString["vol"]);
				int v = Convert.ToInt32(Request.QueryString["vol"]);
				string page = Convert.ToString(Request.QueryString["page"]);

				string code = RedirectLib.GetGoogleBooksUrlCode("f", v);
				if (code != "")
					RedirectLib.PageRedirect(this,"http://books.google.com/books?id=" + code + "&printsec=titlepage&as_brr=1&cad=0#PPA" + page + ",M1", vol + " F. " + page);
				else
					RedirectLib.PageRedirect(this,"http://openjurist.org/" + vol + "/f1d/" + page, "");
			}
			else if (docType == "F2d")
			{
				string vol = Convert.ToString(Request.QueryString["vol"]);
				string page = Convert.ToString(Request.QueryString["page"]);
				RedirectLib.PageRedirect(this,"http://cases.justia.com/us-court-of-appeals/F2/" + vol + "/" + page, "");
			}
			else if (docType == "F3d")
			{
				string vol = Convert.ToString(Request.QueryString["vol"]);
				int intVol = Convert.ToInt32(Request.QueryString["vol"]);
				string page = Convert.ToString(Request.QueryString["page"]);

				if (intVol <= 491)
				{
					RedirectLib.PageRedirect(this,"http://cases.justia.com/us-court-of-appeals/F3/" + vol + "/" + page, "");
				}
				else
				{
					RedirectLib.PageRedirect(this,"http://scholar.google.com/scholar?hl=en&num=1&q=%22" + vol + "+F.3d+" + page + "%22&btnG=Search&as_sdt=2003&as_ylo=&as_vis=0", "");
				}
			}
			else if (docType == "FedSupp")
			{
				
				SendToGoogleScholarCase(cite, "7fffffffffffffff0000000000000000000000000000000f000001ffffffec00000000000000000000000000000000004");
			}
			
			// Federal Rules (last checked 11/18/10)
			
			else if (docType == "FRCP")
			{
				string rule = Convert.ToString(Request.QueryString["rule"]);
				rule = rule.Replace("%20","");
				rule = rule.Replace(" ","");

				if (rule != "undefined")
				{
					RedirectLib.PageRedirect(this,"http://www.law.cornell.edu/rules/frcp/Rule" + rule + ".htm", "FRCP " + rule);
				}
				else
				{
					RedirectLib.PageRedirect(this,"http://www.law.cornell.edu/rules/frcp", "FRCP");
				}
			}
			else if (docType == "FRE")
			{
				string rule = Convert.ToString(Request.QueryString["rule"]);
				rule = rule.Replace("%20","");
				rule = rule.Replace(" ","");

				if (rule != "undefined")
				{
					RedirectLib.PageRedirect(this,"http://www.law.cornell.edu/rules/fre/rules.htm#Rule" + rule, "FRE " + rule);
				}
				else
				{
					RedirectLib.PageRedirect(this,"http://www.law.cornell.edu/rules/fre/", "FRE");
				}
			}
			else if (docType == "FRCrimP")
			{
				string rule = Convert.ToString(Request.QueryString["rule"]);
				string rD = Convert.ToString(Request.QueryString["ruleDec"]);
	
				string ruleDecimal = "";
				if (rD != "undefined")
					ruleDecimal = "_" + rD;

				if (rule != "undefined")
				{
					RedirectLib.PageRedirect(this,"http://www.law.cornell.edu/rules/frcrmp/Rule" + rule + ruleDecimal + ".htm", "Fed. R. Crim. Pro. " + rule + ruleDecimal);
				}
				else
				{
					RedirectLib.PageRedirect(this,"http://www.law.cornell.edu/rules/frcrmp/", "Fed. R. Crim. Pro.");
				}
			}
			else if (docType == "FRAP")
			{
				string rule = Convert.ToString(Request.QueryString["rule"]);

				if (rule != "undefined")
				{
					RedirectLib.PageRedirect(this,"http://www.law.cornell.edu/rules/frap/rules.html#Rule" + rule, "Fed. R. App. Pro. " + rule);
				}
				else
				{
					RedirectLib.PageRedirect(this,"http://www.law.cornell.edu/rules/frap/rules.html", "Fed. R. App. Pro.");
				}
			}
			
			// Uniform Commercial Code (last checked 11/18/10)
			
			else if (docType == "UCC")
			{
				string part = Convert.ToString(Request.QueryString["part"]);
				string prov = Convert.ToString(Request.QueryString["prov"]);
	
				if (part != "undefined")
				{
					RedirectLib.PageRedirect(this,"http://www.law.cornell.edu/ucc/" + part + "/article" + part + ".htm#s" + part + "-" + prov, "U.C.C. " + part + "-" + prov);
				}
				else
				{
					RedirectLib.PageRedirect(this,"http://www.law.cornell.edu/ucc/", "U.C.C.");
				}
			}				
			
			// U.S. Regional Reporters	

			else if (docType == "RegionalRptrs")
			{
				string reporter = Convert.ToString(Request.QueryString["rptr"]);
				reporter = reporter.ToLower();
				reporter = reporter.Replace(" ","");
				reporter = reporter.Replace(".","");
				
				string vol = Convert.ToString(Request.QueryString["vol"]);
				string page = Convert.ToString(Request.QueryString["page"]);
				int v = Convert.ToInt32(Request.QueryString["vol"]);
	
				if (reporter == "a")
				{
					string code = RedirectLib.GetGoogleBooksUrlCode("a", v);
					if (code != "")
						RedirectLib.PageRedirect(this,"http://books.google.com/books?id=" + code + "&printsec=titlepage&as_brr=1&cad=0#PPA" + page + ",M1", vol + " A. " + page);
						// Alt: http://books.google.com/books?jtp=381&id=tCQLAAAAYAAJ#PPA381,M1
					else
						RedirectLib.PageRedirect(this,"http://scholar.google.com/scholar?hl=en&num=1&q=%22" + vol + "+A+" + page + "%22&btnG=Search&as_sdt=c180c030038004&as_ylo=&as_vis=0", "");
				}
				else if (reporter == "a2d")
				{
					SendToGoogleScholarCase(vol + "+A.+2d+" + page, "c180c030038004");
				}
				else if (reporter == "ne")
				{
					string code = RedirectLib.GetGoogleBooksUrlCode("ne", v);
					if (code != "")
						RedirectLib.PageRedirect(this,"http://books.google.com/books?jtp=" + page + "&id=" + code + "#PPA381,M1", vol + " N.E. " + page);
					else
						SendToGoogleScholarCase(vol + "+N.E.+" + page, "120040c00004");
				}
				else if (reporter == "ne2d")
				{
					SendToGoogleScholarCase(vol + "+N.E.+2d+" + page, "120040c00004");
				}
				else if (reporter == "ne3d")
				{
					SendToGoogleScholarCase(vol + "+N.E.+3d+" + page, "120040c00004");
				}
				else if (reporter == "nw")
				{
					string code = RedirectLib.GetGoogleBooksUrlCode("nw", v);
					if (code != "")
						RedirectLib.PageRedirect(this,"http://books.google.com/books?id=" + code + "&printsec=titlepage&as_brr=1&cad=0#PPA" + page + ",M1", vol + " N.W. " + page);
					else
						SendToGoogleScholarCase(vol + "+N.W.+" + page, "404081181000004");
				}
				else if (reporter == "nw2d")
				{
					SendToGoogleScholarCase(vol + "+N.W.+2d+" + page, "404081181000004");
				}
				else if (reporter == "nw3d")
				{
					SendToGoogleScholarCase(vol + "+N.W.+3d+" + page, "404081181000004");
				}
				else if (reporter == "p")
				{
					string code = RedirectLib.GetGoogleBooksUrlCode("p", v);
					if (code != "")
						RedirectLib.PageRedirect(this,"http://books.google.com/books?id=" + code + "&printsec=titlepage&as_brr=1&cad=0#PPA" + page + ",M1", vol + " P. " + page);
					else
						SendToGoogleScholarCase(vol + "+P.+" + page, "920612802306c04");
				}
				else if (reporter == "p2d")
				{
					SendToGoogleScholarCase(vol + "+P.2d+" + page, "920612802306c04");
				}
				else if (reporter == "p3d")
				{
					SendToGoogleScholarCase(vol + "+P.3d+" + page, "920612802306c04");
				}
				else if (reporter == "se")
				{
					string code = RedirectLib.GetGoogleBooksUrlCode("se", v);
					if (code != "")
						RedirectLib.PageRedirect(this,"http://books.google.com/books?id=" + code + "&printsec=titlepage&as_brr=1&cad=0#PPA" + page + ",M1", vol + " S.E. " + page);
					else
						SendToGoogleScholarCase(vol + "+S.E.+" + page, "282040000080004");
				}
				else if (reporter == "se2d")
				{
					SendToGoogleScholarCase(vol + "+S.E.2d+" + page , "282040000080004");
				}
				else if (reporter == "se3d")
				{
					SendToGoogleScholarCase(vol + "+S.E.3d+" + page, "282040000080004");
				}
				else if (reporter == "so")
				{
					string code = RedirectLib.GetGoogleBooksUrlCode("so", v);
					if (code != "")
						RedirectLib.PageRedirect(this,"http://books.google.com/books?jtp=" + page + "&id=" + code + "#PPA" + page + ",M1", vol + " So. " + page);
					else
						SendToGoogleScholarCase(vol + "+So.+" + page, "4,1,10,19,25");
				}
				else if (reporter == "so2d")
				{
					SendToGoogleScholarCase(vol + "+So.2d+" + page, "4,1,10,19,25");
				}
				else if (reporter == "sw")
				{
					string code = RedirectLib.GetGoogleBooksUrlCode("sw", v);
					if (code != "")
						RedirectLib.PageRedirect(this,"http://books.google.com/books?id=" + code + "&printsec=titlepage&as_brr=1&cad=0#PPA" + page + ",M1", vol + " S.W. " + page);
					else
						SendToGoogleScholarCase(vol + "+S.W.+" + page, "18000404001004");
				}
				else if (reporter == "sw2d")
				{
					SendToGoogleScholarCase(vol + "+S.W.2d+" + page, "18000404001004");
				}
				else if (reporter == "sw3d")
				{
					SendToGoogleScholarCase(vol + "+S.W.3d+" + page, "18000404001004");
				}
				else
				{
					// If all else fails, do a general search on google scholar...
					RedirectLib.PageRedirect(this,"http://scholar.google.com/scholar?hl=en&q=%22" + vol + "+S.W.3d+" + page + "%22&btnG=Search&as_sdt=ffffffffffffe04&as_ylo=&as_vis=0", "");
				}
			}
			
			// MATERIALS FOR SPECIFIC STATES (needs to be updated; cases should go to Google Scholar)
			
			// Alabama (last checked 7/14/11)
			
			else if (docType == "AlabamaCode")
			{
				// http://law.justia.com/codes/alabama/2009/Title13A/Chapter13/13A-13-4.html
				// http://codes.lp.findlaw.com/alcode/13A/13/13A-13-4
				
				string title = Convert.ToString(Request.QueryString["title"]);
				string ch = Convert.ToString(Request.QueryString["ch"]);
				
				string link = "http://law.justia.com/codes/alabama/2009/Title" + title + "/Chapter" + ch + "/" + cite + ".html";
				
				RedirectLib.PageRedirect(this, link, "");
			}
			else if (docType == "AlabamaCases")			// delete 12/31/11
			{
				RedirectLib.PageRedirect(this,"http://scholar.google.com/scholar?hl=en&q=cite&as_sdt=204&as_ylo=&as_vis=0", "Ala. cases");
			}		
			
			// Alaska
			
			else if (docType == "AlaskaStatutes")  // (last checked 7/15/11)
			{
				// This source is from 2007 but allows pinpoint redirects:
				// http://touchngo.com/lglcntr/akstats/Statutes/Title02/Chapter20/Section050.htm
				
				// Prettier and more recent, but the article number is not evident from the citation:
				// http://law.justia.com/codes/alaska/2009/title-13/chapter-13-36/article-04/sec-13-36-235/
				// Alt 1: http://law.justia.com/codes/alaska/2009/title-13/chapter-13-36/
				// Alt 2: http://codes.lp.findlaw.com/akstatutes/11/11.46./04./11.46.460.
				
				string title = Convert.ToString(Request.QueryString["title"]);
				string ch = Convert.ToString(Request.QueryString["ch"]);
				
				string link = "http://touchngo.com/lglcntr/akstats/Statutes/Title" + title + "/Chapter" + ch + "/Section" + sec + ".htm";
				//Alt 1: string link = "http://law.justia.com/codes/alaska/2009/title-" + title + "/chapter-" + title + "-" + ch + "/";
				
				RedirectLib.PageRedirect(this, link, "");
			}
			else if (docType == "AlaskaCode")  // delete 12/31/11 - also, this is misnamed b/c it actually means Alaska Statutes
			{
				RedirectLib.PageRedirect(this,"http://law.justia.com/codes/alaska/2009/", "");
			}
			else if (docType == "AlaskaCases")			// needs volume and page data
			{
				RedirectLib.PageRedirect(this,"http://scholar.google.com/scholar?hl=en&q=cite&btnG=Search&as_sdt=404&as_ylo=&as_vis=0", "Alaska cases");
			}		
			
			// Arizona
			
			else if (docType == "ArizonaStatutes")  // (last checked 7/15/11)
			{
				// http://law.justia.com/codes/arizona/2010/title13/13-301.html
				
				string title = Convert.ToString(Request.QueryString["title"]);

				RedirectLib.PageRedirect(this,"http://law.justia.com/codes/arizona/2010/title" + title + "/" + title + "-" + sec.TrimEnd('.') + ".html", "");
			}			
			else if (docType == "ArizonaCases")
			{
				SendToGoogleScholarCase(cite, "4,3");
			}
			
			// Arkansas
			
			else if (docType == "ArkansasCode")  // (last checked 7/15/11)
			{
				// http://www.offthemarble.com/arkcode/Title27/27-1-103.html
				// http://law.justia.com/codes/arkansas/2010/title-9/subtitle-2/chapter-13/subchapter-3/9-13-301/
				
				string title = Convert.ToString(Request.QueryString["title"]);		
				if (title.Length == 1) title = "0" + title;
				string link = "http://www.offthemarble.com/arkcode/Title" + title + "/" + cite + ".html";
				//string link = "http://law.justia.com/codes/arkansas/2010/title-" + title + "/";
				
				RedirectLib.PageRedirect(this, link, "");
			}	
			else if (docType == "ArkansasCases")
			{
				SendToGoogleScholarCase(cite, "4,4");
			}
			
			// California
			
			else if (docType == "CAcases")
			{
				SendToGoogleScholarCase(cite, "4,5");
			}
			else if (docType == "CalCode")  // (last checked 7/15/11)
			{
				// http://www.leginfo.ca.gov/calaw.html
				// http://codes.lp.findlaw.com/LCsearch.html?entry=bpc+17200&restrict=codes%3Acacode
				
				string vol = Convert.ToString(Request.QueryString["vol"]);
				vol = vol.Replace(" ","").Replace(".","").Replace("&","").Replace("'","").ToLower();

				// Generate search code for each volume.  Options are:
				// bpc, civ, ccp, com, corp, edc, elec, evid, fam, fin, fgc, fac, gov, hnc, hsc, ins, lab, mvc, pen, prob, pcc, prc, puc, rtc, shc, uic, veh, wat, wic
				if (vol == "busprof") vol = "bpc";
				else if (vol == "civproc") vol = "ccp";
				else if (vol == "civil") vol = "civ";
				else if (vol == "educ") vol = "edc";
				else if (vol == "fishgame") vol = "fgc";
				else if (vol.Substring(0,3) == "gov") vol = "gov";
				else if (vol == "harbnav") vol = "hnc";
				else if (vol == "healthsafety") vol = "hsc";
				else if (vol == "labor") vol = "lab";
				else if (vol == "milvet") vol = "mvc";
				else if (vol == "penal") vol = "pen";
				else if (vol == "pubcont") vol = "pcc";
				else if (vol == "pubres") vol = "prc";
				else if (vol == "pubutil") vol = "puc";
				else if (vol == "revtax") vol = "rtc";
				else if (vol == "syshigh") vol = "shc";
				else if (vol == "unempins") vol = "uic";
				else if (vol == "water") vol = "wat";
				else if (vol == "welfinst") vol = "wic";
				
				// http://www.leginfo.ca.gov/cgi-bin/calawquery?codesection=ins&codebody=10741&hits=20
				string link = "http://www.leginfo.ca.gov/cgi-bin/calawquery?codesection=" + vol + "&codebody=" + sec + "&hits=1";
				
				RedirectLib.PageRedirect(this, link, "");
			}
			
			// Colorado
			
			else if (docType == "ColoradoStatutes")  // (last checked 7/15/11)
			{
				// string prov = Convert.ToString(Request.QueryString["prov"]).TrimEnd('.');
				RedirectLib.PageRedirect(this,"http://www.michie.com/colorado/lpext.dll?f=templates&fn=main-h.htm&cp=", ""); 
			}
			
			// Connecticut
			
			else if (docType == "ConnStatutes")  // (last checked 7/15/11)
			{
				string title = Convert.ToString(Request.QueryString["title"]);
				
				// Alt: http://www.cga.ct.gov/2011/pub/title2.htm
				RedirectLib.PageRedirect(this,"http://www.cga.ct.gov/2011/pub/title" + title + ".htm", "");
				
				// Alt: http://law.justia.com/codes/connecticut/2011/title2/
				// RedirectLib.PageRedirect(this,"http://law.justia.com/codes/connecticut/2011/title" + title + "/", "");
			}
			else if (docType == "ConnCases")
			{
				SendToGoogleScholarCase(cite, "4,7");
			}
			
			// Delaware
			
			else if (docType == "DelawareCode")  // (last checked 7/15/11)
			{
				// TODO: some sections are in sub-chapters...
				// http://delcode.delaware.gov/title11/c021/index.shtml#2103 		tit 11, s 2103
				// http://delcode.delaware.gov/title6/c008/sc03/index.shtml#8-302	tit 6, s 8-302
				// http://delcode.delaware.gov/title6/c025/sc07/index.shtml#2572A   tit 6, s 2572A
				// http://delcode.delaware.gov/title11/c083/sc02/index.shtml#8327   tit 11, s 8327
				
				string title = Convert.ToString(Request.QueryString["title"]);
				
				string link = "http://delcode.delaware.gov/title" + title + "/";
				RedirectLib.PageRedirect(this,link, "");
			}
			
			// District of Columbia
			
			else if (docType == "DCCode")  // (last checked 7/15/11)
			{
				RedirectLib.PageRedirect(this,"http://government.westlaw.com/linkedslice/default.asp?SP=DCC-1000", "D.C. Code");
			}
			
			// Florida 
			
			else if (docType == "FloridaStatutes")  // (last checked 7/15/11)
			{
				// http://www.flsenate.gov/Laws/Statutes/2010/112.625 s 112.625
				// http://www.leg.state.fl.us/Statutes/index.cfm?App_mode=Display_Statute&Search_String=&URL=0000-0099/0039/Sections/0039.3031.html s 39.3031
				
				string chap = Convert.ToString(Request.QueryString["ch"]);
				
				// delete 10/1/11
//				string ch = "";
//				if (chap.Length == 1)
//					ch = "000" + chap; 
//				if (chap.Length == 2)
//					ch = "00" + chap; 
//				if (chap.Length == 3)
//					ch = "0" + chap; 
//				else
//					ch = chap;

				string link = "http://www.flsenate.gov/Laws/Statutes/2010/" + chap + "." + sec;
				//string oldlink = "http://www.leg.state.fl.us/statutes/index.cfm?App_mode=Display_Statute&Search_String=&URL=Ch" + ch + "/SEC" + sec + ".HTM";
				
				RedirectLib.PageRedirect(this, link, "");
			}
			
			// Georgia
			
			else if (docType == "GeorgiaCode")  // (last checked 7/15/11)
			{
				// http://law.justia.com/codes/georgia/2010/title-16/chapter-6/16-6-5-1/
				
				string title = Convert.ToString(Request.QueryString["title"]);
				sec = sec.TrimEnd('.').Replace("A","a").Replace(".","-");
								
				string chap = sec.Substring(0, sec.IndexOf("-"));
				
				RedirectLib.PageRedirect(this,"http://law.justia.com/codes/georgia/2010/title-" + title + "/chapter-" + chap + "/" + title + "-" + sec + "/", "");
			}
			else if (docType == "GACases")
			{
				SendToGoogleScholarCase(cite, "4,11");
			}
			
			// Hawaii
			
			else if (docType == "HawaiiStatutes")  // (last checked 7/15/11)
			{
				// http://www.capitol.hawaii.gov/hrscurrent/Vol14_Ch0701-0853/HRS0841/HRS_0841-0003.htm
				// http://www.capitol.hawaii.gov/hrscurrent/Vol14_Ch0701-0853/HRS0844D/HRS_0844D-0072.htm
				
				// TODO: Pinpoints can be done using a switch statement based on this page: http://www.capitol.hawaii.gov/hrscurrent/?
				
				RedirectLib.PageRedirect(this,"http://www.capitol.hawaii.gov/site1/hrs/default.asp", "Haw. Rev. Stat.");
			}
			
			// Idaho
			
			else if (docType == "IdahoCode")  // (last checked 7/15/11)
			{
				// http://www.legislature.idaho.gov/idstat/Title34/T34CH19SECT34-1901.htm 34-1901
				
				string title = Convert.ToString(Request.QueryString["title"]);
				string chap = sec.Substring(0,sec.Length-2);
				
				string link = "http://www.legislature.idaho.gov/idstat/Title" + title + "/T" + title + "CH" + chap + "SECT" + title + "-" + sec + ".htm";
				
				RedirectLib.PageRedirect(this, link, "");
			}
			
			// Illinois
			
			else if (docType == "IllinoisStatutes")  // (last checked 7/15/11)
			{
				// http://www.ilga.gov/legislation/ilcs/documents/031000600K1.htm     310 ILCS 60/1
				// http://www.ilga.gov/legislation/ilcs/documents/072000050K11-25.htm 720 ILCS 5/11‑25
				// http://www.ilga.gov/legislation/ilcs/documents/001000050K1-4.htm    10 ILCS 5/1‑4
				// http://www.ilga.gov/legislation/ilcs/documents/000500200K0.01.htm
				
				string chap = Convert.ToString(Request.QueryString["ch"]);
				chap = RedirectLib.AddPrecedingZeros(chap, 4);
				
				string s1 = Convert.ToString(Request.QueryString["s1"]);
				s1 = RedirectLib.AddPrecedingZeros(s1, 4);
				
				string s2 = Convert.ToString(Request.QueryString["s2"]);
				s2 = s2.Replace("&#8209;","-").TrimEnd(';');
				
				RedirectLib.PageRedirect(this,"http://www.ilga.gov/legislation/ilcs/documents/"+ chap + s1 + "0K"+ s2 + ".htm", "");
			}
			else if (docType == "IllinoisCases")
			{				
				SendToGoogleScholarCase(cite, "4,14");
			}
			
			// Indiana
			
			else if (docType == "IndianaCode")  // (last checked 7/15/11)
			{
				string title = Convert.ToString(Request.QueryString["title"]);
				string art = Convert.ToString(Request.QueryString["art"]);
				
				// http://www.ai.org/legislative/ic/code/title34/ar55/ch10.html#IC34-55-10-2.5
				RedirectLib.PageRedirect(this,"http://www.ai.org/legislative/ic/code/title" + title + "/ar" + art + "/ch" + sec + ".html#IC" + cite, "");
				
				// Alt: http://law.justia.com/codes/indiana/2010/title34/ar55/ch10.html
				// RedirectLib.PageRedirect(this,"http://law.justia.com/codes/indiana/2010/title" + title + "/ar" + art + "/ch" + sec + ".html", "");
			}
			else if (docType == "IndianaCases")
			{
				SendToGoogleScholarCase(cite, "4,15");
			}
			
			// Iowa
			
			else if (docType == "IowaCode")  // (last checked 7/15/11)
			{
				// http://search.legis.state.ia.us/NXT/iclink.htm?c=97b$s=14$doconly=true = 97b.14
				// See http://www.legis.state.ia.us/CreatingPersistentLinksICO.pdf for details
				
				string chap = Convert.ToString(Request.QueryString["ch"]).ToLower();
				RedirectLib.PageRedirect(this, "http://search.legis.state.ia.us/NXT/iclink.htm?c=" + chap + "$s=" + sec, "");
			}
			else if (docType == "IowaCases")
			{
				RedirectLib.PageRedirect(this,"http://www.findlaw.com/11stategov/ia/iaca.html", "Iowa cases");
			}
			
			// Kansas
			
			else if (docType == "KansasStatutes")  // (last checked 7/15/11)
			{	
				// TODO: Fix fails:
				// http://www.kslegislature.org/li/statute/044_000_0000_chapter/044_071_0000_article/044_071_0000b_section/044_071_0000b_k/    44-7,10b
				
				// http://www.kslegislature.org/li/statute/021_000_0000_chapter/021_035_0000_article/021_035_0020_section/021_035_0020_k/    21-3520
				// http://www.kslegislature.org/li/statute/076_000_0000_chapter/076_012a_0000_article/076_012a_0001_section/076_012a_0001_k/ 76-12a01
				// http://www.kslegislature.org/li/statute/044_000_0000_chapter/044_007_0000_article/044_007_0013_section/044_007_0013_k/    44-713
				// http://www.kslegislature.org/li/statute/044_000_0000_chapter/044_007_0000_article/044_007_0013a_section/044_007_0013a_k/  44-7,13a
				// http://www.kslegislature.org/li/statute/084_000_0000_chapter/084_004a_0000_article/084_004a_0405_section/084_004a_0405_k/ 84-4a-405
				// http://www.kslegislature.org/li/statute/084_000_0000_chapter/084_001_0000_article/084_001_0101_section/084_001_0101_k/    84-1-101
				// http://law.justia.com/codes/kansas/2011/Chapter44/Article7/44-7,10b.html
				
				string ch = Convert.ToString(Request.QueryString["ch"]);
				sec = sec.Replace(",","");
				
				string a = sec.Substring(0, sec.Length - 2); // everything except last two digits
				string s = sec.Substring(sec.Length - 2, 2); // last two digits
				if (sec.Contains("-")) 
				{
					a = sec.Substring(0, sec.IndexOf("-"));
					s = sec.Substring(sec.IndexOf("-") + 1, sec.Length - sec.IndexOf("-") - 1);
				}
				
				// Make citation parts the proper length
				
				ch = RedirectLib.AddPrecedingZeros(ch, 3);
				
				a = RedirectLib.AddPrecedingZeros(a, 3); 
				if (!RedirectLib.IsNumber(a)) a = "0" + a;
				
				s = RedirectLib.AddPrecedingZeros(s, 4);
				if (!RedirectLib.IsNumber(s)) s = "0" + s;
				
				// Form link
				string link = "http://www.kslegislature.org/li/statute/"+ch+"_000_0000_chapter/"+ch+"_"+a+"_0000_article/"+ch+"_"+a+"_"+s+"_section/"+ch+"_"+a+"_"+s+"_k/";
				RedirectLib.PageRedirect(this, link, "");
			}
			else if (docType == "KansasCases")
			{
				SendToGoogleScholarCase(cite, "4,17");
			}
			
			// Kentucky
			
			else if (docType == "KentuckyStatutes")  // (last checked 7/15/11)
			{
				// http://law.justia.com/codes/kentucky/2009/011-00/026.html  11.026
				// http://law.justia.com/codes/kentucky/2009/007A00/150.html  7A.150
				// http://law.justia.com/codes/kentucky/2009/061-00/5525.html 61.5525
				
				string ch = Convert.ToString(Request.QueryString["ch"]);
				ch = RedirectLib.AddPrecedingZeros(ch, 3);
				
				string chltr = Convert.ToString(Request.QueryString["chltr"]);
				if (chltr == "undefined") chltr = "-";
				
				// TODO: make sure subchapters are properly captured and redirected
				string subch = Convert.ToString(Request.QueryString["subch"]);
				if (subch == "undefined") subch = "";
				subch = RedirectLib.AddPrecedingZeros(subch, 2);
				
				string link = "http://law.justia.com/codes/kentucky/2009/" + ch + chltr + subch + "/" + sec + ".html";		
				RedirectLib.PageRedirect(this, link, "");
			}
			
			// Louisiana
			
			// TODO:
//			else if (docType == "LouisianaStatutes")  // (last checked 7/16/11)
//			{
//				// http://law.justia.com/codes/louisiana/2009/chc/chc109.html
			    // http://www.legis.state.la.us/lss/tsrssearch.htm
//				
//				string code = Convert.ToString(Request.QueryString["code"]);
//				string art = Convert.ToString(Request.QueryString["art"]);
//				
//				string link = "http://law.justia.com/codes/kentucky/2009/" + ch + chltr + subch + "/" + sec + ".html";		
//				RedirectLib.PageRedirect(this, link, "");
//			}
			
			// Maine
			
			else if (docType == "MaineStatutes")  // (last checked 7/16/11)
			{
				// http://www.mainelegislature.org/legis/statutes/9/title9sec582.html
				
				string title = Convert.ToString(Request.QueryString["title"]);
				RedirectLib.PageRedirect(this,"http://www.mainelegislature.org/legis/statutes/" + title + "/title" + title + "sec" + sec + ".html", "");
			}
			else if (docType == "MaineSupCt")	// DELETE 12/31/11
			{
				int year = Convert.ToInt32(Request.QueryString["year"]);
				int no = Convert.ToInt32(Request.QueryString["no"]);
				RedirectLib.PageRedirect(this,"http://scholar.google.com/scholar?as_q=&num=10&btnG=Search+Scholar&as_epq="+year+"+ME+"+no+"&as_oq=&as_eq=&as_occt=any&as_sauthors=&as_publication=&as_ylo=&as_yhi=&as_sdt=4&as_sdts=20&hl=en", "ME cases");
			}
			
			// Maryland
			
			else if (docType == "MDCases")
			{
				SendToGoogleScholarCase(cite, "4,21");
			}
			// TODO: MD statutory compilations
			
			// Massachusetts
			
			else if (docType == "MassGenLaws")  // TODO: needs to be checked; website slow on 7/16/11
			{
				string ch = Convert.ToString(Request.QueryString["ch"]);
				ch=ch.ToLower();
				sec = sec.ToLower();
				
				//http://www.mass.gov/legis/laws/mgl/40b-20.htm
				RedirectLib.PageRedirect(this,"http://www.mass.gov/legis/laws/mgl/" + ch + "-" + sec + ".htm", "");
				
				// Alt: http://www.malegislature.gov/Laws/GeneralLaws/PartI/TitleI/Chapter1/Section4
			}
			else if (docType == "MassSJCCases") 
			{
				string vol = Convert.ToString(Request.QueryString["vol"]);
				string page = Convert.ToString(Request.QueryString["page"]);
				RedirectLib.PageRedirect(this,"http://masscases.com/cases/sjc/" + vol + "/" + vol + "mass" + page + ".html", vol + " Mass. " + page);
			}
			else if (docType == "MassCtAppCases") 
			{
				string vol = Convert.ToString(Request.QueryString["vol"]);
				string page = Convert.ToString(Request.QueryString["page"]);
				RedirectLib.PageRedirect(this,"http://masscases.com/cases/app/" + vol + "/" + vol + "massappct" + page + ".html", vol + " Mass. App. Ct. " + page);
			}
			else if (docType == "MassCases")  // I prefer masscases.com to google, but keep this as a fallback
			{
				SendToGoogleScholarCase(cite, "4,22");
			}
			
			// Michigan
			
			else if (docType == "MichStatutes")  // last checked 7/16/11
			{
				sec = sec.TrimEnd('.');
				sec = sec.Replace(".","-");
				RedirectLib.PageRedirect(this,"http://www.legislature.mi.gov/(S(4oxzdqvnrkpxtlnpptudk045))/mileg.aspx?page=GetObject&objectname=mcl-" + sec, "");
			}
			else if (docType == "MichCases")
			{
				SendToGoogleScholarCase(cite, "4,23");
			}
			
			// Minnesota
			
			else if (docType == "MinnStatutes")  // last checked 7/16/11
			{
				sec = sec.TrimEnd('.');
				RedirectLib.PageRedirect(this,"https://www.revisor.mn.gov/statutes/?id=" + sec, "");
			}
			else if (docType == "MinnCases")
			{
				SendToGoogleScholarCase(cite, "4,24");
			}
			
			// Mississippi
			
			else if (docType == "MississippiCode")  // last checked 7/16/11
			{
				// http://law.justia.com/codes/mississippi/2010/title-23/17/23-17-3/
				
				string title = Convert.ToString(Request.QueryString["title"]);
				string ch = Convert.ToString(Request.QueryString["ch"]);
				
				RedirectLib.PageRedirect(this,"http://law.justia.com/codes/mississippi/2010/title-"+title+"/"+ch+"/"+title+"-"+ch+"-"+sec+"/", "");
			}
			
			// Montana
			
			else if (docType == "MontanaCode")  // last checked 7/16/11
			{
				// http://data.opi.mt.gov/bills/mca/3/6/3-6-301.htm
				
				string title = Convert.ToString(Request.QueryString["title"]);
				string ch = Convert.ToString(Request.QueryString["ch"]);
				
				RedirectLib.PageRedirect(this,"http://data.opi.mt.gov/bills/mca/"+title+"/"+ch+"/"+title+"-"+ch+"-"+sec+".htm", "");
			}
			
			// Nebraska
			
			else if (docType == "NebraskaStatutes")  // last checked 7/16/11
			{
				// http://nebraskalegislature.gov/laws/statutes.php?statute=7-107
				
				string title = Convert.ToString(Request.QueryString["title"]);
				
				RedirectLib.PageRedirect(this,"http://nebraskalegislature.gov/laws/statutes.php?statute=" + title + "-" + sec, "");
			}
			
			// Nevada
			
			else if (docType == "NevadaStatutes")  // last checked 7/16/11
			{
				// http://www.leg.state.nv.us/NRS/NRS-113.html#NRS113Sec070
				
				string title = Convert.ToString(Request.QueryString["title"]);
				
				RedirectLib.PageRedirect(this,"http://www.leg.state.nv.us/NRS/NRS-" + title + ".html#NRS" + title + "Sec" + sec, "");
			}
			else if (docType == "NevadaCases")
			{
				SendToGoogleScholarCase(cite, "4,29");
			}
			
			// New Hampshire
			
			else if (docType == "NHRevStat")  // last checked 7/16/11 - TODO: currently no regex for this...
			{
				// string title = Convert.ToString(Request.QueryString["title"]);
				
				RedirectLib.PageRedirect(this,"http://www.gencourt.state.nh.us/rsa/html/nhtoc.htm", "");
			}
			
			// New Jersey (last checked 7/16/11)
			
			else if (docType == "NJSA")
			{
				// http://law.justia.com/codes/new-jersey/2009/title-3b/section-3b-12a/3b-12a-4/     NJSA 3B:12A-4
				// http://law.justia.com/codes/new-jersey/2009/title-18a/section-18a-12/18a-12-1-1/  NJSA 18A:12-1.1
				// http://law.justia.com/codes/new-jersey/2009/title-52/section-52-14b/52-14b-1/     NJSA 52:14B-1
				
				string title = Convert.ToString(Request.QueryString["title"]).ToLower();
				sec = sec.ToLower();
				string subsec = Convert.ToString(Request.QueryString["subsec"]).TrimEnd('.').ToLower().Replace(".","-");
				
				RedirectLib.PageRedirect(this,"http://law.justia.com/codes/new-jersey/2009/title-"+title+"/section-"+title+"-"+sec+"/"+title+"-"+sec+"-"+subsec+"/", "");
			}
			else if (docType == "NJAppCases")
			{
				SendToGoogleScholarCase(cite, "4,31");
			}
			else if (docType == "NJAC")
			{
				RedirectLib.PageRedirect(this,"http://www.michie.com/newjersey/lpext.dll?f=templates&fn=main-h.htm&cp", "");
			}
			
			// New Mexico (last checked 7/16/11)
			
			else if (docType == "NMStatutes")
			{
				// http://law.justia.com/codes/new-mexico/2009/chapter-6/article-5a/section-6-5a-1/
				
				string chap = Convert.ToString(Request.QueryString["ch"]).ToLower();
				string art = Convert.ToString(Request.QueryString["art"]).ToLower();
				sec = sec.ToLower();

				RedirectLib.PageRedirect(this,"http://law.justia.com/codes/new-mexico/2009/chapter-"+chap+"/article-"+art+"/section-"+chap+"-"+art+"-"+sec+"/", "");
			}
			else if (docType == "NMReports") // NM Reports
			{
				SendToGoogleScholarCase(cite, "4,32");
			}
			else if (docType == "NMCases")  // Public domain citations
			{
				string year = Convert.ToString(Request.QueryString["year"]);
				year=year.Substring(2,2);
				string no = Convert.ToString(Request.QueryString["no"]);
				string ct = Convert.ToString(Request.QueryString["ct"]);
				ct=ct.ToLower();
				ct=ct.Replace("nm","");

				RedirectLib.PageRedirect(this,"http://www.supremecourt.nm.org./pastopinion/VIEW/" + year + ct + "-" + no + ".html", year + "-" + ct + "-" + no);
			}
			
			// New York
			
			// TODO: NY statutes
			
			else if (docType == "NYCPLR")
			{
				RedirectLib.PageRedirect(this,"http://public.leginfo.state.ny.us/LAWSSEAF.cgi?QUERYTYPE=LAWS+&QUERYDATA=@LLCVP", "NYCPLR");
			}
			else if (docType == "NYcases")
			{
				SendToGoogleScholarCase(cite, "4,33");
			}
			else if (docType == "NYCtApp")  // OBSOLETE - DELETE ON Dec. 31, 2011
			{
				int vol = Convert.ToInt32(Request.QueryString["vol"]);
				string pg = Convert.ToString(Request.QueryString["page"]);

				if (vol < 92)
				{
					string page = "";
					if (pg.Length == 1)
						page = "000" + pg; 
					if (pg.Length == 2)
						page = "00" + pg; 
					if (pg.Length == 3)
						page = "0" + pg; 
					else 
						page = pg;

					RedirectLib.PageRedirect(this,"http://caselaw.lp.findlaw.com/scripts/getcase.pl?court=ny&vol=0" + vol + "&invol=" + page, vol + " N.Y. " + page);
				}
				else
					RedirectLib.PageRedirect(this,"http://www.findlaw.com/11stategov/ny/nyca.html", "N.Y. cases");
			}
			
			// North Carolina (last checked 7/16/11)
			
			else if (docType == "NCstatutes")
			{
				// http://www.ncga.state.nc.us/EnactedLegislation/Statutes/HTML/BySection/Chapter_8/GS_8-13.html
				
				string title = Convert.ToString(Request.QueryString["title"]);
				string ch = Convert.ToString(Request.QueryString["ch"]).TrimEnd('.');

				RedirectLib.PageRedirect(this,"http://www.ncga.state.nc.us/EnactedLegislation/Statutes/HTML/BySection/Chapter_" + title + "/GS_" + title + "-" + ch + ".html", "");
				
			}
			else if (docType == "NCcases") 
			{
				SendToGoogleScholarCase(cite, "4,34");
			}
			
			// North Dakota  (last checked 7/16/11)
			
			else if (docType == "NDCode")
			{
				// http://www.legis.nd.gov/cencode/t30-1c08-1.pdf
				
				string title = Convert.ToString(Request.QueryString["title"]);
				title=title.Replace(".","-");
				if (title.Length == 1)
					title = "0" + title;

				string ch = Convert.ToString(Request.QueryString["ch"]);
				ch=ch.Replace(".","");

				RedirectLib.PageRedirect(this,"http://www.legis.nd.gov/cencode/t" + title + "c" + ch + ".pdf", "");
			}
			else if (docType == "NDNW2dCases")
			{
				int vol = Convert.ToInt32(Request.QueryString["vol"]);
				if (vol > 147)
					RedirectLib.PageRedirect(this,"http://www.court.state.nd.us/opinions/cite/" + vol + ".htm", "N.D. cases, N.W.2d");
				else
					//site doesn't have that volume
					RedirectLib.PageRedirect(this,"http://www.court.state.nd.us/search/opinions.asp", "N.D. cases, N.W.2d");
			}

			// Ohio  (last checked 7/16/11)
			
			else if (docType == "OhioSupCt")
			{
				string year = Convert.ToString(Request.QueryString["year"]); 
				string no = Convert.ToString(Request.QueryString["no"]);
				RedirectLib.PageRedirect(this,"http://www.sconet.state.oh.us/rod/docs/pdf/0/" + year + "/" + year + "-ohio-" + no + ".pdf", year + "-Ohio-" + no);
			}
			else if (docType == "OhioCode")
			{
				sec = sec.TrimEnd('.');
				RedirectLib.PageRedirect(this,"http://codes.ohio.gov/orc/" + sec, "");
			}
			else if (docType == "OhioAdminCode")
			{
				sec = sec.TrimEnd('.');
				sec = sec.Replace(":","%3A");
				RedirectLib.PageRedirect(this,"http://codes.ohio.gov/oac/" + sec, "");
			}
			else if (docType == "OhioCases")
			{
				SendToGoogleScholarCase(cite, "4,36");
			}
			
			// Oklahoma  (last checked 7/10/11)
			
			else if (docType == "OKCases")
			{
				SendToGoogleScholarCase(cite, "4,37"); 
			}
			
			// Oregon  (last checked 7/15/11)
			
			else if (docType == "OregonStatutes")
			{
				string ch = Convert.ToString(Request.QueryString["ch"]);
				string citation = ch + sec;
				
				if (sec == null || sec == "" || sec == "undefined")
				{
					RedirectLib.PageRedirect(this,"http://oregonlaws.org/ors_chapters/" + ch, "");
				}
				else
				{
					RedirectLib.PageRedirect(this,"http://oregonlaws.org/ors/" + citation + ".html", "");
				}
			}
			else if (docType == "ORCases")
			{
				SendToGoogleScholarCase(cite, "4,38");
			}
			
			// Pennsylvania  (last checked 7/16/11)
			
			else if (docType == "PAStatutes")
			{
				// http://www.legis.state.pa.us/cfdocs/legis/LI/consCheck.cfm?txtType=HTM&ttl=18&div=0&chpt=31&sctn=26&subsctn=0  18 PaCS 3126
				// http://www.legis.state.pa.us/cfdocs/legis/LI/consCheck.cfm?txtType=HTM&ttl=18&div=0&chpt=27&sctn=7&subsctn=2   18 PaCS 2707.2
				
				string title = Convert.ToString(Request.QueryString["title"]);
				string ch = Convert.ToString(Request.QueryString["ch"]);
				string subsec = Convert.ToString(Request.QueryString["subsec"]);
				if (subsec == "undefined") subsec = "0";
				
				RedirectLib.PageRedirect(this,"http://www.legis.state.pa.us/cfdocs/legis/LI/consCheck.cfm?txtType=HTM&ttl=" + title + "&div=0&chpt=" + ch + "&sctn=" + sec + "&subsctn=" + subsec, "");
			}
			else if (docType == "PACode")
			{
				string title = Convert.ToString(Request.QueryString["title"]);			
				title = RedirectLib.AddPrecedingZeros(title, 3);

				string ch = Convert.ToString(Request.QueryString["ch"]);

				RedirectLib.PageRedirect(this,"http://www.pacode.com/secure/data/" + title + "/chapter" + ch + "/s" + ch + "." + sec + ".html", "");
			}
			else if (docType == "PACases")
			{				
				SendToGoogleScholarCase(cite, "4,39");
			}
			
			// Puerto Rico  (last checked 7/16/11)
			
			else if (docType == "PRLaws")
			{
				// TODO: Pinpoints?
				RedirectLib.PageRedirect(this,"http://michie.lexisnexis.com/puertorico/lpext.dll?f=templates&fn=main-h.htm&cp=", "Laws of Puerto Rico");
			}
			
			// Rhode Island  (last checked 7/16/11)
			
			else if (docType == "RIGeneralLaws")
			{
				// http://www.rilin.state.ri.us/Statutes/TITLE6A/6A-4.1/6A-4.1-108.HTM  RI Gen Laws 6A-4.1-108
				
				string title = Convert.ToString(Request.QueryString["title"]);
				string ch = Convert.ToString(Request.QueryString["ch"]);
				
				RedirectLib.PageRedirect(this,"http://www.rilin.state.ri.us/Statutes/TITLE"+title+"/"+title+"-"+ch+"/"+title+"-"+ch+"-"+sec+".HTM", "");
			}
			else if (docType == "RICode")
			{
				// TODO: http://law.justia.com/codes/rhode-island/2010/title9/chapter9-26/9-26-4.html
				string title = Convert.ToString(Request.QueryString["title"]);
				RedirectLib.PageRedirect(this,"http://law.justia.com/rhodeisland/codes/title" + title + "/" + title + "-" + sec + ".html", "");
			}
			
			// South Carolina  (last checked 7/16/11)
			
			else if (docType == "SCCodes")
			{
				string title = Convert.ToString(Request.QueryString["title"]);
				string ch = Convert.ToString(Request.QueryString["ch"]);
				sec = sec.TrimEnd('.',',');
				string type = Convert.ToString(Request.QueryString["type"]);
				if (type == "undefined")  // SC Code
				{
					// http://www.scstatehouse.gov/code/t38c065.htm#38-65-90
					
					string chap = RedirectLib.AddPrecedingZeros(ch, 3);
					RedirectLib.PageRedirect(this,"http://www.scstatehouse.gov/code/t" + title + "c" + chap + ".htm#" + title + "-" + ch + "-" + sec, "");
				}
				else  // Regs
				{
					string ti = RedirectLib.AddPrecedingZeros(title, 3);
					RedirectLib.PageRedirect(this,"http://www.scstatehouse.gov/coderegs/c" + ti + ".htm#" + title + "-" + ch, "");
				}
			}
			else if (docType == "SCCases")
			{
				SendToGoogleScholarCase(cite, "4,41");
			}
			
			// South Dakota  (last checked 7/16/11)
			
			else if (docType == "SDCodifiedLaws")
			{
				// http://legis.state.sd.us/statutes/DisplayStatute.aspx?Statute=27A-11A-12&Type=Statute
				
				RedirectLib.PageRedirect(this,"http://legis.state.sd.us/statutes/DisplayStatute.aspx?Statute=" + cite.TrimEnd('.') + "&Type=Statute", "");
			}
			
			// Tennessee  (last checked 7/16/11)
			
			else if (docType == "TNCode")
			{
				RedirectLib.PageRedirect(this,"http://www.michie.com/tennessee/lpext.dll?f=templates&fn=main-h.htm&cp=tncode", "Tenn. Code Ann.");
			}
			
			// TODO: Texas (each volume has a different name)

			
			// Utah  (last checked 7/16/11)
			
			else if (docType == "UTCode")
			{
				// http://le.utah.gov/~code/TITLE07/htm/07_08_001300.htm    7-8-13	
				// http://le.utah.gov/~code/TITLE78/htm/78_34_000400.htm    78-34-4
				// http://le.utah.gov/~code/TITLE53A/htm/53A11_030400.htm   53A-11-304
				// http://le.utah.gov/~code/TITLE15A/htm/15A02_010200.htm   15A-2-102
				
				string title = RedirectLib.AddPrecedingZeros(Convert.ToString(Request.QueryString["title"]), 2);
				string titltr1 = Convert.ToString(Request.QueryString["titltr"]);
				string titltr2 = titltr1;
				if (titltr1 == "undefined") 
				{
					titltr1 = "";
					titltr2 = "_";
				}
				
				string ch = RedirectLib.AddPrecedingZeros(Convert.ToString(Request.QueryString["ch"]), 2);
				string chltr = Convert.ToString(Request.QueryString["chltr"]);
				if (chltr == "undefined") chltr = "_";
				
				sec = RedirectLib.AddPrecedingZeros(sec, 4);		
				string secltr = Convert.ToString(Request.QueryString["secltr"]);
				if (secltr == "undefined") secltr = "00";
				else secltr = RedirectLib.AddPrecedingZeros(secltr, 2);
				
				RedirectLib.PageRedirect(this,"http://le.utah.gov/~code/TITLE" + title + titltr1 +"/htm/" + title + titltr2 + ch + chltr + sec + secltr + ".htm", "");
			}
			else if (docType == "UtahCases")
			{
				SendToGoogleScholarCase(cite, "4,45");
			}
			
			// Vermont  (last checked 7/16/11)
			
			else if (docType == "VTStatutes")
			{
				// TODO: http://www.leg.state.vt.us/statutes/fullsection.cfm?Title=09A&Chapter=002A&Section=00201   9A V.S.A. § 2A-201
				// http://www.leg.state.vt.us/statutes/chapters.cfm?Title=15B
				
				// TODO: clean up:
				string t = Convert.ToString(Request.QueryString["title"]);
				int len = t.Length;
				if (t.EndsWith("A"))
					len = len-1;
				string title = "";
				if (len == 1)
					title = "0" + t; 
				else
					title = t;

				RedirectLib.PageRedirect(this,"http://www.leg.state.vt.us/statutes/chapters.cfm?Title=" + title, "");
			}
			else if (docType == "VTSupremeCt")
			{
				string vol = Convert.ToString(Request.QueryString["vol"]);
				RedirectLib.PageRedirect(this,"http://www.libraries.vermont.gov/supct/" + vol + "/" + vol + ".html", "Vt. S. Ct., vol. " + vol);
			}
			
			// Virginia  (last checked 7/16/11)
			
			else if (docType == "VACode")
			{
				sec = sec.TrimEnd('.');
				RedirectLib.PageRedirect(this,"http://leg1.state.va.us/cgi-bin/legp504.exe?000+cod+" + sec, "");
			}
			else if (docType == "VACases")
			{
				SendToGoogleScholarCase(cite, "4,47");
			}
			
			// Washington (state) (last checked 7/16/11)
			
			else if (docType == "RevCodeWash")
			{
				sec = sec.TrimEnd('.');
				RedirectLib.PageRedirect(this,"http://apps.leg.wa.gov/RCW/default.aspx?cite=" + sec, "");
			}
			else if (docType == "WACases")
			{
				SendToGoogleScholarCase(cite, "4,48");
			}
			
			// TODO: West Virginia code 
			
			// Wisconsin (last checked 7/16/11)
			
			else if (docType == "WisconsinStatutes")
			{
				RedirectLib.PageRedirect(this,"http://nxt.legis.state.wi.us/nxt/gateway.dll?f=templates&fn=default.htm&d=stats&jd=" + cite, "");
			}
			else if (docType == "WICases")
			{
				SendToGoogleScholarCase(cite, "4,50");
			}
			
			// TODO: Wyoming statutes
			
			// Misc cases
			
			else if (docType == "MiscCases")
			{
				string jur = Convert.ToString(Request.QueryString["jur"]);
				jur = jur.Replace(" ","");
				jur = jur.Replace(".","");
				jur = jur.ToLower();
				
				if (jur.StartsWith("haw"))
				{
					cite = cite.Replace("hawaii","haw");
					SendToGoogleScholarCase(cite, "4,12");
				}
				if (jur == "idaho")
				{
					SendToGoogleScholarCase(cite, "4,13");
				}
				if (jur == "mont")
				{
					SendToGoogleScholarCase(cite, "4,27");
				}
				if (jur == "neb" || jur == "nebapp")
				{
					SendToGoogleScholarCase(cite, "4,28");
				}
				if (jur == "nh")
				{
					SendToGoogleScholarCase(cite, "4,30");
				}
				if (jur == "wva")
				{
					SendToGoogleScholarCase(cite, "4,49");
				}
				if (jur == "br")  // bankruptcy - searches all bankruptcy courts and fed circuit courts
				{
					// Use 1f8000000000000000fffffffffffffffe00000000000000000000000000000000000003fffffff00000000000000000004 for just bktcy courts
					SendToGoogleScholarCase(cite, "1f8000000000000000fffffffffffffffe0000000000000000000000000000003ff87fe3fffffff00000000000000000004");
				}
			}
			else if (docType == "PubDomCites")
			{
				string jur = Convert.ToString(Request.QueryString["jur"]);

				if (jur == "ME")
				{
					SendToGoogleScholarCase(cite, "4,20");
				}
				if (jur == "MT")
				{
					SendToGoogleScholarCase(cite, "4,27");
				}
				if (jur == "ND")
				{
					SendToGoogleScholarCase(cite, "4,35");
				}
				if (jur == "SD")
				{
					SendToGoogleScholarCase(cite, "4,42");
				}
				if (jur == "VT")
				{
					SendToGoogleScholarCase(cite, "4,46");
				}
				if (jur == "WY")
				{
					SendToGoogleScholarCase(cite, "4,51");
				}
			}
			
			// U.S. Public Laws (needs to be checked)
			
			else if (docType == "USPubLaws")
			{
				int cong = Convert.ToInt32(Request.QueryString["cong"]);
				string no = Convert.ToString(Request.QueryString["no"]);

				if (cong == 111 && no == "005")
				{
					RedirectLib.PageRedirect(this,"http://frwebgate.access.gpo.gov/cgi-bin/getdoc.cgi?dbname=111_cong_bills&docid=f:h1enr.pdf", cite);
				}
				else if (cong > 105)
				{
					string n = "";
					if (no.Length == 1)
						n = "00" + no; 
					else if (no.Length == 2)
						n = "0" + no; 
					else
						n = no;
					RedirectLib.PageRedirect(this,"http://frwebgate.access.gpo.gov/cgi-bin/getdoc.cgi?dbname=" + cong + "_cong_public_laws&docid=f:publ" + n + "." + cong, "");
				}
				else
				{
					RedirectLib.PageRedirect(this,"http://frwebgate.access.gpo.gov/cgi-bin/getdoc.cgi?dbname=" + cong + "_cong_public_laws&docid=f:publ" + no + "." + cong, "");
				}
			}
			
			// Congressional materials (needs to be checked)
			
			else if (docType == "CongRes")
			{
				string type = Convert.ToString(Request.QueryString["type"]);
				string t = "";
				type=type.ToLower();
				type=type.Replace(".","");
				type=type.Replace(" ","");
				if (type == "s")
					t = "S.";
				else if (type == "hr")
					t = "H.R.";
				else if (type == "hrres" || type == "hres")
					t = "H.Res.";
				else if (type == "sres")
					t = "S.Res.";
				else if (type == "hrconres" || type == "hconres")
					t = "H.Con.Res.";
				else if (type == "sconres")
					t = "S.Con.Res.";
				else if (type == "hrjres" || type == "hjres")
					t = "H.J.Res.";
				else if (type == "sjres")
					t = "S.J.Res.";
				else if (type == "sexecres" || type == "sexres")
					t = "S.+Exec.+Res.";

				string no = Convert.ToString(Request.QueryString["no"]);
				int cong = Convert.ToInt32(Request.QueryString["cong"]);
				string abbrev = "th";
				if (cong == 103)
					abbrev = "rd";

				RedirectLib.PageRedirect(this,"http://frwebgate.access.gpo.gov/cgi-bin/multidb.cgi?WAISdbName=" + cong + "_cong_bills+Congressional+Bills%2C+" + cong + abbrev + "+Congress&WAISqueryRule=%24WAISqueryString&WAIStemplate=multidb_results.html&WAISqueryString=%22" + t + "+" + no + "%22&Submit.=Submit&WAISmaxHits=50&WrapperTemplate=bills_wrapper.html", t + " No. " + Convert.ToString(cong) + abbrev + "-" + no);
				//more years available here: http://thomas.loc.gov/home/c110query.html
			}
			else if (docType == "SenTreatyDoc")
			{
				string no = Convert.ToString(Request.QueryString["no"]);
				int cong = Convert.ToInt32(Request.QueryString["cong"]);

				if (no.Length == 1)
					no = "00" + no; 
				else if (no.Length == 2)
					no = "0" + no; 
				RedirectLib.PageRedirect(this,"http://frwebgate.access.gpo.gov/cgi-bin/useftp.cgi?IPaddress=162.140.64.181&filename=td" + no + "." + cong + "&directory=/diska/wais/data/" + cong + "_cong_documents", "");
			}
			else if (docType == "CongRec")
			{
				int vol = Convert.ToInt32(Request.QueryString["vol"]);
				string page = Convert.ToString(Request.QueryString["page"]);
				int year = vol + 1854;
				RedirectLib.PageRedirect(this,"http://frwebgate.access.gpo.gov/cgi-bin/getpage.cgi?position=all&page=" + page + "&dbname=" + year + "_record", Convert.ToString(vol) + " Cong. Rec. " + page);
			}
			
			// National Labor Relations Board decisions (last checked 11/18/10)
			
			else if (docType == "NLRB")
			{
				int vol = Convert.ToInt32(Request.QueryString["vol"]);
				if (vol > 345)
					RedirectLib.PageRedirect(this,"http://www.nlrb.gov/research/decisions/board_decisions/index.aspx", "NLRB vol. " + Convert.ToString(vol));
				else
					RedirectLib.PageRedirect(this,"http://www.nlrb.gov/research/decisions/board_decisions/bound_volumes.aspx", "NLRB vol. " + Convert.ToString(vol));
			}
			
			// Board of Immigration Appeals decisions (last checked 11/19/10)
			
			else if (docType == "BIA")
			{
				int vol = Convert.ToInt32(Request.QueryString["vol"]);
			
				if (vol == 12)
				{
					RedirectLib.PageRedirect(this,"http://www.justice.gov/eoir/vll/intdec/lib_vol12idx.htm", "BIA vol. " + Convert.ToString(vol));
				}
				else if (vol < 19)
				{
					if (vol < 10)
					{
						RedirectLib.PageRedirect(this,"http://www.justice.gov/eoir/vll/intdec/vol0" + vol + ".htm", "BIA vol. " + Convert.ToString(vol));
					}
					else
					{
						if (vol > 12 && vol < 19)
							RedirectLib.PageRedirect(this,"hhttp://www.justice.gov/eoir/vll/intdec/vol" + vol + ".html", "BIA vol. " + Convert.ToString(vol));
						else
							RedirectLib.PageRedirect(this,"http://www.justice.gov/eoir/vll/intdec/vol" + vol + ".htm", "BIA vol. " + Convert.ToString(vol));
					}
				}
				else
				{
					if (vol == 21 || vol == 22 || vol == 23)
						RedirectLib.PageRedirect(this,"http://www.justice.gov/eoir/vll/intdec/nfvol" + vol + ".html", "BIA vol. " + Convert.ToString(vol));
					else
						RedirectLib.PageRedirect(this,"http://www.justice.gov/eoir/vll/intdec/nfvol" + vol + ".htm", "BIA vol. " + Convert.ToString(vol));
				}
			}
			
			// General Accounting Office decisions (last checked 11/18/10)
			
			else if (docType == "GOA")
			{
				string vol = Convert.ToString(Request.QueryString["vol"]);
				string page = Convert.ToString(Request.QueryString["page"]);
				RedirectLib.PageRedirect(this,"http://www.gao.gov/cgi-bin/redbook?CG=" + vol + "%20Comp.%20Gen%20" + page, vol + " Comp. Gen. " + page);
				//See http://www.gao.gov/legal/decisions.html
			}
			
			// U.S. Patents (last checked 11/18/10)
			
			else if (docType == "USPatents")
			{
				string no = Convert.ToString(Request.QueryString["no"]);
				no=no.Replace(",","");
				RedirectLib.PageRedirect(this,"http://www.google.com/patents?vid=USPAT" + no, "U.S. Patent No. " + no);
			}
			
			// A few law reviews - more probably are available on Google Scholar
			
			else if (docType == "HarvLRev")
			{
				RedirectLib.PageRedirect(this,"http://www.harvardlawreview.org/recentissues.shtml", "Harv. L. Rev.");
			}
			else if (docType == "YaleLJ")
			{
				//RedirectLib.PageRedirect(this,"http://yalelawjournal.org/archive.html#ylj");
				RedirectLib.PageRedirect(this,"http://yalelawjournal.org/index.php?option=com_search&Itemid=9&searchword=" + cite + "&submit=Search&searchphrase=exact&ordering=newest", "");
			}
			else if (docType == "ColumLRev")
			{
				RedirectLib.PageRedirect(this,"http://www.columbialawreview.org/archives/", "Columb. L. Rev.");
			}
			else
			{
				Response.Redirect("~/Default.aspx");
			}
		}

		
		//**********************************************************************
		// Redirect to Google Scholar case
		//**********************************************************************
		public void SendToGoogleScholarCase(string cite, string scholarJurisCode)
		{
			string scholarURL = "http://scholar.google.com/scholar?hl=en&num=1&q=%22" + cite + "%22&btnG=Search&as_sdt=" + scholarJurisCode + "&as_ylo=&as_vis=0";

			// Get the text of the relevant Google Scholar search results page
			string page = RedirectLib.PageText(scholarURL);
			
			// Extract the case ID of the desired case
			string caseID = RedirectLib.GoogleScholarCaseID(page);
			
			// Redirect the user to the desired case
			Response.Redirect("http://scholar.google.com/scholar_case?case=" + caseID);
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


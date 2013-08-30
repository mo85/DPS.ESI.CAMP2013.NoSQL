using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuehlke.Camp2013.NoSQL.Web.Test
{
    public static class HtmlStrings
    {
        public const string TestHtml = @"
<!DOCTYPE html>
<html lang=""de"">

<head>
    <title>Test Html Page Title</title>
</head>
<body>
Dies ist eine test page.
</body>
</html>
";

        public const string HeiseDe = @"
<!DOCTYPE html>
<html lang=""de"">

<head>

    <title>IT-News, c't, iX, Technology Review, Telepolis | heise online</title>
        <meta name=""description"" content=""News und Foren zu Computer, IT, Wissenschaft, Medien und Politik. Preisvergleich von Hardware und Software sowie Downloads beim Heise Zeitschriften Verlag."" />
            <meta name=""keywords"" content=""heise online, c't, iX, Technology Review, Newsticker, Telepolis, Security, Netze"" />

    





<meta charset=""utf-8"">
<meta name=""publisher"" content=""Heise Zeitschriften Verlag"" />
<meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" /><link rel=""home"" type=""text/html"" title=""Startseite"" href=""/"" />
<link rel=""copyright"" title=""Copyright"" href=""/Impressum-4862.html"" />     
    
        <!--googleoff: all-->
        <meta name=""twitter:card""   content=""summary"" />
        <meta name=""twitter:site""   content=""@heiseonline"" />
        <meta name=""twitter:domain"" content=""heise.de"" />
    <meta property=""fb:page_id""     content=""333992367317"" />
    <meta property=""og:title""       content=""IT-News, c&#39;t, iX, Technology Review, Telepolis"" />
    <meta property=""og:type""        content=""website"" />
    <meta property=""og:locale""      content=""de_DE"" />
    <meta property=""og:url""         content=""http://www.heise.de/"" />
    <meta property=""og:site_name""   content=""heise online"" />      
    <meta property=""og:image""       content=""http://www.heise.de/icons/ho/heise_online_logo.gif"" />

    <!--googleon: all--><!--googleoff: all-->
<meta name=""generator"" content=""InterRed V13.0, http://www.interred.de/, InterRed GmbH"" />
<!--googleon: all-->

    

<script type=""text/javascript"" src=""/js/jquery/jquery-1.7.1.min.js""></script>
<script type=""text/javascript"" src=""/js/plugins/jquery-ui-1.8.18_cycle.custom.min.js""></script>
<script type=""text/javascript"" src=""/js/plugins/jquery.equalheights.min.js""></script>
<script type=""text/javascript"" src=""/support/lib/social_bookmarks.js""></script>
<script type=""text/javascript"" src=""/support/lib/external.js""></script>
<script type=""text/javascript"" src=""/support/lib/teaser_linking.js""></script>

<script type=""text/javascript"" src=""/js/ho/link_inline_images.min.js""></script>
<script type=""text/javascript"" src=""/js/ho/bilderstrecke.js""></script>
<script type=""text/javascript"">
jQuery(document).ready(function($){
    
    if($('.bilderstrecke_vorschau').length > 0 && (!$.browser.msie || ($.browser.msie && $.browser.version > 8))) {
        $('.bilderstrecke_vorschau').bilderstrecke();
    }
    
    
});
</script>
<!-- view_relaunch: 0 -->

    



<link href=""/stil/standard2008.css"" rel=""stylesheet"" type=""text/css"" />
<link href=""/stil/navi_top2008.css"" rel=""stylesheet"" type=""text/css"" />
<link href=""/stil/drucken.css"" rel=""stylesheet"" type=""text/css"" media=""print"" />


    <!--googleoff: all-->
    <link href=""/favicon.ico"" rel=""shortcut icon"" />
    <link rel=""author"" title=""Kontakt"" href=""mailto:kontakt%40heise.de?subject=heise%20online"" />
    <link rel=""search"" title=""Suche"" href=""http://www.heise.de/suche/"" />
    <link rel=""alternate"" type=""application/atom+xml"" title=""Aktuelle News von heise online"" href=""http://www.heise.de/newsticker/heise-atom.xml"" />
    <link rel=""alternate"" type=""application/rss+xml"" title=""Aktuelle News von heise online (für ältere RSS-Reader)"" href=""http://www.heise.de/newsticker/heise.rdf"" />
    <link rel=""apple-touch-icon-precomposed"" href=""/apple-touch-icon-57x57-precomposed.png"" />
    <link rel=""apple-touch-icon-precomposed"" sizes=""114x114"" href=""/apple-touch-icon-114x114-precomposed.png"" />
    <link rel=""apple-touch-icon-precomposed"" sizes=""72x72"" href=""/apple-touch-icon-72x72-precomposed.png"" />
    <meta name=""application-name"" content=""heise online"">
    <meta name=""msapplication-tooltip"" content=""heise online"">
    <meta name=""msapplication-starturl"" content=""http://www.heise.de/"">
    <meta name=""msapplication-TileImage"" content=""http://www.heise.de/icons/ho/windows-icon-144.png"">
    <meta name=""msapplication-TileColor"" content=""#999999"">
    <meta name=""msapplication-square70x70logo"" content=""http://www.heise.de/icons/ho/ho_windows-icon-70.png""/>
    <meta name=""msapplication-square150x150logo"" content=""http://www.heise.de/icons/ho/ho_windows-icon-150.png""/>
    <meta name=""msapplication-wide310x150logo"" content=""http://www.heise.de/icons/ho/ho_windows-icon-310-quer.png""/>
    <meta name=""msapplication-square310x310logo"" content=""http://www.heise.de/icons/ho/ho_windows-icon-310.png""/>
    <meta name=""msapplication-notification"" content=""frequency=30;polling-uri=http://notifications.buildmypinnedsite.com/?feed=http://www.heise.de/newsticker/heise-atom.xml&id=1;polling-uri2=http://notifications.buildmypinnedsite.com/?feed=http://www.heise.de/newsticker/heise-atom.xml&id=2;polling-uri3=http://notifications.buildmypinnedsite.com/?feed=http://www.heise.de/newsticker/heise-atom.xml&id=3;polling-uri4=http://notifications.buildmypinnedsite.com/?feed=http://www.heise.de/newsticker/heise-atom.xml&id=4;polling-uri5=http://notifications.buildmypinnedsite.com/?feed=http://www.heise.de/newsticker/heise-atom.xml&id=5; cycle=1""/>
    <meta name=""DC.creator"" content=""heise online"" />        <link href=""/stil/ho/heiseonline2012.css"" rel=""stylesheet"" type=""text/css"" />
</head>

<body>







<div class=""heisetopnavi no-touch heisetopnavi_relaunch"">
    <div class=""heisetopnavi_header"">
        <header role=""banner"">
            <div class=""heisetopnavi_login"">
                <script type=""text/javascript"" src=""/js/ho/login.min.js""></script>
                <div id=""navi_login"">
                    <p><a href=""https://www.heise.de/userdb/sso?rm=show_login&amp;dirid=1&amp;objekt=/"">Einloggen</a> auf heise online</p>
                </div>
            </div>
            <nav role=""navigation"">
                <div class=""heisetopnavi_hover_legacy"">
                    <a href=""/index.html/from/navi_oben_ho"" class=""heisetopnavi_logo"" title=""heise online"">
                        <img src=""//www.heise.de/icons/ho/heise_online_logo_top.gif"" width=""200"" height=""44"" alt=""heise online"" />
                    </a>
                    <a href=""#heisetopnavi_sub_container"" class=""heisetopnavi_button"" aria-haspopup=""true"">Menü auf-/zuklappen</a>
                    <div id=""heisetopnavi_sub_container"">
                        <ul id=""heisetopnavi_sub"">
                            <li>
                                <ul>
                                    <li class=""heisetopnavi_ho""><a href=""/index.html/from/navi_oben_ho"" title=""heise online – IT-News"">News</a></li>
                                    <li class=""heisetopnavi_ct""><a href=""/ct/from/navi_oben_ct"" title=""c't – Magazin für Computertechnik"">c't</a></li>
                                    <li class=""heisetopnavi_ix""><a href=""/ix/from/navi_oben_ix"" title=""iX – Magazin für professionelle Informationstechnik"">iX</a></li>
                                    <li class=""heisetopnavi_tr""><a href=""/tr/from/navi_oben_tr"" title=""Technology Review – Das M.I.T.-Magazin für Innovation"">Technology Review</a></li>
                                    <li class=""heisetopnavi_mac""><a href=""/mac-and-i/from/navi_oben_mac"" title=""Mac &amp; i – Nachrichten, Tests, Tipps und Meinungen rund um Apple"">Mac &amp; i</a></li>
                                    <li class=""heisetopnavi_tp""><a href=""/tp/from/navi_oben_tp"" title=""Telepolis"">Telepolis</a></li>
                                    <li class=""heisetopnavi_hh""><a href=""/hardware-hacks/from/navi_oben_hh"" title=""Hardware Hacks – Kreativ mit Technik"">Hardware Hacks</a></li>
                                    <li class=""heisetopnavi_df""><a href=""/foto/special/from/navi_oben_df"" title=""Digitale Fotografie"">Digitale Fotografie</a></li>
                                </ul>
                            </li>
                            <li>
                                <ul>
                                    <li class=""heisetopnavi_aut""><a href=""/autos/from/navi_oben_aut"" title=""heise Autos – News, Tests, Technik, Service rund ums Auto"">heise Autos</a></li>
                                    <li class=""heisetopnavi_dev""><a href=""/developer/from/navi_oben_dev"" title=""heise Developer – Informationen für Entwickler"">heise Developer</a></li>
                                    <li class=""heisetopnavi_foto""><a href=""/foto/from/navi_oben_foto"" title=""heise Foto – Das Online-Magazin rund ums digitale Bild"">heise Foto</a></li>
                                    <li class=""heisetopnavi_net""><a href=""/netze/from/navi_oben_net"" title=""heise Netze – Alles über Netzwerk-Technik"">heise Netze</a></li>
                                    <li class=""heisetopnavi_op""><a href=""/open/from/navi_oben_op"" title=""heise open – Open Source im Unternehmen"">heise Open Source</a></li>
                                    <li class=""heisetopnavi_res""><a href=""/resale/from/navi_oben_res"" title=""heise resale – Fakten, Trends und Standpunkte für das ITK-Geschäft"">heise resale</a></li>
                                    <li class=""heisetopnavi_sec""><a href=""/security/from/navi_oben_sec"" title=""heise Security – News, Dienste und Foren zum Thema Computer-Sicherheit"">heise Security</a></li>
                                    <li class=""heisetopnavi_video""><a href=""/video/from/navi_oben_video"" title=""heise Video – Clips zu Nachrichten und Artikeln"">heise Video</a></li>
                                    <li class=""heisetopnavi_tech""><a href=""/redirect-to/techstage/from/navi_oben_techstage"" title=""TechStage – News, Tests &amp; Praxis zu Smartphones und Tablets mit Android, iOS, Windows Phone &amp; Co."">TechStage</a></li>
                                </ul>
                            </li>
                            <li class=""heisetopnavi_third"">
                                <ul>
                                    <li class=""heisetopnavi_swv""><a href=""/download/from/navi_oben_swv"" title=""Software-Verzeichnis – Software zum Download fuer Windows, Mac, Linux, iPhone, Symbian, Android"">Download</a></li>
                                    <li class=""heisetopnavi_pvg""><a href=""/preisvergleich/from/navi_oben_pvg"" title=""Preisvergleich – Günstige Preise, Meinungen und Bewertungen zu vielen Produkten"">Preisvergleich</a></li>
                                    <li class=""heisetopnavi_job""><a href=""/jobs/from/navi_oben_job"" title=""heise jobs – Jobbörse für qualifizierte Fach- und Führungskräfte aus der IT-Branche"">Stellenmarkt</a></li>
                                    <li class=""heisetopnavi_eve""><a href=""/events/from/navi_oben_eve"" title=""heise Events – Konferenzen, Seminare, Workshops"">Veranstaltungen</a></li>
                                    <li class=""heisetopnavi_itm""><a href=""/itmarkt/from/navi_oben_itm"" title=""IT-Markt – Branchenverzeichnis der IT-Fachhändler"">IT-Markt</a></li>
                                    <li class=""heisetopnavi_whi""><a href=""/whitepapers/from/navi_oben_whi"" title=""heise Whitepapers – Kostenloser Download aktueller Praxisbeispiele, Firmeninfos, Case Studies und Webcasts zu neuen Produkten, Strategien und Lösungen namhafter IT-Hersteller"">Whitepapers</a></li>
                                    <li class=""heisetopnavi_webcasts""><a href=""/redirect-to/webcasts/from/navi_oben_webcasts"" title=""heise Webcasts – Kompakte Firmeninformationen zu komplexen IT-Sachverhalten"">Webcasts</a></li>
                                    <li class=""heisetopnavi_tarifr""><a href=""/redirect-to/tarifrechner/from/navi_oben_tarifr"" title=""Tarifrechner – DSL, Mobiles Internet, Handy, Telefon, Strom, Gas"">Tarifrechner</a></li>
                                </ul>
                            </li>
                            <li class=""heisetopnavi_fourth"">
                                <ul>
                                    <li class=""heisetopnavi_shop""><a href=""/redirect-to/shop/from/navi_oben_shop"" title=""heise shop – IT Fachzeitschriften, Bücher, CD/DVD/Blu-ray"">heise shop</a></li>
                                    <li class=""heisetopnavi_kio""><a href=""/artikel-archiv/from/navi_oben_kio"" title=""Artikel-Archiv – c't, iX, Technology Review, Digitale Fotografie, Mac &amp; i, Sonderhefte"">Artikel-Archiv</a></li>
                                    <li class=""heisetopnavi_abo""><a href=""/redirect-to/abo/from/navi_oben_abo"" title=""Abo – c't, iX, Technology Review, Digitale Fotografie, Mac &amp; i"">Zeitschriften-Abo</a></li>
                                    <li class=""heisetopnavi_hmg""><a href=""/redirect-to/hmg/from/navi_oben_hmg"" title=""Arbeiten bei heise – Aktuelle Stellenangebote der Heise Medien Gruppe"">Arbeiten bei heise</a></li>
                                </ul>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
        
            
            
                
                    
                    
            
        
            <form accept-charset=""utf-8"" method=""get"" action=""/suche/"" id=""heisetopnavi_search"" role=""search"">
                <fieldset>
                    <input type=""text"" class=""search_text"" value="""" name=""q"" placeholder=""in heise online suchen""><input type=""image"" src=""//www.heise.de/icons/ho/heise_online_lupe.gif"" alt=""Los"" class=""search_submit"" name=""search_submit"">
                    <input type=""hidden"" class=""search_hidden"" value=""search"" name=""rm"">
                </fieldset>
            </form>
        </header>
    </div>
    <div class=""clear""></div>
</div>

<script type=""text/javascript"">
if (typeof jQuery !== ""undefined"") {
    jQuery(document).ready(function($) {
        // Support Touch-Devices
        if ('ontouchstart' in document) {
            $('.heisetopnavi_relaunch').removeClass('no-touch');
        }
        $('.heisetopnavi_button').bind('touchstart', function(e) {
            e.preventDefault();
            if ($(e.target).is('a.heisetopnavi_button')) {
                $(this).toggleClass('active');
                $('.heisetopnavi header > nav').toggleClass('hover');
            }
        });

        $('.heisetopnavi_relaunch .heisetopnavi_button').click(function(e) {
            e.preventDefault();
        });

        // Support Keyboard
        $('.heisetopnavi_relaunch .heisetopnavi_button').keyup(function(e) {
            if (e.which == 13 && $(e.target).is('a.heisetopnavi_button')) {
                $('.heisetopnavi_relaunch .heisetopnavi_button').toggleClass('active');
                $('.heisetopnavi_relaunch header > nav').toggleClass('hover');
            }
        });

        /*
         * Open/Close Menu with JavaScript for more Usability
         */

        $('.heisetopnavi_relaunch').removeClass('no-touch');

        // Logo + Icon
        $('.heisetopnavi_relaunch .heisetopnavi_hover_legacy').mouseenter(function() {
            var timeout_id = window.setTimeout(function() { 
                $('.heisetopnavi_relaunch .heisetopnavi_button').addClass('active');
                $('.heisetopnavi_relaunch nav').addClass('hover');
                $('body').addClass('refreshDOM');
                $('body').removeClass('refreshDOM');
            }, 300);
            $(this).data('timeout_id', timeout_id);
        });
        $('.heisetopnavi_relaunch .heisetopnavi_hover_legacy').mouseleave(function() {
            var timeout_id = $(this).data('timeout_id');
            window.clearTimeout(timeout_id);
            timeout_id = window.setTimeout(function() { 
                $('.heisetopnavi_relaunch .heisetopnavi_button').removeClass('active');
                $('.heisetopnavi_relaunch nav').removeClass('hover');
                $('body').addClass('refreshDOM');
                $('body').removeClass('refreshDOM');
            }, 0);
            $(this).data('timeout_id', timeout_id);
        });
    });

    if (typeof heiseLogin != ""undefined"") {
        heiseLogin.login_fill_navigation({});
    }
}
</script>



    <div id=""container"">
        <div id=""container_content"">
            <div id=""logo_bereich"">
                <div class=""logo"">
                                    <a href=""/"" title=""heise online News"" class=""channel_titel"">News</a>
                                </div>
                <ul class=""navigation"">
                    <li><strong><a href=""/newsticker/classic/"" title=""Newsticker Classic"">Newsticker</a></strong></li>
                    <li><strong><a href=""/newsticker/"" title=""7-Tage-News"">7-Tage-News</a></strong></li>
                    <li><strong><a href=""/newsticker/archiv/"" title=""Newsticker Archiv"">Archiv</a></strong></li>
                    <li><strong><a href=""/foren/"" title=""Leserforum"">Foren</a></strong></li>
                </ul>
                <ul class=""sub_navigation"">
                    <li class=""rss""><a href=""/news-extern/news.html"" title=""RSS-Feeds"">RSS</a></li>
                    <li class=""mobi""><a href=""http://m.heise.de/"" title=""News mobil"">News mobil</a></li>
                    <li class=""newsletter""><a href=""/newsletter/"" title=""Newsletter"">Newsletter</a></li>
                </ul>
            </div>
            
            <div id=""themen_aktuell"">
                <p>Top-Themen:</p>
                <ol>
                    <li><a name=""themen.ho.nsa"" href=""/thema/NSA"">NSA</a></li>
                    <li><a name=""themen.ho.prism"" href=""/thema/PRISM"">PRISM</a></li>
                    <li><a name=""themen.ho.gamescom"" href=""/thema/GamesCOM"">GamesCOM</a></li>
                    <li><a name=""themen.ho.google_glass"" href=""/thema/Google-Glass"">Google Glass</a></li>
                    <li><a name=""themen.ho.windows_8"" href=""/thema/Windows-8"">Windows 8</a></li>
                    <li><a name=""themen.ho.iphone"" href=""/thema/iPhone"">iPhone</a></li>
                    <li><a name=""themen.ho.android"" href=""/thema/Android"">Android</a></li>
                    <li><a name=""themen.ho.e-book"" href=""/thema/E_Book"">E-Book</a></li>
                    <li><a name=""themen.ho.lte"" href=""/thema/LTE"">LTE</a></li>
                </ol>
            </div>
            
                
                        <div id=""mitte"">
            
                <div id=""mitte_links"">
            
            <!--googleon: all-->
            <div id=""mitte_news"">

            <div id=""oben"" class=""topteaser_2011 layout_6"">
                <script type=""text/javascript"">
                <!--//--><![CDATA[//><!--
                    $(document).ready( function() {
                        if ( $('#oben .multiple .img_clip').length ) {
                            $('#oben .multiple .img_clip').height($('#oben .multiple .img_clip img').objectMinHeight());
                        }
                        if ( $('#oben .multiple h2').length ) {
                            $('#oben .multiple h2').objectToMaxHeight();
                        }
                        if ( $('#oben .multiple .dachzeile').length ) {
                            $('#oben .multiple .dachzeile').objectToMaxHeight();
                        }
                        if ( $('#oben .multiple p').length ) {
                            $('#oben .multiple p').objectToMaxHeight();
                        }
                    });
                //--><!]]>
                </script>
            
                <div class=""multiple"">
            <a href=""/newsticker/meldung/Merkel-Fragen-in-der-NSA-Affaere-sind-geklaert-1938173.html"" title=""&quot;Fragen sind geklärt&quot;"" class=""the_content_url"">
                <b class=""dachzeile"">Merkel zur NSA-Affäre</b>
                    <h2>""Fragen sind geklärt"" <img src=""/icons/ho/video.png""             width=""17""  height=""11"" alt=""Video""         title=""Video im Beitrag""         /></h2>
            </a>
            <a href=""/newsticker/meldung/Merkel-Fragen-in-der-NSA-Affaere-sind-geklaert-1938173.html"" title=""&quot;Fragen sind geklärt&quot;"" class=""the_content_url"">
                        <div class=""img_clip""><img src=""/imgs/71/1/0/6/3/9/3/8/Merkel.jpg-6cfb37fd07815d98.jpeg"" width=""260"" height=""195"" alt=""""  /></div>
                    <p>
                        Die Kanzlerin hat in der NSA-Affäre Kanzleramtsminister Pofalla zugestimmt. Drastische Worten fanden dagegen Hans Magnus Enzensberger und Frank Schirrmacher.<span class=""indexlist_more""></span>
                    </p>
            </a>
            <div class=""kommentare"">124</div> 
                <ul>
                    <li><a href=""/meldung/NSA-Ueberwachungsskandal-Von-PRISM-Tempora-XKeyScore-und-dem-Supergrundrecht-was-bisher-geschah-1931179.html"">NSA-Skandal: Was bisher geschah</a></li></ul>

                </div>
                <div class=""multiple last"">
            <a href=""/newsticker/meldung/WhatsApp-Whistle-unsichere-Instant-Messenger-1938062.html"" title=""Unsichere Messenger"" class=""the_content_url"">
                <b class=""dachzeile"">WhatsApp, Whistle</b>
                    <h2>Unsichere Messenger</h2>
            </a>
            <a href=""/newsticker/meldung/WhatsApp-Whistle-unsichere-Instant-Messenger-1938062.html"" title=""Unsichere Messenger"" class=""the_content_url"">
                        <div class=""img_clip""><img src=""/imgs/71/1/0/6/3/9/3/8/Whatsup_41118342.original.large-4-3-800-0-252-2694-2270-effcd53cc763e8c7-7bcecc64b61bd3cc.jpeg"" width=""260"" height=""195"" alt=""""  /></div>
                    <p>
                        WhatsApp hat bislang zwar einige Sicherheitslücken geschlossen, bleibt aber nach wie vor unsicher. Dem neuen Dienst Whistle.im stellt ein Mitglied des CCC Hannover ein verheerendes Zeugnis aus.<span class=""indexlist_more""></span>
                    </p>
            </a>
            <div class=""kommentare"">91</div> 
                </div>
            </div>
            <div id=""unten"" class=""topteaser_2011 layout_8"">
                <script type=""text/javascript"">
                <!--//--><![CDATA[//><!--
                    $(document).ready( function() {
                        if ( $('#unten .multiple .img_clip').length ) {
                            $('#unten .multiple .img_clip').height($('#unten .multiple .img_clip img').objectMinHeight());
                        }
                        if ( $('#unten .multiple h2').length ) {
                            $('#unten .multiple h2').objectToMaxHeight();
                        }
                        if ( $('#unten .multiple .dachzeile').length ) {
                            $('#unten .multiple .dachzeile').objectToMaxHeight();
                        }
                        if ( $('#unten .multiple p').length ) {
                            $('#unten .multiple p').objectToMaxHeight();
                        }
                    });
                //--><!]]>
                </script>
            
                <div class=""multiple"">
            <a href=""/newsticker/meldung/NSA-Protestaktion-Mini-Drohne-nach-Polizeieinsatz-auf-dem-Pruefstand-1938255.html"" title=""Mini-Drohne weg"" class=""the_content_url"">
                <b class=""dachzeile"">NSA-Protestaktion</b>
                    <h2>Mini-Drohne weg</h2>
            </a>
            <a href=""/newsticker/meldung/NSA-Protestaktion-Mini-Drohne-nach-Polizeieinsatz-auf-dem-Pruefstand-1938255.html"" title=""Mini-Drohne weg"" class=""the_content_url"">
                        <div class=""img_clip""><img src=""/imgs/71/1/0/6/3/9/3/8/quadcopter-a2f43675925f3354-21ab0b866ce92bce.jpeg"" width=""160"" height=""120"" alt=""""  /></div>
                    <p>
                        Ein Spaziergang zum Dagger-Komplex führte wegen einer Mini-Drohne zu einem Einsatz der Polizei.<span class=""indexlist_more""></span>
                    </p>
            </a>
            <div class=""kommentare"">71</div> 
                </div>
                <div class=""multiple"">
            <a href=""/newsticker/meldung/Microsoft-warnt-erneut-vor-zukuenftigen-XP-Sicherheitsluecken-1937554.html"" title=""Warnung vor XP"" class=""the_content_url"">
                <b class=""dachzeile"">Microsoft</b>
                    <h2>Warnung vor XP</h2>
            </a>
            <a href=""/newsticker/meldung/Microsoft-warnt-erneut-vor-zukuenftigen-XP-Sicherheitsluecken-1937554.html"" title=""Warnung vor XP"" class=""the_content_url"">
                        <div class=""img_clip""><img src=""/imgs/71/1/0/6/3/9/3/8/urn-newsml-dpa-com-20090101-130410-99-03043_large_4_3-00947f86fd1c0efc.jpeg"" width=""160"" height=""120"" alt=""Windows XP""  /></div>
                    <p>
                        Mit drastischen Worten hat Microsoft erneut davor gewarnt, weiterhin noch Windows XP zu nutzen.<span class=""indexlist_more""></span>
                    </p>
            </a>
            <div class=""kommentare"">905</div> 
                </div>
                <div class=""multiple last"">
            <a href=""/newsticker/meldung/Deutscher-Musikmarkt-waechst-nach-jahrelanger-Talfahrt-1938066.html"" title=""Endlich Wachstum"" class=""the_content_url"">
                <b class=""dachzeile"">Deutscher Musikmarkt</b>
                    <h2>Endlich Wachstum</h2>
            </a>
            <a href=""/newsticker/meldung/Deutscher-Musikmarkt-waechst-nach-jahrelanger-Talfahrt-1938066.html"" title=""Endlich Wachstum"" class=""the_content_url"">
                        <div class=""img_clip""><img src=""/imgs/71/1/0/6/3/9/3/8/musikb_39282608_original.large-4-3-800-180-0-3979-2848-380981f04e4582d7.jpeg"" width=""160"" height=""120"" alt=""Musikbranche""  /></div>
                    <p>
                        Nach langer Krise gibt es gute Nachrichten für die deutsche Musikbranche: Der Markt wächst nun wieder.<span class=""indexlist_more""></span>
                    </p>
            </a>
            <div class=""kommentare"">30</div> 
                </div>
            </div>
        <div class=""trennlinie_6px""></div>

    <div class=""startseite"">
        




<div class=""indexlist"">
    <div class=""indexlist_item""><section>
        <header>
            
            <h3>
            <a href=""/newsticker/meldung/Freeware-und-Indie-Tipps-zum-Wochenstart-1937351.html"" title=""Freeware- und Indie-Tipps zum Wochenstart"">Freeware- und Indie-Tipps zum Wochenstart</a>
        </h3></header>
        <ul class=""indexlist_info"">
                <li class=""date"">heute, 16:49 Uhr</li>
                <li class=""kommentare nr1"">1<span class=""unsichtbar""> Kommentare</span></li>
                <li class=""icon""><img src=""/icons/ho/video.png""             width=""17""  height=""11"" alt=""Video""         title=""Video im Beitrag""         /></li> 
        </ul>
        <a href=""/newsticker/meldung/Freeware-und-Indie-Tipps-zum-Wochenstart-1937351.html"" class=""indexlist_text"">
                <i class=""figure""><img src=""/imgs/18/1/0/6/3/3/2/0/vorschau-7fb23218612e43b6.png"" width=""100"" height=""64"" alt="""" title="""" /></i>
            <p>In unseren brandneuen Freeware-Spieletipps können Sie sich zum Beispiel auf der Suche nach einem Ausgang durch eine Traumwelt rätseln, Schach als Echtzeitstrategiespiel erleben oder Männchen unter tonnenschweren Gewichten begraben.<span class=""indexlist_more""></span></p>
        </a>
    </section></div>
            
            
            
            
            
            
    <div class=""indexlist_item""><section>
        <header>
            
            <h3>
            <a href=""/newsticker/meldung/3-Millionen-fuer-die-neue-GEZ-Sixt-will-klagen-1938264.html"" title=""3 Millionen für die neue GEZ: Sixt will klagen"">3 Millionen für die neue GEZ: Sixt will klagen</a>
        </h3></header>
        <ul class=""indexlist_info"">
                <li class=""date"">heute, 15:42 Uhr</li>
                <li class=""kommentare nr70"">70<span class=""unsichtbar""> Kommentare</span></li> 
        </ul>
        <a href=""/newsticker/meldung/3-Millionen-fuer-die-neue-GEZ-Sixt-will-klagen-1938264.html"" class=""indexlist_text"">
                <i class=""figure""><img src=""/imgs/18/1/0/6/3/9/3/5/nettv_38187956_original.large-4-3-800-490-0-4256-2832-48fe6dfe48115757.jpeg"" width=""100"" height=""75"" alt=""Internationale Funkausstellung"" title=""Internationale Funkausstellung"" /></i>
            <p>Nach der Drogeriekette Rossmann wehrt sich auch der Autovermieter Sixt gegen die jetzt Rundfunkbeitrag genannte neue GEZ-Gebühr. Der Bayerische Rundfunk reagierte angesichts gesunkener abgeführter Gebühren mit Unverständnis.<span class=""indexlist_more""></span></p>
        </a>
            <ul class=""indexlist_links"">
                <li><a href=""http://www.heise.de/meldung/Studie-Rundfunkgebuehren-senken-und-Werbung-weg-1874694.html"">Studie: Rundfunkgebühren senken und Werbung weg</a></li>
                <li><a href=""http://www.heise.de/meldung/Rundfunkbeitrag-15-Thesen-zur-Grundversorgung-2-0-1785560.html"">Rundfunkbeitrag: 15 Thesen zur Grundversorgung 2.0</a></li>
                <li><a href=""http://www.heise.de/meldung/Fuer-Schwarzseher-wird-s-eng-Haushaltsabgabe-statt-GEZ-Gebuehren-1765168.html"">Für Schwarzseher wird's eng: Haushaltsabgabe statt GEZ-Gebühren</a></li>
            </ul>
    </section></div>
    <div class=""indexlist_item""><section>
        <header>
            
            <h3>
            <a href=""/newsticker/meldung/Computerspiele-Ueber-zwei-Milliarden-Euro-Umsatz-fuer-2013-prognostiziert-1938175.html"" title=""Computerspiele: Über zwei Milliarden Euro Umsatz für 2013 prognostiziert"">Computerspiele: Über zwei Milliarden Euro Umsatz für 2013 prognostiziert</a>
        </h3></header>
        <ul class=""indexlist_info"">
                <li class=""date"">heute, 15:32 Uhr</li>
                <li class=""kommentare nr9"">9<span class=""unsichtbar""> Kommentare</span></li> 
        </ul>
        <a href=""/newsticker/meldung/Computerspiele-Ueber-zwei-Milliarden-Euro-Umsatz-fuer-2013-prognostiziert-1938175.html"" class=""indexlist_text"">
                <i class=""figure""><img src=""/imgs/18/1/0/6/3/8/7/8/silberscheibe_36047258_original.large-4-3-800-228-0-4668-3336-58d355011dd72e3d.jpeg"" width=""100"" height=""75"" alt=""Spielen am Computer"" title=""Spielen am Computer"" /></i>
            <p>Laut neuesten Prognosen wird der Umsatz im Video- und Computerspielemarkt bis 2016 auf rund 2,4 Milliarden Euro steigen. Besonderes Wachstumspotenzial sieht das Beratungshaus PwC beim Handel mit virtuellen Gütern.<span class=""indexlist_more""></span></p>
        </a>
    </section></div>
    <div class=""indexlist_item""><section>
        <header>
            
            <h3>
            <a href=""/newsticker/meldung/Maxdome-Keine-Option-mehr-auf-preiswertere-Spielfilme-1938183.html"" title=""Maxdome: Keine Option mehr auf preiswertere Spielfilme"">Maxdome: Keine Option mehr auf preiswertere Spielfilme</a>
        </h3></header>
        <ul class=""indexlist_info"">
                <li class=""date"">heute, 15:25 Uhr</li>
                <li class=""kommentare nr17"">17<span class=""unsichtbar""> Kommentare</span></li> 
        </ul>
        <a href=""/newsticker/meldung/Maxdome-Keine-Option-mehr-auf-preiswertere-Spielfilme-1938183.html"" class=""indexlist_text"">
                <i class=""figure""><img src=""/imgs/18/1/0/6/3/8/8/6/Online-Videorecoder-40f19abdc73dabb4.png"" width=""100"" height=""75"" alt=""Web-TV, Online-Videorecoder"" title=""Web-TV, Online-Videorecoder"" /></i>
            <p>Der Video-on-Demand-Anbieter hat die &quot;Blockbuster-Option&quot; für seine Paket-Abonnenten gestrichen. Neue Spielfilme stehen nun nur noch zum teureren Einzelabruf zur Verfügung. Der Dienst argumentiert mit &quot;lizenzrechtlichen Gründen&quot;.<span class=""indexlist_more""></span></p>
        </a>
    </section></div>
    <div class=""indexlist_item""><section>
        <header>
            
            <h3>
            <a href=""/newsticker/meldung/Consumermarkt-Erstmals-mehr-Tablets-als-Notebooks-verkauft-1938179.html"" title=""Consumermarkt: Erstmals mehr Tablets als Notebooks verkauft"">Consumermarkt: Erstmals mehr Tablets als Notebooks verkauft</a>
        </h3></header>
        <ul class=""indexlist_info"">
                <li class=""date"">heute, 15:10 Uhr</li>
                <li class=""kommentare nr48"">48<span class=""unsichtbar""> Kommentare</span></li> 
        </ul>
        <a href=""/newsticker/meldung/Consumermarkt-Erstmals-mehr-Tablets-als-Notebooks-verkauft-1938179.html"" class=""indexlist_text"">
                <i class=""figure""><img src=""/imgs/18/1/0/6/3/8/8/2/Tablets_Aufmacher_ct-b5e324d4a7cf150b.jpeg"" width=""100"" height=""67"" alt="""" title="""" /></i>
            <p>Der Elektronikhandel verzeichnet an allen Fronten Umsatzrückgänge. Allein Smartphones bescheren den Anbietern noch nennenswertes Wachstum. Tablets setzen sich an die Spitze im IT-Markt.<span class=""indexlist_more""></span></p>
        </a>
    </section></div>
    <div class=""indexlist_item""><section>
        <header>
            
            <h3>
            <a href=""/newsticker/meldung/GDC-AMD-GPUs-Radeon-HD-7000-noch-nicht-vollstaendig-zu-Direct3D-11-2-kompatibel-1938071.html"" title=""GDC: AMD-GPUs Radeon HD 7000 noch nicht vollständig zu Direct3D 11.2 kompatibel"">GDC: AMD-GPUs Radeon HD 7000 noch nicht vollständig zu Direct3D 11.2 kompatibel</a>
        </h3></header>
        <ul class=""indexlist_info"">
                <li class=""date"">heute, 14:38 Uhr</li>
                <li class=""kommentare nr11"">11<span class=""unsichtbar""> Kommentare</span></li> 
        </ul>
        <a href=""/newsticker/meldung/GDC-AMD-GPUs-Radeon-HD-7000-noch-nicht-vollstaendig-zu-Direct3D-11-2-kompatibel-1938071.html"" class=""indexlist_text"">
                <i class=""figure""><img src=""/imgs/18/1/0/6/3/8/3/0/01-Laylah_Mah-6e9e8e8adf28bde7.jpeg"" width=""100"" height=""95"" alt="""" title="""" /></i>
            <p>Durch ein Problem mit einer Feedback-Routine sind AMDs aktuelle GPUs nicht mit Direct3D 11.2 kompatibel. Ein Treiber-Update soll das Problem lösen.<span class=""indexlist_more""></span></p>
        </a>
    </section></div>
    <div class=""indexlist_item""><section>
        <header>
            
            <h3>
            <a href=""/newsticker/meldung/Facebook-Hacker-weist-auf-Zuckerbergs-Pinnwand-auf-Luecke-hin-1938060.html"" title=""Facebook: Hacker weist auf Zuckerbergs Pinnwand auf Lücke hin"">Facebook: Hacker weist auf Zuckerbergs Pinnwand auf Lücke hin</a>
        </h3></header>
        <ul class=""indexlist_info"">
                <li class=""date"">heute, 13:35 Uhr</li>
                <li class=""kommentare nr100"">100<span class=""unsichtbar""> Kommentare</span></li> 
        </ul>
        <a href=""/newsticker/meldung/Facebook-Hacker-weist-auf-Zuckerbergs-Pinnwand-auf-Luecke-hin-1938060.html"" class=""indexlist_text"">
                <i class=""figure""><img src=""/imgs/18/1/0/6/3/8/2/0/Zuckerberg-d8da3085c0bb4e2c.jpeg"" width=""100"" height=""70"" alt="""" title="""" /></i>
            <p>Ein palästinensischer Hacker hat auf Facebook direkt an die gesperrte Pinnwand von Mark Zuckerberg geschrieben, um damit auf eine Sicherheitslücke aufmerksam zu machen. Zuvor hatte ihn das Sicherheitsteam der Plattform abgewimmelt.<span class=""indexlist_more""></span></p>
        </a>
    </section></div>
            
            
    <div class=""indexlist_item""><section>
        <header>
            
            <h3>
            <a href=""/newsticker/meldung/E-Plus-beschleunigt-UMTS-HSPA-auf-42-2-MBit-s-1938030.html"" title=""E-Plus beschleunigt UMTS/HSPA auf 42,2 MBit/s"">E-Plus beschleunigt UMTS/HSPA auf 42,2 MBit/s</a>
        </h3></header>
        <ul class=""indexlist_info"">
                <li class=""date"">heute, 13:01 Uhr</li>
                <li class=""kommentare nr43"">43<span class=""unsichtbar""> Kommentare</span></li> 
        </ul>
        <a href=""/newsticker/meldung/E-Plus-beschleunigt-UMTS-HSPA-auf-42-2-MBit-s-1938030.html"" class=""indexlist_text"">
                <i class=""figure""><img src=""/imgs/18/1/0/6/3/7/9/4/netze_38138510_original.large-4-3-800-0-327-1960-1793-9fe0f09e4b3e8fcc.jpeg"" width=""100"" height=""75"" alt=""Mobilfunknetze"" title=""Mobilfunknetze"" /></i>
            <p>Der Mobilfunknetzbetreiber verdoppelt mit der etablierten Dual-Cell-Technik den maximalen Durchsatz einer UMTS-Mobilfunkzelle.<span class=""indexlist_more""></span></p>
        </a>
            <ul class=""indexlist_links"">
                <li><a href=""http://www.heise.de/meldung/Bis-zu-300-MBit-s-LTE-Advanced-Verbindungen-auf-zwei-Funkbaendern-1934476.html"">Bis zu 300 MBit/s: LTE-Advanced-Verbindungen auf zwei Funkbändern</a></li>
            </ul>
    </section></div>
    <div class=""indexlist_item""><section>
        <header>
            
            <h3>
            <a href=""/newsticker/meldung/Piraten-stellen-Plattform-zur-Buergerbeteiligung-vor-1937994.html"" title=""Piraten stellen Plattform zur Bürgerbeteiligung vor "">Piraten stellen Plattform zur Bürgerbeteiligung vor </a>
        </h3></header>
        <ul class=""indexlist_info"">
                <li class=""date"">heute, 12:49 Uhr</li>
                <li class=""kommentare nr50"">50<span class=""unsichtbar""> Kommentare</span></li> 
        </ul>
        <a href=""/newsticker/meldung/Piraten-stellen-Plattform-zur-Buergerbeteiligung-vor-1937994.html"" class=""indexlist_text"">
                <i class=""figure""><img src=""/imgs/18/1/0/6/3/7/6/2/Flagge_37508224_original.large-4-3-800-89-0-2898-2106-c097b9d499014a22.jpeg"" width=""100"" height=""75"" alt=""Piratenpartei-Flagge"" title=""Piratenpartei-Flagge"" /></i>
            <p>Die Piraten stellen mit &quot;OpenAntrag&quot; eine Plattform vor, auf der Bürger den Mandatsträgern der Partei Anträge vorschlagen können. Das Angebot soll Bürgerbeteiligung erleichtern.<span class=""indexlist_more""></span></p>
        </a>
    </section></div>
            
            
            
            
    <div class=""indexlist_item""><section>
        <header>
            
            <h3>
            <a href=""/newsticker/meldung/Weg-frei-fuer-Top-Level-Domain-hamburg-1938026.html"" title=""Weg frei für Top Level Domain &quot;.hamburg&quot;"">Weg frei für Top Level Domain &quot;.hamburg&quot;</a>
        </h3></header>
        <ul class=""indexlist_info"">
                <li class=""date"">heute, 12:45 Uhr</li>
                <li class=""kommentare nr66"">66<span class=""unsichtbar""> Kommentare</span></li> 
        </ul>
        <a href=""/newsticker/meldung/Weg-frei-fuer-Top-Level-Domain-hamburg-1938026.html"" class=""indexlist_text"">
                <i class=""figure""><img src=""/imgs/18/1/0/6/3/7/9/0/dothamburg-logo-klein-11ff10d97ddb049f.jpeg"" width=""100"" height=""20"" alt="""" title="""" /></i>
            <p>Die für die Adressvergabe im Internet zuständige globale Internetverwaltung ICANN hat  der Bewerbung  für den Betrieb der Domain-Endung &quot;.hamburg&quot;  entsprochen. Erste Domain-Registrierungen werden  in einem Jahr erwartet.<span class=""indexlist_more""></span></p>
        </a>
            <ul class=""indexlist_links"">
                <li><a href=""http://www.heise.de/meldung/Erste-Betreibervertraege-fuer-neue-Top-Level-Domains-unterzeichnet-1917973.html"">Erste Betreiberverträge für neue Top Level Domains unterzeichnet</a></li>
                <li><a href=""http://www.heise.de/meldung/Neue-Top-Level-Domains-ICANN-beschliesst-Oeffnung-des-Internet-Namensraums-1263102.html"">Neue Top Level Domains: ICANN beschließt Öffnung des Internet-Namensraums</a></li>
            </ul>
    </section></div>
    <div class=""indexlist_item""><section>
        <header>
            
            <h3>
            <a href=""/newsticker/meldung/Audiomarke-Beats-will-sich-von-HTC-trennen-1937996.html"" title=""Audiomarke Beats will sich von HTC trennen "">Audiomarke Beats will sich von HTC trennen </a>
        </h3></header>
        <ul class=""indexlist_info"">
                <li class=""date"">heute, 11:56 Uhr</li>
                <li class=""kommentare nr95"">95<span class=""unsichtbar""> Kommentare</span></li> 
        </ul>
        <a href=""/newsticker/meldung/Audiomarke-Beats-will-sich-von-HTC-trennen-1937996.html"" class=""indexlist_text"">
                <i class=""figure""><img src=""/imgs/18/1/0/6/3/7/6/4/Beats-0de384a246633631.jpeg"" width=""100"" height=""70"" alt="""" title="""" /></i>
            <p>Der US-amerikanischer Hersteller von Premium-Kopfhörern Beats by Dr. Dre will sich einem Medienbericht zufolge von HTC trennen. Dem taiwanischen Unternehmen sollen demnach dessen Firmenanteile abgekauft werden.<span class=""indexlist_more""></span></p>
        </a>
    </section></div>
    <div class=""indexlist_item""><section>
        <header>
            
            <h3>
            <a href=""/newsticker/meldung/Wikileaks-veroeffentlicht-neue-Insurance-Files-1937933.html"" title=""Wikileaks veröffentlicht neue &quot;Insurance Files&quot;"">Wikileaks veröffentlicht neue &quot;Insurance Files&quot;</a>
        </h3></header>
        <ul class=""indexlist_info"">
                <li class=""date"">heute, 11:38 Uhr</li>
                <li class=""kommentare nr79"">79<span class=""unsichtbar""> Kommentare</span></li> 
        </ul>
        <a href=""/newsticker/meldung/Wikileaks-veroeffentlicht-neue-Insurance-Files-1937933.html"" class=""indexlist_text"">
                <i class=""figure""><img src=""/imgs/18/1/0/6/3/7/2/8/Wikileaks-a1d1e5f10673a96d.jpeg"" width=""100"" height=""80"" alt="""" title="""" /></i>
            <p>Die Whistleblowing-Plattform Wikileaks hat drei neue &quot;Insurance Files&quot; veröffentlicht, verschlüsselte Dateien, zu denen jederzeit der Schlüssel veröffentlicht werden kann. Spekuliert wird, dass darin das Material von Edward Snowden enthalten ist.<span class=""indexlist_more""></span></p>
        </a>
    </section></div>
            
            
    <div class=""indexlist_item""><section>
        <header>
            
            <h3>
            <a href=""/newsticker/meldung/Apple-Veteranen-aeussern-sich-zu-Jobs-Film-1937829.html"" title=""Apple-Veteranen äußern sich zu &quot;Jobs&quot;-Film"">Apple-Veteranen äußern sich zu &quot;Jobs&quot;-Film</a>
        </h3></header>
        <ul class=""indexlist_info"">
                <li class=""date"">heute, 11:36 Uhr</li>
                <li class=""kommentare nr38"">38<span class=""unsichtbar""> Kommentare</span></li> 
        </ul>
        <a href=""/newsticker/meldung/Apple-Veteranen-aeussern-sich-zu-Jobs-Film-1937829.html"" class=""indexlist_text"">
                <i class=""figure""><img src=""/imgs/18/1/0/6/3/6/8/1/images-e9dd75c880f3b6c5-ff27b7b47c400396.png"" width=""100"" height=""100"" alt="""" title="""" /></i>
            <p>Daniel Kottke, Bill Fernandez und Steve Wozniak loben und kritisieren den Ashton-Kutcher-Streifen. An den US-Kinokassen konnte dieser unterdessen nicht überzeugen.<span class=""indexlist_more""></span></p>
        </a>
            <ul class=""indexlist_links"">
                <li><a href=""http://www.heise.de/meldung/Jobs-Film-bleibt-ohne-Tiefgang-1937519.html"">""Jobs""-Film bleibt ohne Tiefgang</a></li>
            </ul>
    </section></div>
            
            
    <div class=""indexlist_item""><section>
        <header>
            
            <h3>
            <a href=""/newsticker/meldung/Firefox-23-0-1-Ein-Update-fuers-Update-1937739.html"" title=""Firefox 23.0.1: Ein Update fürs Update"">Firefox 23.0.1: Ein Update fürs Update</a>
        </h3></header>
        <ul class=""indexlist_info"">
                <li class=""date"">heute, 10:49 Uhr</li>
                <li class=""kommentare nr52"">52<span class=""unsichtbar""> Kommentare</span></li> 
        </ul>
        <a href=""/newsticker/meldung/Firefox-23-0-1-Ein-Update-fuers-Update-1937739.html"" class=""indexlist_text"">
                <i class=""figure""><img src=""/imgs/18/1/0/6/3/6/1/1/firefox_newlogo-bb8877a2de28fb42.png"" width=""100"" height=""69"" alt="""" title="""" /></i>
            <p>Mit Version 23.0.1 behebt Mozilla im Firefox-Browser Darstellungsprobleme bei H.264-Videos, die bei Windows Vista aufgetreten waren. Außerdem wurden zwei weitere Fehler beseitigt.<span class=""indexlist_more""></span></p>
        </a>
            <ul class=""indexlist_links"">
                <li><a href=""http://www.heise.de/meldung/Firefox-23-mit-Teilen-Funktion-und-ohne-blink-1930833.html"">Firefox 23 mit Teilen-Funktion und ohne blink-Tag</a></li>
            </ul>
    </section></div>
    <div class=""indexlist_item""><section>
        <header>
            
            <h3>
            <a href=""/newsticker/meldung/NSA-Affaere-Partner-des-Enthuellers-Greenwald-festgehalten-1937741.html"" title=""NSA-Affäre: Partner des Enthüllers Greenwald festgehalten"">NSA-Affäre: Partner des Enthüllers Greenwald festgehalten</a>
        </h3></header>
        <ul class=""indexlist_info"">
                <li class=""date"">heute, 10:45 Uhr</li>
                <li class=""kommentare nr220"">220<span class=""unsichtbar""> Kommentare</span></li> 
        </ul>
        <a href=""/newsticker/meldung/NSA-Affaere-Partner-des-Enthuellers-Greenwald-festgehalten-1937741.html"" class=""indexlist_text"">
                <i class=""figure""><img src=""/imgs/18/1/0/6/3/6/1/3/displaymedia.ashx-cbcfcb1ec15de877.jpeg"" width=""100"" height=""67"" alt="""" title="""" /></i>
            <p>Der Lebenspartner des Journalisten Glenn Greenwald ist am Sonntag stundenlang auf dem Londoner Flughafen Heathrow festgehalten worden. Greenwald selbst vermutet einen Einschüchterungsversuch nach seinen NSA-Enthüllungen.<span class=""indexlist_more""></span></p>
        </a>
    </section></div>
            <div class=""bcadv""><script type=""text/javascript"">
<!--//--><![CDATA[//><!--
var dfp_ord; if (!dfp_ord) { dfp_ord = Math.floor(Math.random()*1000000000)+1000000000; }
document.write('<script src=""http://ad-emea.doubleclick.net/N6514/adj/newsticker/homepage;sz=4x4;tile=1;ord=_ORD_?"" type=""text/javascript""><\/script>'.replace('_ORD_', dfp_ord));
//--><!]]>
</script>
<noscript><div><a href=""http://ad-emea.doubleclick.net/N6514/jump/newsticker/homepage;sz=4x4;tile=1;ord=5050470231?"" target=""_blank""><img alt="""" src=""http://ad-emea.doubleclick.net/N6514/ad/newsticker/homepage;sz=4x4;tile=1;ord=5050470231?"" /></a></div></noscript>
</div>
    <div class=""indexlist_item""><section>
        <header>
            
            <h3>
            <a href=""/newsticker/meldung/United-Internet-kauft-spanischen-Webhoster-Arsys-1937772.html"" title=""United Internet kauft spanischen Webhoster Arsys"">United Internet kauft spanischen Webhoster Arsys</a>
        </h3></header>
        <ul class=""indexlist_info"">
                <li class=""date"">heute, 10:41 Uhr</li>
                <li class=""kommentare nr5"">5<span class=""unsichtbar""> Kommentare</span></li> 
        </ul>
        <a href=""/newsticker/meldung/United-Internet-kauft-spanischen-Webhoster-Arsys-1937772.html"" class=""indexlist_text"">
                <i class=""figure""><img src=""/imgs/18/1/0/6/3/6/3/0/nt-unitedinternet-fa5fefcf8a2d11e5.jpeg"" width=""100"" height=""77"" alt=""United Internet"" title=""United Internet"" /></i>
            <p>Der Internetdienstleister United Internet kauft das spanische Unternehmen Arsys. Der Kaufpreis für den Webhosting- und Cloud-Computing-Anbieter wurde mit bis zu 140 Millionen Euro beziffert.<span class=""indexlist_more""></span></p>
        </a>
    </section></div>
    <div class=""indexlist_item""><section>
        <header>
            
            <h3>
            <a href=""/newsticker/meldung/Internet-als-Taktgeber-Logistikbranche-sucht-schnelle-Standorte-1937727.html"" title=""Internet als Taktgeber: Logistikbranche sucht schnelle Standorte"">Internet als Taktgeber: Logistikbranche sucht schnelle Standorte</a>
        </h3></header>
        <ul class=""indexlist_info"">
                <li class=""date"">heute, 09:49 Uhr</li>
                <li class=""kommentare nr9"">9<span class=""unsichtbar""> Kommentare</span></li> 
        </ul>
        <a href=""/newsticker/meldung/Internet-als-Taktgeber-Logistikbranche-sucht-schnelle-Standorte-1937727.html"" class=""indexlist_text"">
                <i class=""figure""><img src=""/imgs/18/1/0/6/3/6/0/1/zalando_40269730_original.large-4-3-800-0-0-3635-2729-b3b71a81248b4bdf.jpeg"" width=""100"" height=""75"" alt=""Zalando"" title=""Zalando"" /></i>
            <p>Ein Mausklick und der Paketbote steht vor der Tür. Was Kunden glücklich machen soll, stellt die Unternehmen vor Herausforderungen. Amazon, Zalando, Redcoon und andere drängen an Standorte, wo die Post abgeht.
<span class=""indexlist_more""></span></p>
        </a>
    </section></div>
            
            
            
            
    <div class=""indexlist_item""><section>
        <header>
            
            <h3>
            <a href=""/newsticker/meldung/US-Politiker-besorgt-nach-neuen-NSA-Enthuellungen-1937632.html"" title=""US-Politiker besorgt nach neuen NSA-Enthüllungen"">US-Politiker besorgt nach neuen NSA-Enthüllungen</a>
        </h3></header>
        <ul class=""indexlist_info"">
                <li class=""date"">heute, 09:25 Uhr</li>
                <li class=""kommentare nr75"">75<span class=""unsichtbar""> Kommentare</span></li> 
        </ul>
        <a href=""/newsticker/meldung/US-Politiker-besorgt-nach-neuen-NSA-Enthuellungen-1937632.html"" class=""indexlist_text"">
                <i class=""figure""><img src=""/imgs/18/1/0/6/3/5/7/6/nsa_sign-649ffdde0190b1e8.jpeg"" width=""100"" height=""67"" alt="""" title="""" /></i>
            <p>Als US-Präsident Obama jüngst eine &quot;unabhängige&quot; Untersuchung der NSA-Spähprogramme ankündigte, waren dessen tausendfache Regelverstöße noch gar nicht öffentlich bekannt. Die neuesten Enthüllungen verschärfen die Skepsis im Kongress. <span class=""indexlist_more""></span></p>
        </a>
            <ul class=""indexlist_links"">
                <li><a href=""http://www.heise.de/meldung/NSA-raeumt-Fehler-ein-1937481.html"">NSA räumt Fehler ein</a></li>
                <li><a href=""http://www.heise.de/meldung/NSA-Tausende-Verstoesse-gegen-Regeln-zur-Ueberwachung-jedes-Jahr-1936705.html"">NSA: Tausende Verstöße gegen Regeln zur Überwachung – jedes Jahr</a></li>
            </ul>
    </section></div>
    <div class=""indexlist_item""><section>
        <header>
            
            <h3>
            <a href=""/newsticker/meldung/Musik-Player-Amarok-2-8-arbeitet-stromsparender-1937590.html"" title=""Musik-Player Amarok 2.8 arbeitet stromsparender "">Musik-Player Amarok 2.8 arbeitet stromsparender </a>
        </h3></header>
        <ul class=""indexlist_info"">
                <li class=""date"">heute, 08:58 Uhr</li>
                <li class=""kommentare nr75"">75<span class=""unsichtbar""> Kommentare</span></li> 
        </ul>
        <a href=""/newsticker/meldung/Musik-Player-Amarok-2-8-arbeitet-stromsparender-1937590.html"" class=""indexlist_text"">
                <i class=""figure""><img src=""/imgs/18/1/0/6/3/5/4/7/amarok_2.8_final_screenie-d22820538fd3ff2a.png"" width=""100"" height=""48"" alt="""" title="""" /></i>
            <p>Der im KDE-Projekt entwickelte, aber auch für Windows verfügbare Audio-Player Amarok 2.8 soll durch einige Performance-Optimierungen auch flotter auf Benutzereingaben reagieren.<span class=""indexlist_more""></span></p>
        </a>
    </section></div>
            
            
            
            
    <div class=""indexlist_item""><section>
        <header>
            
            <h3>
            <a href=""/newsticker/meldung/New-Economy-reloaded-Bundeswirtschaftsminister-will-Neuen-Markt-wiederbeleben-1937585.html"" title=""New Economy reloaded: Bundeswirtschaftsminister will Neuen Markt wiederbeleben"">New Economy reloaded: Bundeswirtschaftsminister will Neuen Markt wiederbeleben</a>
        </h3></header>
        <ul class=""indexlist_info"">
                <li class=""date"">heute, 08:17 Uhr</li>
                <li class=""kommentare nr43"">43<span class=""unsichtbar""> Kommentare</span></li>
                <li class=""update"">Update</li> 
        </ul>
        <a href=""/newsticker/meldung/New-Economy-reloaded-Bundeswirtschaftsminister-will-Neuen-Markt-wiederbeleben-1937585.html"" class=""indexlist_text"">
                <i class=""figure""><img src=""/imgs/18/1/0/6/3/5/4/2/BoersensaalFrankurt-540c2a29e15cdfe9.png"" width=""100"" height=""85"" alt="""" title="""" /></i>
            <p>Zielgruppe des &quot;neuen&quot; Neuen Markts sollen laut Florian Nöll, Chef des Bundesverbands Deutsche Startups, institutionelle Investoren und nicht Privatanleger sein: &quot;Wir wollen nicht die Fehler des Neuen Marktes wiederholen.&quot;<span class=""indexlist_more""></span></p>
        </a>
            <ul class=""indexlist_links"">
                <li><a href=""http://www.heise.de/meldung/Neuer-Markt-geht-TecDAX-kommt-76689.html"">Neuer Markt geht, TecDAX kommt</a></li>
                <li><a href=""http://www.heise.de/meldung/Aus-fuer-den-Neuen-Markt-wirft-Fragen-bei-Anlegern-auf-65219.html"">Aus für den Neuen Markt wirft Fragen bei Anlegern auf</a></li>
            </ul>
    </section></div>
    <div class=""indexlist_item""><section>
        <header>
            
            <h3>
            <a href=""/newsticker/meldung/Medienexperte-fordert-Digitalisierung-der-Kunst-1937583.html"" title=""Medienexperte fordert Digitalisierung der Kunst"">Medienexperte fordert Digitalisierung der Kunst</a>
        </h3></header>
        <ul class=""indexlist_info"">
                <li class=""date"">heute, 07:54 Uhr</li>
                <li class=""kommentare nr42"">42<span class=""unsichtbar""> Kommentare</span></li> 
        </ul>
        <a href=""/newsticker/meldung/Medienexperte-fordert-Digitalisierung-der-Kunst-1937583.html"" class=""indexlist_text"">
                <i class=""figure""><img src=""/imgs/18/1/0/6/3/5/4/0/Weibel_ZKM-4f8f9276c190711f.jpeg"" width=""67"" height=""100"" alt="""" title="""" /></i>
            <p>Die schwarz-gelbe Regierung habe in den vergangenen vier Jahren im Inland keinen einzigen relevanten Akzent in der Kultur gesetzt, meint der Leiter des Karlsruher Zentrums für Kunst und Medientechnologie.<span class=""indexlist_more""></span></p>
        </a>
    </section></div>
    <div class=""indexlist_item""><section>
        <header>
            
            <h3>
            <a href=""/newsticker/meldung/Computerspiel-hilft-Psychotherapeuten-1933427.html"" title=""Computerspiel hilft Psychotherapeuten"">Computerspiel hilft Psychotherapeuten</a>
        </h3></header>
        <ul class=""indexlist_info"">
                <li class=""date"">heute, 07:39 Uhr</li>
                <li class=""kommentare nr19"">19<span class=""unsichtbar""> Kommentare</span></li> 
        </ul>
        <a href=""/newsticker/meldung/Computerspiel-hilft-Psychotherapeuten-1933427.html"" class=""indexlist_text"">
                <i class=""figure""><img src=""/imgs/18/1/0/6/0/5/7/0/001-a8ed6e7f29ef3dec.png"" width=""100"" height=""60"" alt="""" title="""" /></i>
            <p>Jugendlichen fällt es oft schwer, sich bei psychischen Problemen Therapeuten gegenüber zu öffnen. Ein neues Videogame, das Forscher aus Großbritannien und Irland entwickelt haben, könnte helfen.<span class=""indexlist_more""></span></p>
        </a>
    </section></div>
    <div class=""indexlist_item""><section>
        <header>
            
            <h3>
            <a href=""/newsticker/meldung/AV-Comparatives-testet-Phishing-Filter-1937019.html"" title=""AV-Comparatives testet Phishing-Filter"">AV-Comparatives testet Phishing-Filter</a>
        </h3></header>
        <ul class=""indexlist_info"">
                <li class=""date"">heute, 07:00 Uhr</li>
                <li class=""kommentare nr9"">9<span class=""unsichtbar""> Kommentare</span></li> 
        </ul>
        <a href=""/newsticker/meldung/AV-Comparatives-testet-Phishing-Filter-1937019.html"" class=""indexlist_text"">
                <i class=""figure""><img src=""/imgs/18/1/0/6/3/0/7/0/phishing-7c2482f4f0473d4a.png"" width=""82"" height=""100"" alt="""" title="""" /></i>
            <p>Einige Testkandidaten glänzen mit Erkennungsraten von fast 100 Prozent. Getestet wurde allerdings nur Spam von gestern.<span class=""indexlist_more""></span></p>
        </a>
    </section></div>
    <div class=""indexlist_item""><section>
        <header>
            
            <h3>
            <a href=""/newsticker/meldung/Bericht-Apotheken-verkaufen-ungenuegend-anonymisierte-Patientendaten-1937568.html"" title=""Bericht: Apotheken verkaufen ungenügend anonymisierte Patientendaten"">Bericht: Apotheken verkaufen ungenügend anonymisierte Patientendaten</a>
        </h3></header>
        <ul class=""indexlist_info"">
                <li class=""date"">gestern, 17:45 Uhr</li>
                <li class=""kommentare nr162"">162<span class=""unsichtbar""> Kommentare</span></li>
                <li class=""update"">Update</li> 
        </ul>
        <a href=""/newsticker/meldung/Bericht-Apotheken-verkaufen-ungenuegend-anonymisierte-Patientendaten-1937568.html"" class=""indexlist_text"">
                <i class=""figure""><img src=""/imgs/18/1/0/6/3/5/2/7/0eef9fd37fbc4b58-5a8e48a3595c50cb.jpeg"" width=""100"" height=""62"" alt="""" title="""" /></i>
            <p>Das Apotheken-Rechenzentrum VSA soll Marktforschungsunternehmen Rezeptdaten verkaufen, aus denen sich die Versichertennummern der Patienten errechnen lassen.<span class=""indexlist_more""></span></p>
        </a>
    </section></div>
    <div class=""indexlist_item""><section>
        <header>
            
            <h3>
            <a href=""/newsticker/meldung/Vodafone-Sondertarif-fuer-Ingress-Spieler-1937563.html"" title=""Vodafone: Sondertarif für Ingress-Spieler"">Vodafone: Sondertarif für Ingress-Spieler</a>
        </h3></header>
        <ul class=""indexlist_info"">
                <li class=""date"">gestern, 14:05 Uhr</li>
                <li class=""kommentare nr129"">129<span class=""unsichtbar""> Kommentare</span></li> 
        </ul>
        <a href=""/newsticker/meldung/Vodafone-Sondertarif-fuer-Ingress-Spieler-1937563.html"" class=""indexlist_text"">
                <i class=""figure""><img src=""/imgs/18/1/0/6/3/5/2/2/Ingress_Logo-b0edc522f2c72ce2.png"" width=""100"" height=""100"" alt="""" title="""" /></i>
            <p>Mit einem neuen Prepaid-Tarif für Ingress-Spieler verstärkt Vodafone seine Aktivitäten im Bereich von Googles Augumented-Reality-Spiel. Google-Tochter Niantic bemüht sich derweil, das Spiel für Fortgeschrittene interessanter zu gestalten. <span class=""indexlist_more""></span></p>
        </a>
    </section></div>
</div>

        
        
        
        





    <p class=""seitenweise_navigation""><span class=""seite_zurueck"">Neuere</span><a href=""/?seite=1"" class=""seite_weiter"">Ältere</a></p>

    </div>

        <h4 class=""weitere""><a href=""/newsticker/"">Weitere Meldungen im News-Überblick</a></h4>
        <p class=""nachricht"">Fehlt eine wichtige Nachricht? Geben Sie uns <a href=""mailto:newstips@heise.de"">Bescheid</a>! <br /></p>
</div>

<div>
    <img src=""/icons/ho/00on.gif"" width=""1"" height=""1"" alt="""" />
    <noscript>
    <div><img src=""/icons/ho/00off.gif"" width=""1"" height=""1"" alt="""" /></div>
    </noscript>
</div>

<div class=""promoad""></div>

            <!--googleoff: all-->
            <div class=""adbottom"">                        <a href=""http://www.heise.de/avw-bin/ivw/CP/hp-dc-pre"" target=""_blank""><img alt="""" src=""http://www.heise.de/avw-bin/ivw/CP/hp-dc-pre"" /></a>                <script type=""text/javascript"">
<!--//--><![CDATA[//><!--
var dfp_ord; if (!dfp_ord) { dfp_ord = Math.floor(Math.random()*1000000000)+1000000000; }
document.write('<script src=""http://ad-emea.doubleclick.net/N6514/adj/newsticker/homepage;sz=500x500;tile=2;ord=_ORD_?"" type=""text/javascript""><\/script>'.replace('_ORD_', dfp_ord));
if (typeof jQuery != 'undefined') {
    jQuery( function() {
        jQuery('.adbottom div[id^=google_ads_div_]').parent().prepend('<span style=""font-family: Arial, Helvetica, sans-serif; color: Black; font-size:7pt; font-weight: normal; text-align: left;"">Anzeige</span><br/>');
    });
}

//--><!]]>
</script>
<noscript><div><a href=""http://ad-emea.doubleclick.net/N6514/jump/newsticker/homepage;sz=500x500;tile=2;ord=5050470231?"" target=""_blank""><img alt="""" src=""http://ad-emea.doubleclick.net/N6514/ad/newsticker/homepage;sz=500x500;tile=2;ord=5050470231?"" /></a></div></noscript>

            </div>
            
            
                </div>
                <div id=""mitte_rechts"">
                
                
                
                    
                        
                            <!--googleoff: index-->
<!-- RSPEAK_STOP -->
<div  class=""bcadv ISI_IGNORE""><a href=""http://www.heise.de/mediadaten/online/"" target=""_blank"" class=""hinweis_anzeige"">Anzeige</a><br><script type=""text/javascript"">
<!--//--><![CDATA[//><!--
var dfp_ord; if (!dfp_ord) { dfp_ord = Math.floor(Math.random()*1000000000)+1000000000; }
document.write('<script src=""http://ad-emea.doubleclick.net/N6514/adj/newsticker/homepage;sz=300x250,336x280;tile=3;ord=_ORD_?"" type=""text/javascript""><\/script>'.replace('_ORD_', dfp_ord));
//--><!]]>
</script>
<noscript><div><a href=""http://ad-emea.doubleclick.net/N6514/jump/newsticker/homepage;sz=300x250,336x280;tile=3;ord=5050470231?"" target=""_blank""><img alt="""" src=""http://ad-emea.doubleclick.net/N6514/ad/newsticker/homepage;sz=300x250,336x280;tile=3;ord=5050470231?"" /></a></div></noscript>
</div>
<!-- RSPEAK_START -->
<!--googleon: index--><!--googleoff: all--><!-- RSPEAK_STOP -->
                        
                        
                            
                                <!-- Keine Top-News -->
                            
                            
    
        <div class=""teaser_left"">
            <p>
                <a href=""/ct/artikel/PowerPoint-kann-auch-anders-1931693.html""><img src=""/imgs/02/1/0/6/0/3/8/6/ct.1813.090-095.neu1_Seite_1_Bild_0001-f698ea4ca15e878a.jpeg"" alt="""" style=""margin-bottom: 3px;"" /></a><br />
                <b class=""size80"">c't</b><br />
                <a href=""/ct/artikel/PowerPoint-kann-auch-anders-1931693.html""><b>Besser präsentieren</b></a><br />
                <span class=""size80"">Ein lebendiger Vortrag braucht kreative Ideen und eine gute Präsentation. Die kann man klassisch mit PowerPoint machen, es gibt aber auch spannende Alternativen, mit denen Sie mit wenig Aufwand große Wirkung erzielen.</span>
            </p>
            <div class=""clear""></div>
        </div>
    



                            
    
        <div class=""teaser_right"">
            <p>
                <a href=""/resale/artikel/Das-deutsche-Arbeitsrecht-mag-den-Whistleblower-nicht-1925100.html""><img src=""/imgs/02/1/0/6/3/5/6/8/Pfeife-8f6dc3c2bf1ef1b3.jpeg"" alt=""Trillerpfeife"" style=""margin-bottom: 3px;"" /></a><br />
                <b class=""size80"">heise resale -Recht</b><br />
                <a href=""/resale/artikel/Das-deutsche-Arbeitsrecht-mag-den-Whistleblower-nicht-1925100.html""><b>&quot;Deutsches Arbeitsrecht mag Whistleblower nicht&quot;</b></a><br />
                <span class=""size80"">Der Fall Edward Snowden zeigt: Wer seinen Arbeitgeber an den Pranger stellt, steht anschließend ziemlich alleine da.</span>
            </p>
            <div class=""clear""></div>
        </div>
    



                            
    
        <div class=""teaser_right"">
            <p>
                <a href=""/security/artikel/Verwurmt-verphisht-verspamt-E-Mail-ist-kaputt-1884608.html""><img src=""/imgs/02/1/0/3/5/5/3/6/Actions-mail-mark-junk-icon-4456ade30171295d.png"" alt="""" style=""margin-bottom: 3px;"" /></a><br />
                <b class=""size80"">heise security</b><br />
                <a href=""/security/artikel/Verwurmt-verphisht-verspamt-E-Mail-ist-kaputt-1884608.html""><b>Verwurmt, verphisht, verspamt</b></a><br />
                <span class=""size80"">Echte Firmen-E-Mails sind kaum noch von Phishingmails zu unterscheiden. Trotzdem sollen Kunden den Durchblick behalten. Das kann nicht funktionieren.</span>
            </p>
            <div class=""clear""></div>
        </div>
    



                            
    
        <div class=""teaser_right"">
            <p>
                <a href=""/tr/artikel/Halb-Kuh-halb-Maschine-1874532.html""><img src=""/imgs/02/7/6/3/3/4/4/artificial.heart_130x75-c0f7daab46a7ba56.png"" alt=""Künstliches Herz von Carmat"" style=""margin-bottom: 3px;"" /></a><br />
                <b class=""size80"">Technology Review</b><br />
                <a href=""/tr/artikel/Halb-Kuh-halb-Maschine-1874532.html""><b>Halb Kuh, halb Maschine</b></a><br />
                <span class=""size80"">Ein französisches Unternehmen hat ein Kunstherz entwickelt, das im Vergleich zu bisherigen Apparaten bioverträglicher ist und ohne eine Steuereinheit außerhalb des Körpers auskommt.</span>
            </p>
            <div class=""clear""></div>
        </div>
    



                            
                                
    
    
    <p class=""us_ad"">
        <span><a href=""/mediadaten/online/"" target=""_blank"">Anzeige</a></span><br>
        <a href=""http://pubads.g.doubleclick.net/gampad/clk?id=25250990&amp;iu=/6514/extras/usad"" rel=""external""><img src=""/imgs/02/1/0/5/6/7/7/4/usAd_infoblox_2107-91ddcf44d20fdde6.jpg"" width=""336"" height=""200"" alt=""""></a>
        <script type=""text/javascript"">
        <!--//--><![CDATA[//><!--
            (function (){
                var AVW = '<' + 'img id=""avw_pixel_intern"" src=""/avw-bin/ivw/CP/barfoo/ho/1927981/20.gif?d=_ORD_"" width=""1"" height=""1"" alt="""">'.replace('_ORD_', Math.floor(Math.random()*1000000000)+1000000000);
                document.write(AVW);
            })();
        //--><!]]>
        </script>
        <noscript><img id=""avw_pixel_intern"" src=""/avw-bin/ivw/CP/barfoo/ho/1927981/20.gif"" width=""1"" height=""1"" alt=""""></noscript>
    </p>
     



                                
    <div class=""teaser_adliste"">
        <p>Werbung</p>
        <ul class=""microsites"">
        
            <li><a href=""http://pubads.g.doubleclick.net/gampad/clk?id=24935630&amp;iu=/6514/microsite/mailstore"" rel=""nofollow"">Moderne E-Mail-Archivierung mit MailStore</a></li>
        
            <li><a href=""http://www.heise.de/whitepapers/Analyse-Botnetze-was-dahintersteckt-und-wie-man-sich-vor-ihnen-schuetzen-kann--/detail/2073"" rel=""nofollow"">So schützen Sie sich vor Botnetzen!</a></li>
        
            <li><a href=""http://webcasts.heise.de/server-storage/so-reduzieren-sie-die-komplexitaet-im-modernen-rechenzentrum/?source=HP_04_12_TL"" rel=""nofollow"">Webcast: Komplexität im Rechenzentrum reduzieren</a></li>
        
            <li><a href=""http://webcasts.heise.de/security/prism-und-die-folgen-was-wirtschaftsspionage-kann-und-wie-firmen-sich-davor-schuetzen-koennen/?source=KASP_08_2013_TL"" rel=""nofollow"">Live Webcast: So schützen Sie sich vor Spionage</a></li>
        
            <li><a href=""http://webcasts.heise.de/dellsoftware/big-data-komplexe-daten/?source=DellSW_05_09_13_TL"" rel=""nofollow"">Webcast: Daten aus verschiedenen Quellen analysieren</a></li>
        
            <li><a href=""http://www.mittelstandswiki.de/"" rel=""nofollow"">MittelstandsWiki: Themen für Unternehmen</a></li>
        
        </ul>
    </div>
    


                            
                            <script type=""text/javascript"">
<!--//--><![CDATA[//><!--
var dfp_ord; if (!dfp_ord) { dfp_ord = Math.floor(Math.random()*1000000000)+1000000000; }
document.write('<script src=""http://ad-emea.doubleclick.net/N6514/adj/newsticker/homepage;sz=2x1;tile=4;ord=_ORD_?"" type=""text/javascript""><\/script>'.replace('_ORD_', dfp_ord));
//--><!]]>
</script>
<noscript><div><a href=""http://ad-emea.doubleclick.net/N6514/jump/newsticker/homepage;sz=2x1;tile=4;ord=5050470231?"" target=""_blank""><img alt="""" src=""http://ad-emea.doubleclick.net/N6514/ad/newsticker/homepage;sz=2x1;tile=4;ord=5050470231?"" /></a></div></noscript>

                            
                            
    
        <div class=""teaser_right"">
            <p>
                <a href=""/mac-and-i/heft/""><img src=""/imgs/02/1/0/4/5/8/3/5/Titelbild-8c7026b223525599.jpeg"" alt="""" style=""margin-bottom: 3px;"" /></a><br />
                
                <a href=""/mac-and-i/heft/""><b>Mac &amp; i Heft 11</b></a><br />
                <span class=""size80"">Mac OS X 10.9 und iOS 7 • Endlich gute Videos • Datenschnüffler aussperren • Sicher ins heimische Netz mit VPN • Akkuwechsel beim iPhone 3GS • VoiceOver • Kopfhörer • Twitter-Clients • MacBook Air • Objektive und Mikros • Textbaustein-Tools</span>
            </p>
            <div class=""clear""></div>
        </div>
    



                            
    
        <div class=""teaser_right"">
            <p>
                <a href=""/hardware-hacks/artikel/Angetestet-Pi-Camera-1874976.html""><img src=""/imgs/02/1/0/3/1/7/3/4/camera_aus-55edffbdb566b178.jpeg"" alt="""" style=""margin-bottom: 3px;"" /></a><br />
                <b class=""size80"">Hardware Hacks: Angetestet</b><br />
                <a href=""/hardware-hacks/artikel/Angetestet-Pi-Camera-1874976.html""><b>Die Pi Camera</b></a><br />
                <span class=""size80"">Die günstige Raspberry Pi Camera liefert Videos im HD-Format und lässt sich dank der guten Software-Unterstützung schnell in Betrieb nehmen.</span>
            </p>
            <div class=""clear""></div>
        </div>
    



                            
    
        <div class=""teaser_left"">
            <p>
                <a href=""http://shop.heise.de/technology-review-energie""><img src=""/imgs/02/9/8/4/5/5/8/TR_teaser.jpg-d9d180f1b115d97f.jpeg"" alt="""" style=""margin-bottom: 3px;"" /></a><br />
                <b class=""size80"">Technology Review</b><br />
                <a href=""http://shop.heise.de/technology-review-energie""><b>Special Energie </b></a><br />
                <span class=""size80"">Auf 148 Seiten: Fakten zur Energiewende, zu den Themenbereichen Fossile Brennstoffe, Wind- und Sonnenkraft, Stromnetz und Speicher, Verkehr, Energie sparen und Atommüll, Dokumentarfilm &quot;Leben mit der Energiewende&quot; </span>
            </p>
            <div class=""clear""></div>
        </div>
    



                            
    
        <div class=""teaser_right"">
            <p>
                <a href=""/meldung/Test-Canon-EOS-100D-plus-Kit-Objektiv-1902058.html""><img src=""/imgs/02/8/2/3/6/7/8/EOS_100D_FRT_w_EF-S_18-55mm_IS_STM-bc8545bec696b409.png"" alt=""heise Foto, Test, Spiegelreflexkamera, DSLR, Canon 100D, c't Digitale Fotografie"" style=""margin-bottom: 3px;"" /></a><br />
                <b class=""size80"">heise Foto</b><br />
                <a href=""/meldung/Test-Canon-EOS-100D-plus-Kit-Objektiv-1902058.html""><b>Test: Canon EOS 100D plus Kit-Objektiv</b></a><br />
                <span class=""size80"">Großer Sensor, kleines Gehäuse: Canon will mit der neuen EOS 100D vor allem den spiegellosen Systemkameras Konkurrenz machen. Aber wie schlägt sich die Kamera in puncto Bildqualität? Wir haben den Test gemacht.</span>
            </p>
            <div class=""clear""></div>
        </div>
    



                            
    
        <div class=""teaser_right"">
            <p>
                <a href=""/autos/artikel/IAA-2013-Das-zeigen-die-Hersteller-auf-der-Messe-1931747.html""><img src=""/imgs/02/3/9/8/2/3/9/11-62cc55acf04ff5b6.jpeg"" alt="""" style=""margin-bottom: 3px;"" /></a><br />
                <b class=""size80"">heise Autos</b><br />
                <a href=""/autos/artikel/IAA-2013-Das-zeigen-die-Hersteller-auf-der-Messe-1931747.html""><b>Show-View</b></a><br />
                <span class=""size80"">Auf der IAA 2013 zeigen die Hersteller wieder zahlreiche Neuheiten</span>
            </p>
            <div class=""clear""></div>
        </div>
    



                            <script type=""text/javascript"">
    $(document).ready( function() {
        $('div#software_tabbox').tabs();
    });
</script>

<div id=""software_tabbox"">
    <h4><a href=""http://www.heise.de/download/"" title=""heise Software-Verzeichnis"">Software-Verzeichnis</a></h4>
    
    <p class=""teaser_mit_bild_und_text"">
	<a href=""http://www.heise.de/download/special-app-auf-die-reise-150931.html"" title=""Themen-Special: Apps f&uuml;r den Urlaub""><img src=""http://www.heise.de/software/screenshots/sps931.jpg"" alt="""" /></a>
	<span class=""titelzeile""><a href=""http://www.heise.de/download/special-app-auf-die-reise-150931.html"" title=""Themen-Special: Apps f&uuml;r den Urlaub"">Apps f&uuml;r den Urlaub</a></span>
	<span class=""textzeile"">Themen-Special: Die Apps f&uuml;r iOS und Android bereiten die Reise vor, finden Bars und Restaurants und liefern Wissen zu Sehensw&uuml;rdigkeiten</span>
    </p>
    

    <ul>
	<li><a href=""#software_tabs-1"" class=""update"">Updates</a></li>
	<li><a href=""#software_tabs-2"" class=""neu"">Neuzug&auml;nge</a></li>
	<li><a href=""#software_tabs-3"" class=""top"">Top-5</a></li>
	<li><a href=""#software_tabs-4"" class=""best"">Bestbewertet</a></li>
    </ul>    

    
    <div id=""software_tabs-1"">
	
	    <p class=""teaser_mit_bild_und_text"">
		<a href=""http://www.heise.de/download/video-lightbox-1167538.html"" title=""Video LightBox f&uuml;r Windows XP, Vista, 7, Mac OS X, Mac OS X/Intel"">Video LightBox</a>
		<span class=""info"">Ver&ouml;ffentlicht via integriertem FTP-Client eigene Videos auf Webseiten oder Blogs und bietet diverse Vorlagen zum Gestalten der Video-Pop-ups sowie&nbsp;...</span>
	    </p>
	
	    <p class=""teaser_mit_bild_und_text"">
		<a href=""http://www.heise.de/download/shellexview-1144402.html"" title=""ShellExView f&uuml;r Windows 98, ME, NT, 2000, XP, Server 2003, Vista, 7"">ShellExView</a>
		<span class=""info"">Verwaltet alle auf einem Rechner befindlichen Shell-Erweiterungen, gibt detaillierte Informationen zu ihnen aus und kann einzelne Erweiterungen&nbsp;...</span>
	    </p>
	
	    <p class=""teaser_mit_bild_und_text"">
		<a href=""http://www.heise.de/download/higan-1191338.html"" title=""higan f&uuml;r Windows XP, Vista, 7, 8, Linux, Mac OS X, Mac OS X/Intel"">higan</a>
		<span class=""info"">Fr&uuml;her unter dem Namen bsnes entwickelter Multi-System-Emulator; der Fokus liegt weiterhin auf der Emulation des SNES, unterst&uuml;tzt inzwischen aber&nbsp;...</span>
	    </p>
	
	    <p class=""teaser_mit_bild_und_text"">
		<a href=""http://www.heise.de/download/flashfxp-1154953.html"" title=""FlashFXP f&uuml;r Windows 95, 98, ME, NT, 2000, XP, Vista, 7"">FlashFXP</a>
		<span class=""info"">Mehrsprachiger Client, der den Rechner mit einem FTP-Server verbindet, etwa zum Hoch- und Herunterladen von Dateien&nbsp;...</span>
	    </p>
	
	    <p class=""teaser_mit_bild_und_text"">
		<a href=""http://www.heise.de/download/ghostdoc-1142255.html"" title=""GhostDoc f&uuml;r Windows 2000, XP, Server 2003, Vista, 7"">GhostDoc</a>
		<span class=""info"">Add-in f&uuml;r Visual Studio, das automatisch Kommentare zur XML-Dokumentation hinzuf&uuml;gt&nbsp;...</span>
	    </p>
	
	<p class=""rss"">
	    <a href=""http://www.heise.de/download/updates-50000304000/"" title=""Alle Updates im heise Software-Verzeichnis"">Alle Updates</a>
	</p>
    </div>
    
    <div id=""software_tabs-2"">
	
	    <p class=""teaser_mit_bild_und_text"">
		<a href=""http://www.heise.de/download/listen-on-repeat-1192248.html"" title=""Listen On Repeat f&uuml;r Windows XP, Server 2003, Server 2008, Server 2012, Vista, 7, 8, Linux, Mac OS X, Mac OS X/Intel, Android"">Listen On Repeat</a>
		<span class=""info"">Erm&ouml;glicht das automatisch wiederholte Abspielen von Videos des Video-Streaming-Portals YouTube&nbsp;...</span>
	    </p>
	
	    <p class=""teaser_mit_bild_und_text"">
		<a href=""http://www.heise.de/download/gods-will-be-watching-1192098.html"" title=""Gods Will Be Watching f&uuml;r Windows XP, Server 2003, Server 2008, Server 2012, Vista, 7, 8, Linux, Mac OS X, Mac OS X/Intel"">Gods Will Be Watching</a>
		<span class=""info"">Futuristische &Uuml;berlebenssimulation in Pixel-Grafik; als Anf&uuml;hrer einer gestrandeten Raumschiffbesatzung gilt es, f&uuml;r 40 Tage das &Uuml;berleben der Gruppe&nbsp;...</span>
	    </p>
	
	    <p class=""teaser_mit_bild_und_text"">
		<a href=""http://www.heise.de/download/konto-check-1191953.html"" title=""konto_check f&uuml;r Windows XP, Server 2003, Server 2008, 7, DOS, Linux, Mac OS, Mac OS X"">konto_check</a>
		<span class=""info"">C-Bibliothek, um Angaben zu deutschen und &ouml;sterreichischen Bankkonten auf G&uuml;ltigkeit zu &uuml;berpr&uuml;fen&nbsp;...</span>
	    </p>
	
	    <p class=""teaser_mit_bild_und_text"">
		<a href=""http://www.heise.de/download/xcad-interior-1192139.html"" title=""xCAD Interior f&uuml;r Windows XP, Vista, 7, 8"">xCAD Interior</a>
		<span class=""info"">3D-CAD-Programm f&uuml;r Innenarchitektur und M&ouml;belbau; bietet unter anderem allgemeine und Detail-Konstruktion in Echtzeit, umfangreiche Objekt- und&nbsp;...</span>
	    </p>
	
	    <p class=""teaser_mit_bild_und_text"">
		<a href=""http://www.heise.de/download/urbex-1192101.html"" title=""Urbex f&uuml;r Windows XP, Server 2003, Server 2008, Server 2012, Vista, 7, 8, Linux, Mac OS X, Mac OS X/Intel, Android"">Urbex</a>
		<span class=""info"">D&uuml;steres Point-and-Click-Abenteuer, bei dem man sich durch einen verfallenden Geb&auml;udekomplex bewegt&nbsp;...</span>
	    </p>
	
	<p class=""rss"">
	    <a href=""http://www.heise.de/download/neuzugaenge-50000311000/"" title=""Alle Neuzug&auml;nge im heise Software-Verzeichnis"">Alle Neuzug&auml;nge</a>
	</p>
    </div>
    
    <div id=""software_tabs-3"">
	
	    <p class=""teaser_mit_bild_und_text"">
		<a href=""http://www.heise.de/download/ghostscript.html"" title=""Ghostscript f&uuml;r Windows XP, Vista, 7, 8, Linux"">Ghostscript</a>
		<span class=""info"">Wandelt PostScript-, EPS- und PDF-Dateien in Bitmaps um und druckt sie aus; ist Grundlage f&uuml;r viele weitere PDF-Konverter und -Drucker</span>
	    </p>
	
	    <p class=""teaser_mit_bild_und_text"">
		<a href=""http://www.heise.de/download/irfanview.html"" title=""IrfanView f&uuml;r Windows 2000, XP, Vista, 7, 8"">IrfanView</a>
		<span class=""info"">Schneller Viewer f&uuml;r eine Vielzahl von Bildformaten; spielt &uuml;ber Plug-ins auch andere Multimedia-Formate ab und kann Bilder mit diversen Effekten&nbsp;...</span>
	    </p>
	
	    <p class=""teaser_mit_bild_und_text"">
		<a href=""http://www.heise.de/download/windows-xp-service-pack-3-sp3.html"" title=""Windows XP Service Pack 3 (SP3) f&uuml;r Windows XP"">Windows XP Service Pack 3 (SP3)</a>
		<span class=""info"">Aktualisiert alle 32-Bit-Versionen von Windows XP; Voraussetzung f&uuml;r die Installation ist ein bereits installiertes Windows XP Service Pack 1 oder 2 </span>
	    </p>
	
	    <p class=""teaser_mit_bild_und_text"">
		<a href=""http://www.heise.de/download/h2testw.html"" title=""H2testw f&uuml;r Windows 2000, XP, Server 2003, Server 2008, Vista, 7, 8"">H2testw</a>
		<span class=""info"">Integrit&auml;tstest f&uuml;r Datentr&auml;ger, vor allem zur Erkennung manipulierter USB-Sticks&nbsp;...</span>
	    </p>
	
	    <p class=""teaser_mit_bild_und_text"">
		<a href=""http://www.heise.de/download/putty.html"" title=""PuTTY f&uuml;r Windows 95, 98, ME, NT, 2000, XP, Vista, 7, Linux, Mac OS X/Intel"">PuTTY</a>
		<span class=""info"">SSH-, Telnet- und Rlogin-Client mit einem xterm-Terminal-Emulator; zus&auml;tzlich erh&auml;ltliche Versionen sind PuTTY Portable und PuTTY f&uuml;r&nbsp;...</span>
	    </p>
	
	<p class=""rss"">
	    <a href=""http://www.heise.de/download/top-downloads-50000505000/"" title=""Alle Top-Downloads im heise Software-Verzeichnis"">Alle Top-Downloads</a>
	</p>
    </div>
    
    <div id=""software_tabs-4"">
	
	    <p class=""teaser_mit_bild_und_text"">
		<a href=""http://www.heise.de/download/firefox.html"" title=""Firefox f&uuml;r Windows XP, Server 2003, Server 2008, Server 2012, Vista, 7, 8, Linux, Mac OS X/Intel, Android"">Firefox</a>
		<span class=""info"">M&auml;chtiger Browser, unter anderem mit PDF-Betrachter, Popup-Blocker, Malware-Schutz, Tabbed-Browsing und zahlreichen optionalen Erweiterungen&nbsp;...</span>
	    </p>
	
	    <p class=""teaser_mit_bild_und_text"">
		<a href=""http://www.heise.de/download/irfanview.html"" title=""IrfanView f&uuml;r Windows 2000, XP, Vista, 7, 8"">IrfanView</a>
		<span class=""info"">Schneller Viewer f&uuml;r eine Vielzahl von Bildformaten; spielt &uuml;ber Plug-ins auch andere Multimedia-Formate ab und kann Bilder mit diversen Effekten&nbsp;...</span>
	    </p>
	
	    <p class=""teaser_mit_bild_und_text"">
		<a href=""http://www.heise.de/download/notepad.html"" title=""Notepad++ f&uuml;r Windows XP, Server 2003, Server 2008, Server 2012, Vista, 7, 8"">Notepad++</a>
		<span class=""info"">Leistungsf&auml;higer Code-Editor mit Syntax-Hervorhebung und Auto-Vervollst&auml;ndigung&nbsp;...</span>
	    </p>
	
	    <p class=""teaser_mit_bild_und_text"">
		<a href=""http://www.heise.de/download/truecrypt.html"" title=""TrueCrypt f&uuml;r Windows XP, Vista, 7, Linux, Mac OS X, Mac OS X/Intel"">TrueCrypt</a>
		<span class=""info"">Legt verschl&uuml;sselte Festplattenpartitionen an, die nur unter Zuhilfenahme des richtigen Passworts gelesen und beschrieben werden k&ouml;nnen&nbsp;...</span>
	    </p>
	
	    <p class=""teaser_mit_bild_und_text"">
		<a href=""http://www.heise.de/download/vlc-media-player.html"" title=""VLC media player f&uuml;r Windows XP, Vista, 7, 8, Linux, Mac OS X, Mac OS X/Intel, iOS, Android"">VLC media player</a>
		<span class=""info"">Universeller Player f&uuml;r praktisch alle Audio- und Video-Formate; bietet unter anderem Filter sowie weitere Videobearbeitungs-Funktionen&nbsp;...</span>
	    </p>
	
	<p class=""rss"">
	    <a href=""http://www.heise.de/download/bestbewertet-50000606000/"" title=""Alle am besten bewerteten Programme im heise Software-Verzeichnis"">Alle am besten bewerteten Programme</a>
	</p>
    </div>
    

</div>

                            
    <script type=""text/javascript"">
        $(document).ready( function() {
            $('div#teaser_top_beitrag').tabs();
        });
    </script>
    <div id=""teaser_top_beitrag"">
        <ul id=""teaser_top_beitrag_titel"">
            <li><a href=""#meistgelesen"">Meistgelesen</a></li>
            <li><a href=""#meistkommentiert"">Meistkommentiert</a></li>
        </ul>
        <div id=""meistgelesen"" >
            <ul>
                <li><a href=""/meldung/Microsoft-warnt-erneut-vor-zukuenftigen-XP-Sicherheitsluecken-1937554.html"">Microsoft warnt erneut vor zukünftigen XP-Sicherheitslücken</a></li>
                <li><a href=""/meldung/Kleiner-Google-Ausfall-grosse-Wirkung-1937477.html"">Kleiner Google-Ausfall, große Wirkung</a></li>
                <li><a href=""/meldung/Windows-Sicherheits-Update-macht-Probleme-1937509.html"">Windows Sicherheits-Update macht Probleme</a></li>
                <li><a href=""/meldung/Illegale-Notenkopien-bei-der-katholischen-Kirche-1937475.html"">Illegale Notenkopien bei der katholischen Kirche</a></li>
                <li><a href=""/meldung/Jobs-Film-bleibt-ohne-Tiefgang-1937519.html"">""Jobs""-Film bleibt ohne Tiefgang</a></li>
            </ul>
        </div>
        <div id=""meistkommentiert"">
            <ul>
            
  
    <li>
      <a href=""/newsticker/meldung/Microsoft-warnt-erneut-vor-zukuenftigen-XP-Sicherheitsluecken-1937554.html"">
	Microsoft warnt erneut vor zukünftigen XP-Sicherheitslücken
      </a>
    </li>
  
    <li>
      <a href=""/newsticker/meldung/NSA-Affaere-Partner-des-Enthuellers-Greenwald-festgehalten-1937741.html"">
	NSA-Affäre: Partner des Enthüllers Greenwald festgehalten
      </a>
    </li>
  
    <li>
      <a href=""/newsticker/meldung/Bericht-Apotheken-verkaufen-ungenuegend-anonymisierte-Patientendaten-1937568.html"">
	Bericht: Apotheken verkaufen ungenügend anonymisierte Patientendaten
      </a>
    </li>
  
    <li>
      <a href=""/newsticker/meldung/Illegale-Notenkopien-bei-der-katholischen-Kirche-1937475.html"">
	Illegale Notenkopien bei der katholischen Kirche
      </a>
    </li>
  
    <li>
      <a href=""/newsticker/meldung/Vodafone-Sondertarif-fuer-Ingress-Spieler-1937563.html"">
	Vodafone: Sondertarif für Ingress-Spieler
      </a>
    </li>
  


            </ul>
        </div>
    </div>



                            <div class=""naviad""><script type=""text/javascript"">
<!--//--><![CDATA[//><!--
var dfp_ord; if (!dfp_ord) { dfp_ord = Math.floor(Math.random()*1000000000)+1000000000; }
document.write('<script src=""http://ad-emea.doubleclick.net/N6514/adj/newsticker/homepage;sz=336x200;tile=5;ord=_ORD_?"" type=""text/javascript""><\/script>'.replace('_ORD_', dfp_ord));
//--><!]]>
</script>
<noscript><div><a href=""http://ad-emea.doubleclick.net/N6514/jump/newsticker/homepage;sz=336x200;tile=5;ord=5050470231?"" target=""_blank""><img alt="""" src=""http://ad-emea.doubleclick.net/N6514/ad/newsticker/homepage;sz=336x200;tile=5;ord=5050470231?"" /></a></div></noscript>
</div>
                            <div class=""clear""></div>
                            
<div class=""teaser_liste_foren"">
    <h4><a href=""/foren/"" title=""Neueste Foren-Beitr&auml;ge"">Neueste Foren-Beitr&auml;ge</a></h4>

	<ul>
  	
    	<li>
      		<a href=""/security/news/foren/S-Re-Whistle-im-Golem-hochgelobt/forum-263258/msg-23977838/read/"" title=""WhatsApp, Whistle: unsichere Instant Messenger"">Re: Whistle.im @ Golem hochgelobt</a>
    	</li>
  		
    	<li>
      		<a href=""/mac-and-i/news/foren/S-Re-Goldene-Himmbeere/forum-263239/msg-23977837/read/"" title=""Apple-Veteranen äußern sich zu &quot;Jobs&quot;-Film"">Re: Goldene Himmbeere</a>
    	</li>
  		
    	<li>
      		<a href=""/newsticker/foren/S-Re-Was-fuer-Doofchen-arbeiten-eigentlich-bei-der-Polizei/forum-263265/msg-23977836/read/"" title=""NSA-Protestaktion: Mini-Drohne nach Polizeieinsatz auf dem Prüfstand"">Re: Was für Doofchen arbeiten eigentlich bei der Polizei?</a>
    	</li>
  		
    	<li>
      		<a href=""/resale/o/foren/S-Re-Einzige-plausible-Erklaerung/forum-263263/msg-23977835/read/"" title=""Consumermarkt: Erstmals mehr Tablets als Notebooks verkauft"">Re: Einzige plausible Erklärung:</a>
    	</li>
  		
    	<li>
      		<a href=""/tp/foren/S-Du-hast-leider-vergessen-zu-erwaehnen/forum-263252/msg-23977834/read/"" title=""Maut für Autos"">Du hast leider vergessen zu erwähnen</a>
    	</li>
  		
	</ul>
</div>
                            <div style=""margin: 1em auto; width: 364px; text-align: center;"">
<a href=""http://www.heise.de/mediadaten/online/"" style=""font-size: 9px; color: #151515; text-decoration: none;"">Anzeige</a><br>
<a href=""http://www.seenby.de"" rel=""external""><img src=""/icons/ho/seen_by_banner.gif"" alt=""seen.by"" /></a>
</div>
                            
                            
                            
                            <div class=""sales""></div>
                            <div class=""contentbanner""></div>
                            <div class=""teaser_abdeckung""></div>
                        
                    
                
                </div>
            
            </div>
        </div>
        <div id=""bannerzone"">
            <div class=""leaderboard""><script type=""text/javascript"">
<!--//--><![CDATA[//><!--
var dfp_ord; if (!dfp_ord) { dfp_ord = Math.floor(Math.random()*1000000000)+1000000000; }
var rb = false; document.write('<script src=""http://ad-emea.doubleclick.net/N6514/adj/newsticker/homepage;sz=728x90,468x60;tile=6;ord=_ORD_?"" type=""text/javascript""><\/script>'.replace('_ORD_', dfp_ord));
//--><!]]>
</script>
<noscript><div><a href=""http://ad-emea.doubleclick.net/N6514/jump/newsticker/homepage;sz=728x90,468x60;tile=6;ord=5050470231?"" target=""_blank""><img alt="""" src=""http://ad-emea.doubleclick.net/N6514/ad/newsticker/homepage;sz=728x90,468x60;tile=6;ord=5050470231?"" /></a></div></noscript>
</div>
            <div class=""heiseadvert""></div>
            <div class=""skyscraper"" ><script type=""text/javascript"">
<!--//--><![CDATA[//><!--
var dfp_ord; if (!dfp_ord) { dfp_ord = Math.floor(Math.random()*1000000000)+1000000000; }
if (typeof rb != ""undefined"" && rb != true) document.write('<script src=""http://ad-emea.doubleclick.net/N6514/adj/newsticker/homepage;sz=120x600,120x800,160x600,160x800;tile=7;ord=_ORD_?"" type=""text/javascript""><\/script>'.replace('_ORD_', dfp_ord));
//--><!]]>
</script>
<noscript><div><a href=""http://ad-emea.doubleclick.net/N6514/jump/newsticker/homepage;sz=120x600,120x800,160x600,160x800;tile=7;ord=5050470231?"" target=""_blank""><img alt="""" src=""http://ad-emea.doubleclick.net/N6514/ad/newsticker/homepage;sz=120x600,120x800,160x600,160x800;tile=7;ord=5050470231?"" /></a></div></noscript>
</div>
            
        </div>
        <div id=""ho_themenseite_letzte"">
            <p>heise online Themen</p>
            <nav>
                
<ol class=""clearfix"">
    <li class=""""><a href=""/themen/A"">A</a></li>
    <li class=""""><a href=""/themen/B"">B</a></li>
    <li class=""""><a href=""/themen/C"">C</a></li>
    <li class=""""><a href=""/themen/D"">D</a></li>
    <li class=""""><a href=""/themen/E"">E</a></li>
    <li class=""""><a href=""/themen/F"">F</a></li>
    <li class=""""><a href=""/themen/G"">G</a></li>
    <li class=""""><a href=""/themen/H"">H</a></li>
    <li class=""""><a href=""/themen/I"">I</a></li>
    <li class=""""><a href=""/themen/J"">J</a></li>
    <li class=""""><a href=""/themen/K"">K</a></li>
    <li class=""""><a href=""/themen/L"">L</a></li>
    <li class=""""><a href=""/themen/M"">M</a></li>
    <li class=""""><a href=""/themen/N"">N</a></li>
    <li class=""""><a href=""/themen/O"">O</a></li>
    <li class=""""><a href=""/themen/P"">P</a></li>
    <li class=""""><a href=""/themen/Q"">Q</a></li>
    <li class=""""><a href=""/themen/R"">R</a></li>
    <li class=""""><a href=""/themen/S"">S</a></li>
    <li class=""""><a href=""/themen/T"">T</a></li>
    <li class=""""><a href=""/themen/U"">U</a></li>
    <li class=""""><a href=""/themen/V"">V</a></li>
    <li class=""""><a href=""/themen/W"">W</a></li>
    <li class=""""><a href=""/themen/X"">X</a></li>
    <li class=""""><a href=""/themen/Y"">Y</a></li>
    <li class=""""><a href=""/themen/Z"">Z</a></li>
    <li class=""""><a href=""/themen/Sonderzeichen"">&amp;</a></li>
    <li class=""last""><a href=""/themen/Ziffer"">123</a></li></ol>
            </nav>
        </div>
          <div id=""sitemap"">
              <ul class=""navi_top_abschnitt"">
                  <li><a href=""/""                           title=""heise online""            class=""navi_oben_ho""    name=""footer.ho.ho"">heise online</a></li>
                  <li><a href=""/ct/""                        title=""c't""                     class=""navi_oben_ct""    name=""footer.ho.ct"">c't Magazin</a></li>
                  <li><a href=""/ix/""                        title=""iX""                      class=""navi_oben_ix""    name=""footer.ho.ix"">iX Magazin</a></li>
                  <li><a href=""/tr/""                        title=""Technology Review""       class=""navi_oben_tr""    name=""footer.ho.tr"">Technology&nbsp;Review</a></li>
                  <li><a href=""/mac-and-i/""                 title=""Mac &amp; i""             class=""navi_oben_mac""   name=""footer.ho.mac-and-i"">Mac &amp; i</a></li>
              </ul>
              <ul class=""navi_top_abschnitt"">
                  <li><a href=""/tp/""                        title=""Telepolis""               class=""navi_oben_tp""    name=""footer.ho.tp"">Telepolis</a></li>
                  <li><a href=""/hardware-hacks/""            title=""Hardware Hacks""          class=""navi_oben_hh""    name=""footer.ho.hardware-hacks"">Hardware Hacks</a></li>
                  <li><a href=""/foto/inhalt/""               title=""Digitale Fotografie""     class=""navi_oben_df""    name=""footer.ho.digitale-fotografie"">Digitale Fotografie</a></li>
                  <li><a href=""/autos/""                     title=""heise Autos""             class=""navi_oben_aut""    name=""footer.ho.autos"" >heise Autos</a></li>
                  <li><a href=""/developer/""                 title=""heise Developer""         class=""navi_oben_dev""    name=""footer.ho.developer"">heise Developer</a></li>
              </ul>
              <ul class=""navi_top_abschnitt"">
                  <li><a href=""/foto/""                      title=""heise Foto""              class=""navi_oben_foto""   name=""footer.ho.foto"">heise Foto</a></li>
                  <li><a href=""/netze/""                     title=""heise Netze""             class=""navi_oben_net""    name=""footer.ho.netze"">heise Netze</a></li>
                  <li><a href=""/open/""                      title=""heise Open Source""       class=""navi_oben_op""     name=""footer.ho.open"">Open Source</a></li>
                  <li><a href=""/resale/""                    title=""heise resale""            class=""navi_oben_res""    name=""footer.ho.resale"">heise Resale</a></li>
                  <li><a href=""/security/""                  title=""heise Security""          class=""navi_oben_sec""    name=""footer.ho.security"">heise Security</a></li>
              </ul>
              <ul class=""navi_top_abschnitt"">
                  <li><a href=""/video/""                     title=""heise Video""             class=""navi_oben_video""  name=""footer.ho.video"">heise Video</a></li>
                  <li><a href=""http://www.techstage.de/""    title=""TechStage""               class=""navi_oben_tech""   name=""footer.ho.techstage"">TechStage</a></li>
                  <li><a href=""/download/""                  title=""Software-Verzeichnis""    class=""navi_oben_swv""    name=""footer.ho.download"">Download</a></li>
                  <li><a href=""/preisvergleich/""            title=""Preisvergleich""          class=""navi_oben_pvg""    name=""footer.ho.preisvergleich"">Preisvergleich</a></li>
                  <li><a href=""/jobs/""                      title=""heise jobs""              class=""navi_oben_job""    name=""footer.ho.jobs"">Stellenmarkt</a></li>
              </ul>
              <ul class=""navi_top_abschnitt"">
                  <li><a href=""/events/""                    title=""heise Events""            class=""navi_oben_eve""    name=""footer.ho.events"">Veranstaltungen</a></li>
                  <li><a href=""/itmarkt/""                   title=""IT-Markt""                class=""navi_oben_itm""    name=""footer.ho.itmarkt"">IT-Markt</a></li>
                  <li><a href=""/whitepapers/""               title=""heise Whitepapers""       class=""navi_oben_whi""    name=""footer.ho.whitepapers"">heise Whitepapers</a></li>
                  <li><a href=""http://tarifrechner.heise.de/"" title=""Tarifrechner""          class=""navi_oben_tarifr"" name=""footer.ho.tarifrechner"">Tarifrechner</a></li>
                  <li><a href=""http://shop.heise.de/""       title=""heise-shop""              class=""navi_oben_shop""   name=""footer.ho.shop"">Shop</a></li>
              </ul>
              <ul class=""navi_top_abschnitt"">
                  <li><a href=""/artikel-archiv/""            title=""Artikel-Archiv""          class=""navi_oben_kio""    name=""footer.ho.artikel-archiv"">Artikel-Archiv</a></li>
                  <li><a href=""https://abo.heise.de/""       title=""Zeitschriften-Abo""       class=""navi_oben_abo""    name=""footer.ho.abo"">Abo</a></li>
                  <li><a href=""/loseblattwerke/""            title=""Loseblattwerke""                                   name=""footer.ho.loseblattwerke"">Loseblattwerke</a></li>
                  <li><a href=""/news-extern/news.html""   title=""RSS""                name=""footer.ho.rss"">RSS</a></li>
              </ul>
              <ul class=""navi_top_abschnitt"">
                  <li><a href=""/foren/""                     title=""Leserforum""                                       name=""footer.ho.forum"">Leserforum</a></li>
                  <li><a href=""/newsletter/""                title=""Newsletter""                                       name=""footer.ho.newsletter"">Newsletter</a></li>
                  <li><a href=""/suche/""                     title=""Suche""                                            name=""footer.ho.suche"">Suche</a></li>
                  <li><a href=""/netze/netzwerk-tools/imonitor-internet-stoerungen/""       title=""iMonitor – Internet-Störungen"" name=""footer.ho.imonitor"">iMonitor</a></li>
              </ul>
          </div>
        <script type=""text/javascript"">
        <!--//--><![CDATA[//><!--
        jQuery(document).ready( function($) {
            $('#mitte_links, #mitte_rechts').setMinHeight($('#mitte_links, #mitte_rechts').objectMaxHeight());
        });
        //--><!]]>
        </script>
    </div>







<div style=""display: inline;""><img id=""ivw_pixel_intern"" src=""/ivw-bin/ivw/CP/"" width=""1"" height=""1"" alt="""" /></div>
    
    <script type=""text/javascript"">
        <!--//--><![CDATA[//><!--
            var AVW = '<' + 'div style=""display: inline;""><' + 'img id=""avw_pixel_intern"" src=""/avw-bin/ivw/CP/mbe/newsticker/homepage"" width=""1"" height=""1"" alt="""" /><' + '/div>';
            document.write(AVW);
        //--><!]]>
    </script>
    
        <script type=""text/javascript"">
            <!--//--><![CDATA[//><!--
            var IVW='<div style=""display: inline;""><img id=""ivw_pixel"" src=""http://heise.ivwbox.de/cgi-bin/ivw/CP/homepage;%2F?r=';
            document.write(IVW + '&amp;d=' + (Math.random()*100000) + '"" width=""1"" height=""1"" alt="""" /><' + '/div>');
            //--><!]]>
        </script>
        
        <noscript>
            <div style=""display: inline;""><img id=""ivw_pixel_noscript"" src=""http://heise.ivwbox.de/cgi-bin/ivw/CP/homepage;/?r=&amp;d="" width=""1"" height=""1"" alt="""" /></div>
        </noscript>
        <script type=""text/javascript"">
            <!--//--><![CDATA[//><!--
            window.onunload=function() {};
            //--><!]]>
        </script>
        


<!-- RL -->

    

<!-- /RL -->


<!-- Webtrekk 3.2.2, (c) www.webtrekk.com -->
    <script type=""text/javascript"" src=""/js/ho/webtrekk-v3-bundle-heise-2013-01-21.js""></script>
    <script type=""text/javascript"">
    <!--
    var pageConfig = {
        linkTrack : ""standard"", // Activate Link Tracking    [link or standard]
        heatmap : ""0"",          // Activate Heatmap Tracking [1 = on | 0 = off]
        form : ""0"",             // Activate Form Tracking    [1 = on | 0 = off]
        trackId : ""288689636920174"",
        pixelSampling : """",
        contentId: ""www.heise.de.startseite.startseite""
    };
    var wt = new webtrekkV3(pageConfig);
    wt.contentGroup = {};
    wt.contentGroup['1']  = ""www.heise.de"";
    wt.contentGroup['2']  = ""startseite"";
    wt.contentGroup['3']  = ""startseite"";
    
    
    
    
    
    wt.contentGroup['9']  = ""startseite"";
    wt.contentGroup['10'] = ""startseite"";

    
    
    
    
    
    
    

    wt.heatmapRefpoint = 'container_content';
    wt.sendinfo();

    jQuery(document).ready(function($) {
        $('.bilderstrecke_vorschau').on('webtrekk_bilderstrecke', function(w) {
            wt.sendinfo({
                contentId : pageConfig.contentId + '.bilderstrecke-' + w.bilderstrecken_id, // Bilderstrecke-CID
                contentGroup : {
                    1  : wt.contentGroup[1],
                    2  : wt.contentGroup[2],
                    3  : wt.contentGroup[3],
                    4  : wt.contentGroup[4],
                    5  : wt.contentGroup[5],
                    6  : wt.contentGroup[6],
                    7  : wt.contentGroup[7],
                    8  : wt.contentGroup[8],
                    9  : wt.contentGroup[9],
                    10 : wt.contentGroup[10]
                }
            });
        });
    });

    //-->
    </script>
    <noscript><div><img src=""//prophet.heise.de/288689636920174/wt.pl?p=322,www.heise.de.startseite.startseite&cg1=www.heise.de&cg10=startseite&cg2=startseite&cg3=startseite&cg9=startseite"" height=""1"" width=""1"" alt="""" /></div></noscript>


<!-- /Webtrekk -->




    
        

<div style=""display: inline;""><img src=""/avw-bin/ivw/CP/difftest/jorge"" width=""1"" height=""1"" alt="""" /></div>
<div style=""display: inline;""><img src=""/avw-bin/ivw/CP/difftest/casey"" width=""1"" height=""1"" alt="""" /></div>

	<ul id=""navi_bottom"">

	
		<li class=""left""><a href=""/Privacy-Policy-der-Heise-Zeitschriften-Verlag-GmbH-Co-KG-4860.html"">Datenschutzhinweis</a> </li>
	

	
		<li class=""left""><a href=""/Impressum-4862.html"">Impressum</a> </li>
	

	
		<li class=""left""><a href=""/Kontakt-4864.html"">Kontakt</a> </li>
	

	
		<li class=""left""><a href=""/mediadaten/"">Mediadaten</a> </li>
	




    <li class=""right""><a href=""http://www.interred.de/"" rel=""external"" style=""margin-right: 0;"">Content Management</a> by <b style=""margin-right: 0.5em;"">Inter<span class=""tx_red"">Red</span></b></li>

	
		
		<li class=""right""><a href=""http://www.plusline.de/"">Hosted by Plus.line</a> </li>
		
		<li class=""right""><a href=""http://www.heise-medien.de/zeitschriften/"">Copyright © 2013 Heise Zeitschriften Verlag</a> </li>
		
	

	
</ul>

    

</body>
</html>
<!-- Created with InterRed V13.0-x.x.x.x, http://www.interred.de/, by InterRed GmbH -->
<!-- BID: 16, iBID: 1044194, CID: 20, iCID: 1909072 -->
<!-- Link: $(LB16:Linktext)$ $(LC20:Linktext)$ -->
<!-- Generiert: 2013-08-19 15:51:41 -->

";
    }
}

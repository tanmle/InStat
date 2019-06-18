using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;

namespace InStat
{
    public class Logic
    {
        static readonly string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };
        static string ApplicationName = "InStat";

        internal IList<IList<Object>> GetGDocsData()
        {
            UserCredential credential;
            ValueRange response = null;

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/sheets.googleapis.com.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }

            // Create Google Sheets API service.
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define request parameters.
            String spreadsheetId = "1hO0XZWeDyt2CpYlQi01L_KP0vxViZrvBb0bxESq_Jk4";
            String range = "B4:C";
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(spreadsheetId, range);

            // Spreadsheet URL:
            // https://docs.google.com/spreadsheets/d/1BxiMVs0XRA5nFMdKvBdBZjgmUUqptlbs74OgvE2upms/edit
            response = request.Execute();
            IList<IList<Object>> values = response.Values;

            return values;
        }

        // Need to update: contain all players even wildcard players
        internal List<string> GetAvailablePlayers()
        {
            IList<IList<Object>> values = GetGDocsData();

            return (from player in values where player.Count == 2 where player[1].ToString() == "Yes" select player[0].ToString()).ToList();
        }

        internal List<string> GetPlayersByPosition(Dictionary<string, List<string>> dic, List<string> playerList, Position pos)
        {
            var positionList = new List<string>();

            foreach (var player in playerList)
            {
                if (dic.ContainsKey(player))
                {
                    var values = new List<string>();
                    values = dic[player];

                    if (values.ElementAt(0) == pos.ToString())
                    {
                        positionList.Add(player);
                    }
                }
            }

            return positionList;
        }

        internal List<string> SortByLevel(Dictionary<string, List<string>> dic, List<string> players, Position pos)
        {
            var list = GetPlayersByPosition(dic, players, pos);

            var listPosition = list.Where(dic.ContainsKey).ToDictionary(player => player, player => dic[player]);

            return listPosition.OrderByDescending(key => key.Value[1]).Select(skill => skill.Key).ToList();
        }

        internal List<string> RandomTeam(Dictionary<string, List<string>> dic, List<string> players, string team)
        {
            var defPlayers = SortByLevel(dic, players, Position.Def);
            var forPlayers = SortByLevel(dic, players, Position.Forward);
            var midPlayers = SortByLevel(dic, players, Position.Mid);

            if (team == "Team A")
            {
                // Team A
                var oddList = defPlayers.Where((x, index) => index % 2 != 0).ToList();
                oddList.AddRange(forPlayers.Where((x, index) => index % 2 == 0).ToList());
                oddList.AddRange(midPlayers.Where((x, index) => index % 2 != 0).ToList());

                return oddList;
            }
            else
            {
                // Team B
                var evenList = defPlayers.Where((x, index) => index % 2 == 0).ToList();
                evenList.AddRange(forPlayers.Where((x, index) => index % 2 != 0).ToList());
                evenList.AddRange(midPlayers.Where((x, index) => index % 2 == 0).ToList());

                return evenList;
            }
        }

        internal List<string> RandomTeam_Case2(Dictionary<string, List<string>> dic, List<string> players, string team)
        {
            var defPlayers = SortByLevel(dic, players, Position.Def);
            var forPlayers = SortByLevel(dic, players, Position.Forward);
            var midPlayers = SortByLevel(dic, players, Position.Mid);

            if (team == "Team A")
            {
                // Team A
                var oddList = defPlayers.Where((x, index) => index % 2 == 0).ToList();
                oddList.AddRange(forPlayers.Where((x, index) => index % 2 == 0).ToList());
                oddList.AddRange(midPlayers.Where((x, index) => index % 2 != 0).ToList());

                return oddList;
            }
            else
            {
                // Team B
                var evenList = defPlayers.Where((x, index) => index % 2 != 0).ToList();
                evenList.AddRange(forPlayers.Where((x, index) => index % 2 != 0).ToList());
                evenList.AddRange(midPlayers.Where((x, index) => index % 2 == 0).ToList());

                return evenList;
            }
        }

        internal List<string> RandomTeam_Case3(Dictionary<string, List<string>> dic, List<string> players, string team)
        {
            var defPlayers = SortByLevel(dic, players, Position.Def);
            var forPlayers = SortByLevel(dic, players, Position.Forward);
            var midPlayers = SortByLevel(dic, players, Position.Mid);

            if (team == "Team A")
            {
                // Team A
                var oddList = defPlayers.Where((x, index) => index % 2 == 0).ToList();
                oddList.AddRange(forPlayers.Where((x, index) => index % 2 != 0).ToList());
                oddList.AddRange(midPlayers.Where((x, index) => index % 2 != 0).ToList());

                return oddList;
            }
            else
            {
                // Team B
                var evenList = defPlayers.Where((x, index) => index % 2 != 0).ToList();
                evenList.AddRange(forPlayers.Where((x, index) => index % 2 == 0).ToList());
                evenList.AddRange(midPlayers.Where((x, index) => index % 2 != 0).ToList());

                return evenList;
            }
        }

        internal List<string> GetEmailList(Dictionary<string, List<string>> dic, Dictionary<string, List<string>> databaseDic)
        {
            // Send all email address
            var mailList = new List<string>();
            var bioMailList = new List<string>();
            foreach (var key in dic.Keys)
            {

                if (dic.ContainsKey(key))
                {
                    var values = new List<string>();
                    values = dic[key];

                    if (values.ElementAt(2) != null)
                    {
                        mailList.Add(values.ElementAt(2));
                    }
                }
            }

            foreach (var key in databaseDic.Keys)
            {

                if (databaseDic.ContainsKey(key))
                {
                    var values = new List<string>();
                    values = databaseDic[key];

                    if (values.ElementAt(2) != null)
                    {
                        bioMailList.Add(values.ElementAt(2));
                    }
                }
            }

            var wildCard = mailList.Except(bioMailList).ToList();
            bioMailList.AddRange(wildCard);
            return bioMailList;
        }

        internal void SendEmail(Dictionary<string, List<string>> dic, Dictionary<string, List<string>> databaseDic, string imgUrl)
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("ditofootballteam@gmail.com");

            // Multiple receiver
            var mailList = GetEmailList(dic, databaseDic);
            foreach (var mail in mailList)
            {
                msg.To.Add(mail);
            }
            //msg.To.Add("huynhlongb231@gmail.com");
            var date = DateTime.Now.AddDays(1).ToString("MMMM dd, yyyy");
            msg.Subject = "[DITO-FC] THÔNG BÁO " + date;
            msg.IsBodyHtml = true;
            CaptureSpreadsheet();
            var path = Environment.CurrentDirectory + "\\imgscr.PNG";
            var screenshotPath = Environment.CurrentDirectory + "\\team.PNG";
            var insertedImg = "";
            string[] imgs = getImageURLs(3);
            if (imgs[0] == "" || imgs[0] == null)
            {
                insertedImg = "http://hinhanhdephd.com/wp-content/uploads/2016/01/tai-hinh-girl-xinh-lam-avatar-de-thuong-nhat-22.jpg";
            }
            else
            {
                for (int i = 0; i < imgs.Length; i++) {
                    insertedImg = insertedImg + "<img src = \"" + imgs[i] + "\"/><br>";
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if (!File.Exists(path))
                {
                    Thread.Sleep(1000);
                }
                else
                {
                    break;
                }
            }

            Attachment inlineLogo = new Attachment(path);
            msg.Attachments.Add(inlineLogo);
            string contentID = "Image";
            inlineLogo.ContentId = contentID;

            // To make the image display as inline and not as attachment
            inlineLogo.ContentDisposition.Inline = true;
            inlineLogo.ContentDisposition.DispositionType = DispositionTypeNames.Inline;

            // Winform screenshot
            Attachment appscr = new Attachment(screenshotPath);
            msg.Attachments.Add(appscr);
            string scrID = "ScreenImage";
            appscr.ContentId = scrID;

            // To make the image display as inline and not as attachment
            inlineLogo.ContentDisposition.Inline = true;
            inlineLogo.ContentDisposition.DispositionType = DispositionTypeNames.Inline;

            msg.Body = "<p class=\"MsoNormal\" align=\"center\" style=\"text-align:center\"><b><span style=\"font-size:48.0pt; " +
                       "color:#548dd4\">MƯA THÌ LÊN FACEBOOK CHECK. ĐỀ NGHỊ AE ĐI ĐÔNG ĐỦ, TRÁNH TÌNH TRẠNG THIẾU NGƯỜI.</span></b></p><br /><p class=\"MsoNormal\" " +
                       "align=\"center\" style=\"text-align:center\"><b><u><span style=\"font-size:24.0pt;color:red\">THÔNG BÁO</span></u></b></p><p class=\"MsoNormal\" align=\"center\" " +
                       "style=\"text-align:center\"><b><span style=\"font-size:18.0pt;color:#00b0f0\">VÀO LÚC </span></b><b><u><span style=\"font-size:80.0pt;color:red\">5h15:00</span></u></b>" +
                       "<b><span style=\"font-size:18.0pt\">, " + date + ", SÂN BÓNG ĐÁ</span></b><b><span style=\"font-size:48.0pt;color:red\"> DUY TÂN</span></b></p><br /><br /><p class=\"MsoNormal\" " +
                       "align=\"center\" style=\"text-align:center\"><b><span style=\"font-size:18.0pt; color:#00b0f0\">SẼ DIỄN RA CUỘC CHIẾN KHÔNG HỒI KẾT GIỮA:</span></b></p><br /><p class=\"MsoNormal\" " +
                       "align=\"center\" style=\"text-align:center\"><b><span style=\"font-size:20.0pt;font-family:'Bernard MT Condensed','serif';color:#ffc000\">DITO TEAM </span></b><b><span style=\"font-size:18.0pt;" +
                       "color:red\">VS </span></b><b><span style=\"font-size:23.0pt;font-family:AnkeCalligraph\">ODIT TEAM</span></b></p><br \\><p class=\"MsoNormal\" align=\"center\" style=text-align:center;><span class=\"playerList\"><img src=\"cid:" + contentID + "\"/></span>" +
                       "<span class=\"teamList\"><img src=\"cid:" + scrID + "\"/></span><span class=\"girlpic\">"+ @insertedImg +"</span></p><br \\><p class=\"MsoNormal\"><b><u><span style=\"font-size:20.0pt;color:red\">RULE:</span></u></b>" +
                       "</p><p class=\"rule\" style=\"margin-left:1.0in\"><b><ul style=\"margin-left:10px; font-size:15.0pt\"><li>Đi trễ <= 5 phút: 10K</li><li>Đi trễ > 5 : 20K</li><li>Confirm mà không đi: 30K</li><li>Không confirm mà " +
                       "rúc đầu lên sân: 20K</li><li>Thèn giữ banh (Tân Lê) mà không đem banh: 50k</li><li>Điểm danh sau 19h (cùng ngày với email) sẽ không tính</li></ul></b></p>";

            SmtpClient client = new SmtpClient();
            client.UseDefaultCredentials = true;
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential("ditofootballteam@gmail.com", "123!@#qwe");
            client.Timeout = 20000;
            try
            {
                client.Send(msg);
                MessageBox.Show("Mail has been successfully sent!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail Has error" + ex.Message);
            }
            finally
            {
                msg.Dispose();
            }
        }

        internal void CaptureSpreadsheet()
        {
            var path = Environment.CurrentDirectory;
            var imagePath = path + "\\imgscr.PNG";

            // Delete existing image
            if (File.Exists(imagePath))
            {
                File.Delete(imagePath);
            }

            var process = new System.Diagnostics.Process();

            // Start cmd at specific folder
            var startInfo = new System.Diagnostics.ProcessStartInfo()
            {
                WorkingDirectory = path,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                UseShellExecute = false,
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };

            // Execute js file
            const string command = "phantomjs phantomJsCommand.js";
            process.StartInfo = startInfo;
            process.Start();
            process.StandardInput.WriteLine(command);
            Thread.Sleep(2000);
        }

        public string[] getImageURLs(int numberOfImage)
        {
            string[] imgUrls = new string[numberOfImage];

            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless", "--blink-settings=imagesEnabled=false");
            ChromeDriver _driver = new ChromeDriver(chromeOptions);
            //_driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(120));
            var urls = new List<string> {
                "https://www.instagram.com/vsbg.limited/",
                "https://www.instagram.com/instababes.asian/",
                "https://www.instagram.com/nobra.club.vnn/",
                "https://www.instagram.com/bodyon_bikini/",
                "https://www.instagram.com/chinese__girls/",
                "https://www.instagram.com/sexy.hot.asian.models/",
                "https://www.instagram.com/hot.sexy.asian.girls/",
                "https://www.instagram.com/sexyjapanese_girl/"
            };
            var url = urls[new Random().Next(urls.Count)];
            try {
                _driver.Navigate().GoToUrl(url );
                Thread.Sleep(3000);
                var imgs = _driver.FindElementsByXPath("//article//img");
                var src = new List<string> { };
                for (int i = 0; i < imgs.Count; i++)
                {
                    string srcset = imgs[i].GetAttribute("srcset");
                    src.Add(srcset.Substring(srcset.IndexOf("480w,") + 5, srcset.IndexOf(" 640w") - (srcset.IndexOf("480w,") + 5)));
                }

                var random = new Random();
                for (int i = 0; i < imgUrls.Length; i++) {
                    imgUrls[i] = src[random.Next(src.Count)];
                }

                System.IO.File.WriteAllLines(@"E:\WriteText.txt", imgUrls);
            }
            catch (Exception)  {
                _driver.Quit();
            }
            _driver.Quit();
            return imgUrls;
        }
    }
}

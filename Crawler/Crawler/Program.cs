using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleCrawler
{
    class SimpleCrawler
    {
        private Hashtable urls = new Hashtable();
        private string domain;
        private int count = 0;
        static void Main(string[] args)
        {
            string startUrl = "http://www.cnblogs.com/dstang2000/";
            SimpleCrawler myCrawler = new SimpleCrawler(startUrl);
            if (args.Length >= 1) startUrl = args[0];
            myCrawler.urls.Add(startUrl, false);//加入初始页面
            new Thread(myCrawler.Crawl).Start();
        }

        public SimpleCrawler(string url)
        {
            //截取域名
            MatchCollection mc = new Regex(@"//[^/]+/").Matches(url);
            foreach (Match m in mc)
            {
                domain = m.Value;
            }

        }

        private void Crawl()
        {
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 100) break;
                Console.WriteLine("爬行" + current + "页面!");
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                Parse(html, current);//解析,并加入新的链接
                Console.WriteLine("爬行结束");
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html, string current)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                //找到有域名的url
                if (Regex.IsMatch(strRef, @"://[^/]+/"))
                {
                    //判断域名和后缀为html
                    if (Regex.IsMatch(strRef, $@".*{domain}.*html$"))
                        //if(strRef.Contains(domain)&&strRef.Contains(".html"))
                        if (urls[strRef] == null)
                            urls[strRef] = false;
                }
                else//没有域名就认为是相对地址或者绝对地址
                {
                    //先判断是不是html文件
                    if (Regex.IsMatch(strRef, @".*html$"))
                    {
                        //如果是绝对地址
                        if (strRef[0] == '/')
                        {
                            //转化成url链接
                            strRef = "https:" + domain + strRef.Substring(1);
                            if (urls[strRef] == null)
                                urls[strRef] = false;
                        }
                        else
                        {
                            //直接在当前链接后面接上相对地址
                            if (current[current.Length - 1] == '/')
                                strRef = current + strRef;
                            else
                                strRef = current + "/" + strRef;
                            if (urls[strRef] == null)
                                urls[strRef] = false;
                        }
                    }

                }
            }
        }
    }
}

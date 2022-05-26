using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace phptravelstest
{
    
        public class GoogleSearch
        {
            public static string SearchParameter(string word)
            {
            string message = "";
                      
                       

                try
                {
                    var findText = Driver.Instance.FindElement(By.Name("q"));
                    findText.SendKeys(word);
                    Thread.Sleep(500);

                    Actions builder = new Actions(Driver.Instance);
                    builder.SendKeys(Keys.Enter).Perform();
                    Thread.Sleep(1000);

                    var phptravels = Driver.Instance.FindElement(By.CssSelector("#rso div:nth-child(1) div.yuRUbf  a h3"));
                    phptravels.Click();
                    Thread.Sleep(1000);


                    var phptravelscompany = Driver.Instance.FindElement(By.ClassName("currentLanguage"));
                    phptravelscompany.Click();
                    Thread.Sleep(1000);

                    var companyblog = Driver.Instance.FindElement(By.CssSelector("body header nav  div.lvl-0.dropdown.headerLang a:nth-child(1)"));
                    companyblog.Click();
                    Thread.Sleep(500);

                    var searchbyname = Driver.Instance.FindElement(By.CssSelector("body section.hero div:nth-child(2) span  span.selection  span"));
                    searchbyname.Click();
                    Thread.Sleep(500);

                    var searchbynametext = Driver.Instance.FindElement(By.CssSelector("body  span  span  span.select2-search.select2-search--dropdown  input"));
                    searchbynametext.SendKeys("Can you travel the world with crypto?");
                    Thread.Sleep(500);

                    builder.SendKeys(Keys.Enter).Perform();
                    Thread.Sleep(1000);

                     var canyoutravel = Driver.Instance.FindElement(By.CssSelector("body  span  span  span.select2-results"));
                     canyoutravel.Click();
                     Thread.Sleep(500);

                //kategorije
                     var categories = Driver.Instance.FindElement(By.CssSelector("body  header  nav  div  div"));
                     categories.Click();
                     Thread.Sleep(500);

                     var categoriesTravel = Driver.Instance.FindElement(By.CssSelector("body  header  nav  div  div  ul  li:nth-child(1)  a"));
                     categoriesTravel.Click();
                     Thread.Sleep(500);

                     var categories2 = Driver.Instance.FindElement(By.CssSelector("body  header  nav  div  div"));
                     categories2.Click();
                     Thread.Sleep(500);

                     var categoriesVersions = Driver.Instance.FindElement(By.CssSelector("body  header  nav  div  div  ul  li:nth-child(2)  a"));
                     categoriesVersions.Click();
                     Thread.Sleep(500);

                     var categories3 = Driver.Instance.FindElement(By.CssSelector("body  header  nav  div  div"));
                     categories3.Click();
                     Thread.Sleep(500);


                     var categoriesEvents = Driver.Instance.FindElement(By.CssSelector("body  header  nav  div  div  ul  li:nth-child(3)  a"));
                     categoriesEvents.Click();
                     Thread.Sleep(500);

                     var categories4 = Driver.Instance.FindElement(By.CssSelector("body  header  nav  div  div"));
                     categories4.Click();
                     Thread.Sleep(500);

                     var categoriesOffers = Driver.Instance.FindElement(By.CssSelector("body  header  nav  div  div  ul  li:nth-child(4)  a"));
                     categoriesOffers.Click();
                     Thread.Sleep(500);

                     var categories5 = Driver.Instance.FindElement(By.CssSelector("body  header  nav  div  div"));
                     categories5.Click();
                     Thread.Sleep(500);

                    //does not work, categories/technologies
                     var categoriesTechno = Driver.Instance.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[5]/a"));
                     categoriesTechno.Click();
                     Thread.Sleep(1000);


                     var categories6 = Driver.Instance.FindElement(By.CssSelector("body  header  nav  div  div"));
                     categories6.Click();
                     Thread.Sleep(500);

                     var categoriesBusiness = Driver.Instance.FindElement(By.CssSelector("body  header  nav  div  div  ul  li:nth-child(6)  a"));
                     categoriesBusiness.Click();
                     Thread.Sleep(500);

                     var categories7 = Driver.Instance.FindElement(By.CssSelector("body  header  nav  div  div"));
                     categories7.Click();
                     Thread.Sleep(500);

                     var categoriesFeatures = Driver.Instance.FindElement(By.CssSelector("body  header  nav  div  div  ul  li:nth-child(7)  a"));
                     categoriesFeatures.Click();
                     Thread.Sleep(500);






            }
                catch (Exception e)
                {
                    message += "ERROR!!!" + e.Message;
                }

                return message;
            }

        }
    }
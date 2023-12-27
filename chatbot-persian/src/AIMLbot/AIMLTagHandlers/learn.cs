using System;
using System.Xml;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace AIMLbot.AIMLTagHandlers
{
    /// <summary>
    /// The learn element instructs the AIML interpreter to retrieve a resource specified by a URI, 
    /// and to process its AIML object contents.
    /// </summary>
    public class learn : AIMLbot.Utils.AIMLTagHandler
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="bot">The bot involved in this request</param>
        /// <param name="user">The user making the request</param>
        /// <param name="query">The query that originated this node</param>
        /// <param name="request">The request inputted into the system</param>
        /// <param name="result">The result to be passed to the user</param>
        /// <param name="templateNode">The node to be processed</param>
        public learn(AIMLbot.Bot bot,
                        AIMLbot.User user,
                        AIMLbot.Utils.SubQuery query,
                        AIMLbot.Request request,
                        AIMLbot.Result result,
                        XmlNode templateNode)
            : base(bot, user, query, request, result, templateNode)
        {
        }

        protected override string ProcessChange()
        {
            if (this.templateNode.Name.ToLower() == "learn")
            {
                //AIML Version 1.0
                //// currently only AIML files in the local filesystem can be referenced
                //// ToDo: Network HTTP and web service based learning
                //if (this.templateNode.InnerText.Length > 0)
                //{
                //    string path = this.templateNode.InnerText;
                //    FileInfo fi = new FileInfo(path);
                //    if (fi.Exists)
                //    {
                //        XmlDocument doc = new XmlDocument();
                //        try
                //        {
                //            doc.Load(path);
                //            this.bot.loadAIMLFromXML(doc, path);
                //        }
                //        catch
                //        {
                //            this.bot.writeToLog("ERROR! Attempted (but failed) to <learn> some new AIML from the following URI: " + path);
                //        }
                //    }
                //}

                //AIML Version 2.0

                //Dictionary<string, string> processedEvalText = processEvalText(this.templateNode, new Dictionary<string, string>());

                //string learnText = this.templateNode.InnerXml;
                //int evalTagStartIndex = learnText.IndexOf("<eval>");
                //while (evalTagStartIndex > -1)
                //{

                //    int evalTagFinishIndex = learnText.IndexOf("</eval>");
                //    string evalText = learnText.Substring(evalTagStartIndex, evalTagFinishIndex - evalTagStartIndex + 7);


                //    learnText = learnText.Replace(evalText, processedEvalText[evalText]).Replace("<eval>", "").Replace("</eval>", "");

                //}

            }
            return string.Empty;
        }

       
    }
}

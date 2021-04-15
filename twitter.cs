using System;
using System.Collections;

namespace Twitter
{
    class Program
    {
        static void Main(string[] args)
        {

            countMentionAndHash("Hello this is training @nameperson" +
                " #Iam not sure is work or not #thankyou");

        }

            static void countMentionAndHash(string tweet)
            {
                ArrayList mention = new ArrayList();

                ArrayList hashtag = new ArrayList();

                int i = 0;
            while (i < tweet.Length)
            {
                if (tweet[i] == '@' && i == 0)

                    mention.Add(tweet[i]);

                else
                {
                    Console.WriteLine("there is no mention in this tweet");
                }
                i++;
            }
            while (i < tweet.Length)
            {

                if (i == 0 && tweet[i] == '#')
                {

                    mention.Add(tweet[i]);

                }
                else
                {
                    Console.WriteLine("there is no hashtag in this tweet");

                }
                i++;
            }
               

                Console.WriteLine($"The tweet contains {mention.Count} mentions:");
             

                Console.WriteLine($"The tweet contains {hashtag.Count} hashtags:");
               
            }

        }
    }


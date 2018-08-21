using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Message
    {
        private int matin;
        private int midi;
        private int soir;

        public Message()
        {

        }

        public Message(int Pmatin = 9, int Pmidi = 13, int Psoir = 18)
        {
            matin = Pmatin;
            midi = Pmidi;
            soir = Psoir;
        }


        public String PropertyMDate
        {
            get
            {
                DateTime localDate = DateTime.Now;
                String messageDate = string.Empty;
                Console.WriteLine("Programme lancé");
                String resultat = string.Empty;

                    if (string.IsNullOrEmpty(messageDate))
                    {
                        if (localDate.DayOfWeek == DayOfWeek.Saturday || localDate.DayOfWeek == DayOfWeek.Sunday && localDate.Hour > soir && localDate.Hour <= matin)
                        {
                            messageDate = String.Format("tu es en week");
                        }
                        else
                        {
                            if (localDate.Hour >= matin && localDate.Hour < midi)
                            {
                                messageDate = "Bonjour";
                            }
                            else if (localDate.Hour >= midi && localDate.Hour <= soir)
                            {
                                messageDate = "Bon après-midi";
                            }
                            else if (localDate.Hour > soir && localDate.Hour <= matin)
                            {
                                messageDate = "Bonsoir";
                            }
                        }
                        resultat = String.Format("Username : {0} {1} {2} {3}", Environment.UserName, messageDate, "nous sommes le : ", localDate);
                    }
                    return resultat;
            }
            set
            {

            }
        }
    }
}

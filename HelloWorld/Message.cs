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
        private ITime time;

        public Message()
        {

        }

        public Message(int Pmatin, int Pmidi, int Psoir)
            :this (new Time(), Pmatin, Pmidi, Psoir)
        {
        }

        public Message(ITime date,int Pmatin = 9, int Pmidi = 13, int Psoir = 18)
        {
            matin = Pmatin;
            midi = Pmidi;
            soir = Psoir;
            time = date;
        }


        public String PropertyMDate
        {
            get
            {
                String messageDate = string.Empty;
                Console.WriteLine("Programme lancé");
                String resultat = string.Empty;

                    if (string.IsNullOrEmpty(messageDate))
                    {
                        if ( (time.date.DayOfWeek == DayOfWeek.Saturday || time.date.DayOfWeek == DayOfWeek.Sunday) || ( (time.date.DayOfWeek == DayOfWeek.Friday && time.date.Hour > soir) && (time.date.DayOfWeek == DayOfWeek.Monday && time.date.Hour < matin )))
                        {
                            messageDate = String.Format("tu es en week");
                        }
                        else
                        {
                            if (time.date.Hour < midi)
                            {
                                messageDate = "Bonjour";
                            }
                            else if (time.date.Hour > midi && time.date.Hour < soir)
                            {
                                messageDate = "Bon après-midi";
                            }
                            else if (time.date.Hour > soir)
                            {
                                messageDate = "Bonsoir";
                            }
                        }
                        resultat = String.Format("Username : {0} {1} {2} {3}", Environment.UserName, messageDate, "nous sommes le : ", time.date.TimeOfDay);
                    }
                    return resultat;
            }
            set
            {

            }
        }
    }
}

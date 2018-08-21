using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Message
    {
        private int matin;
        private int midi;
        private int soir;

        public Message()
        {

        }

        public Message(int matin = 9, int midi = 13, int soir = 18)
        {
            this.matin = matin;
            this.midi = midi;
            this.soir = soir;
        }


        public String MyProperty
        {
            get
            {
                DateTime localDate = DateTime.Now;
                String messageDate = string.Empty;
                Console.WriteLine("Programme lancé");
                String resultat = string.Empty;

                    if (string.IsNullOrEmpty(messageDate))
                    {
                        if (localDate.DayOfWeek == DayOfWeek.Saturday || localDate.DayOfWeek == DayOfWeek.Sunday && localDate.Hour > this.soir && localDate.Hour <= this.matin)
                        {
                            messageDate = String.Format("tu es en week");
                        }
                        else
                        {
                            if (localDate.Hour >= this.matin && localDate.Hour < this.midi)
                            {
                                messageDate = "Bonjour";
                            }
                            else if (localDate.Hour >= this.midi && localDate.Hour <= this.soir)
                            {
                                messageDate = "Bon après-midi";
                            }
                            else if (localDate.Hour > this.soir && localDate.Hour <= this.matin)
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

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;

namespace PokerLite
{
    public partial class Form1 : Form
    {
        /*  Detta är objektskapandet av de klasser som innehåller metoder och 
            variabler som behöver användas i formulärets kod. Med dessa objekt kan 
            allt i de klasserna markerat som "public" anropas eller användas.    */
        KortlekLib kortLekLib = new KortlekLib();
        Uppgift uppgift = new Uppgift();

        //  De medlemsvariabler som behövs. En lista strängar, en lista med grafik,
        //  en rundräknare och spelarnas poäng.
        public List<string> allaKort;
        ResourceSet kortGrafik = KortGrafik.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);

        int rundor;
        int poängSp1 = 0;
        int poängSp2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //  Detta är metoden som ser till att rätt kort visas på rätt plats. Den används
        //  så fort ett kort byter plats 
        private void UppdateraGrafik()
        {
            UppdateraHänder();
            UppdateraHögar();
        }

        void UppdateraHänder()
        {
            //  En array för varje spelares PictureBoxar för att kunna användas i en loop nedan
            PictureBox[] pcbSpelare1 = { pcbSpelare1Kort1, pcbSpelare1Kort2, pcbSpelare1Kort3, pcbSpelare1Kort4, pcbSpelare1Kort5 };
            PictureBox[] pcbSpelare2 = { pcbSpelare2Kort1, pcbSpelare2Kort2, pcbSpelare2Kort3, pcbSpelare2Kort4, pcbSpelare2Kort5 };

            /*  Beroende på vems tur det är, så hämtas antingen grafiken för kortet, eller 
                ett korts baksida för varje kort i en spelares hand. Metoden för att hämta 
                grafik är skriven i en annan klass eller kodsamling (kortLekLib). Den är skapad 
                för att rymma metoder som alla sorts kortspel kan använda sig av. 
            
                else-satsen är skapad för att visa båda spelares kort ifall det inte är någons tur
                (spelet har ej börjat eller precis avslutats) */
            for (int i = 0; i < pcbSpelare1.Length; i++)
            {
                if (uppgift.spelaresTur == 1)
                {
                    pcbSpelare1[i].Image = kortLekLib.HämtaGrafik(uppgift.handSpelare1[i], kortGrafik);
                    pcbSpelare2[i].Image = KortGrafik.back;
                }
                else if (uppgift.spelaresTur == 2)
                {
                    pcbSpelare1[i].Image = KortGrafik.back;
                    pcbSpelare2[i].Image = kortLekLib.HämtaGrafik(uppgift.handSpelare2[i], kortGrafik);
                }
                else
                {
                    pcbSpelare1[i].Image = kortLekLib.HämtaGrafik(uppgift.handSpelare1[i], kortGrafik);
                    pcbSpelare2[i].Image = kortLekLib.HämtaGrafik(uppgift.handSpelare2[i], kortGrafik);
                }
            }
        }

        void UppdateraHögar()
        {
            //  Dessa if else-satser förser slänghögen och öppnakort med relevant grafik 
            if (uppgift.slängHög.Count > 0)
                pcbSläng.Image = kortLekLib.HämtaGrafik(uppgift.slängHög.Peek(), kortGrafik);
            else
                pcbSläng.Image = KortGrafik.empty;

            if (uppgift.öppnaKort.Count > 0)
                pcbÖppet.Image = kortLekLib.HämtaGrafik(uppgift.öppnaKort.Peek(), kortGrafik);
            else
                pcbÖppet.Image = KortGrafik.empty;
        }

        /*  Denna metod låser spelets kontroller (och öppnar startknappen) samt skapar
            en poängräknare för varje spelare. En poängräknare är en klass som räknar ut
            och sparar de resultat en spelare fått  */
        void AvslutaSpelet()
        {
            uppgift.spelaresTur = 3;

            gbxSpelare1.Enabled = false;
            gbxSpelare2.Enabled = false;
            pcbKortlek.Enabled = false;
            pcbSläng.Enabled = false;
            BackColor = Color.LightGreen;
            btnStart.Enabled = true;
            btnKlar.Enabled = false;

            UppdateraGrafik();

            PoängRäknare poäng1 = new PoängRäknare("Spelare 1", uppgift.handSpelare1);
            PoängRäknare poäng2 = new PoängRäknare("Spelare 2", uppgift.handSpelare2);

            //  Poängräknarna skickas till denna metod för analys
            JämförResultat(poäng1, poäng2);
        }

        /*  Denna metod jämför resultaten från poängräknarna för att utse en vinnare */
        void JämförResultat(PoängRäknare poäng1, PoängRäknare poäng2)
        {
            //  Felkontroll: Ta bort kommentering på nästa rad för utskrift av poängen
            //  SkrivTillKonsol(poäng1, poäng2);

            //  Poängen jämförs först. Är den samma jämförs högsta valören i spelarnas händer
            bool spelare1vinner = true;
            if (poäng1.Poäng > poäng2.Poäng)
                spelare1vinner = true;
            else if (poäng1.Poäng < poäng2.Poäng)
                spelare1vinner = false;
            else
            {
                for (int i = 0; i < poäng1.Resultat.Length; i++)
                    if (poäng1.Resultat[i] > poäng2.Resultat[i])
                    {
                        spelare1vinner = true;
                        break;
                    }
                    else if (poäng1.Resultat[i] < poäng2.Resultat[i])
                    {
                        spelare1vinner = false;
                        break;
                    }
            }

            //  Vinnarens poängräknare plockas fram och poäng delas ut
            PoängRäknare vinnare;
            if (spelare1vinner)
            {
                vinnare = poäng1;
                poängSp1 += vinnare.Poäng;
            }
            else
            {
                vinnare = poäng2;
                poängSp2 += vinnare.Poäng;
            }

            //  Poäng och meddelande skrivs ut till spelarna
            lblPoängSp1.Text = poängSp1.ToString();
            lblPoängSp2.Text = poängSp2.ToString();

            string msg = vinnare.Namn + " vinner! " + vinnare.Poäng + " poäng med " + vinnare.PokerHandStr + ".";

            MessageBox.Show(msg);
        }

        //  Skriver ut handens värden i ordning. För felkontroll endast.
        void SkrivTillKonsol(PoängRäknare poäng1, PoängRäknare poäng2)
        {
            Console.WriteLine("Sp1 \t Sp2");
            for (int i = 0; i < 5; i++)
                Console.WriteLine(poäng1.Resultat[i] + " \t\t " + poäng2.Resultat[i]);
            Console.WriteLine("----------------");
        }

        /*  När knappen "start" trycks skapas och blandas en kortlek som sedan 
            skickas med till uppgiftens StartaSpelet()-metod.    */
        private void btnStart_Click(object sender, EventArgs e)
        {
            rundor = 0;
            allaKort = kortLekLib.SkapaKortlek(kortGrafik);
            uppgift.StartaSpelet(allaKort);
            UppdateraGrafik();

            gbxSpelare1.Enabled = true;
            gbxSpelare2.Enabled = false;
            btnStart.Enabled = false;
            pcbKortlek.Enabled = true;
            btnKlar.Enabled = true;
            BackColor = default;
        }

        //  När kortleken trycks anropas uppgiftens DraNyaKort()-metod
        private void pcbKortlek_Click(object sender, EventArgs e)
        {
            uppgift.DraNyaKort();
            UppdateraGrafik();
            gbxSpelare1.Enabled = false;
            gbxSpelare2.Enabled = false;
            pcbKortlek.Enabled = false;
            pcbÖppet.Enabled = false;
            btnKlar.Enabled = true;
        }

        /*  När knappen klar trycks på växlas turen till nästa spelare.
            RemoveAll() används för att ta bort eventuella tomma kort
            utöver de fem kort användaren måste ha för att denna
            knapp ska vara enabled. Det är en så kallad bugfix  */
        private void btnKlar_Click(object sender, EventArgs e)
        {
            if (uppgift.spelaresTur == 1)
            {
                uppgift.spelaresTur = 2;
                gbxSpelare2.Enabled = true;
                gbxSpelare1.Enabled = false;
                pcbKortlek.Enabled = true;
            }
            else
            {
                uppgift.spelaresTur = 1;
                rundor++;
                gbxSpelare1.Enabled = true;
                gbxSpelare2.Enabled = false;
                pcbKortlek.Enabled = true;
            }

            pcbÖppet.Enabled = true;

            /*  Här avslutas spelet om rundorna överskrider 1.
                Annars anropas uppgiftens SlängdaTillÖppna()-metod  */
            if (rundor < 2)
            {
                uppgift.SlängdaTillÖppna();
                UppdateraGrafik();
            }
            else
                AvslutaSpelet();
        }

        /*  När det öppna kortet klickas på anropas DraGammaltKort()-metoden
            i uppgiften (if-satsen som kollar att det finns kort i högen 
            är överflödig då annan kod ser till att det alltid är det. Better
            safe than sorry, though) */
        private void pcbÖppet_Click(object sender, EventArgs e)
        {
            if (uppgift.öppnaKort.Count > 0)
            {
                bool fannsTomt = uppgift.DraGammaltKort();
                UppdateraGrafik();

                if (fannsTomt)
                {
                    gbxSpelare1.Enabled = false;
                    gbxSpelare2.Enabled = false;
                }
            }

            /*  Följande kontroll utförs eftersom det, till skillnad från kortleken, 
                ska kunna gå att ta ett eller flera kort från den öppna högen.  */
            bool fullHand = true;

            for (int i = 0; i < 5; i++)
                if (uppgift.handSpelare1[i] == "empty" || uppgift.handSpelare2[i] == "empty")
                {
                    fullHand = false;
                    break;
                }

            if (fullHand)
                btnKlar.Enabled = true;
        }

        /*  Dessa händelser är kopplade till att spelaren klickar på 
            korten i sin hand. Uppgiftens SlängKort()-metod anropas med det klickade
            kortet samt vilket plats i handen kortet hade (0-5) som argument.    */
        private void pcbSpelare1Kort1_Click(object sender, EventArgs e)
        {
            uppgift.SlängKort(uppgift.handSpelare1[0], 0);
            UppdateraGrafik();
            btnKlar.Enabled = false;
        }

        private void pcbSpelare1Kort2_Click(object sender, EventArgs e)
        {
            uppgift.SlängKort(uppgift.handSpelare1[1], 1);
            UppdateraGrafik();
            btnKlar.Enabled = false;
        }

        private void pcbSpelare1Kort3_Click(object sender, EventArgs e)
        {
            uppgift.SlängKort(uppgift.handSpelare1[2],2);
            UppdateraGrafik();
            btnKlar.Enabled = false;
        }

        private void pcbSpelare1Kort4_Click(object sender, EventArgs e)
        {
            uppgift.SlängKort(uppgift.handSpelare1[3], 3);
            UppdateraGrafik();
            btnKlar.Enabled = false;
        }

        private void pcbSpelare1Kort5_Click(object sender, EventArgs e)
        {
            uppgift.SlängKort(uppgift.handSpelare1[4], 4);
            UppdateraGrafik();
            btnKlar.Enabled = false;
        }

        private void pcbSpelare2Kort1_Click(object sender, EventArgs e)
        {
            uppgift.SlängKort(uppgift.handSpelare2[0], 0);
            UppdateraGrafik();
            btnKlar.Enabled = false;
        }

        private void pcbSpelare2Kort2_Click(object sender, EventArgs e)
        {
            uppgift.SlängKort(uppgift.handSpelare2[1], 1);
            UppdateraGrafik();
            btnKlar.Enabled = false;
        }

        private void pcbSpelare2Kort3_Click(object sender, EventArgs e)
        {
            uppgift.SlängKort(uppgift.handSpelare2[2], 2);
            UppdateraGrafik();
            btnKlar.Enabled = false;
        }

        private void pcbSpelare2Kort4_Click(object sender, EventArgs e)
        {
            uppgift.SlängKort(uppgift.handSpelare2[3], 3);
            UppdateraGrafik();
            btnKlar.Enabled = false;
        }

        private void pcbSpelare2Kort5_Click(object sender, EventArgs e)
        {
            uppgift.SlängKort(uppgift.handSpelare2[4], 4);
            UppdateraGrafik();
            btnKlar.Enabled = false;
        }
    }
}
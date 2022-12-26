namespace OIBcheck;
public class OIBchecking
{
    public OIBchecking()
    {
    }

public bool OIBchk ( string oib)
            {
                 int ostatak = 0, umnozak = 0;
                //char znamenka;
                 int  vrije_chr, medjuzbroj=0;
                
                if ( oib.Length != 11)
                    { return false; }
                else
                {
                    vrije_chr = (oib[0]) - 48;
                    medjuzbroj = (vrije_chr + 10); // korak 1.
                    for (int i = 1; i <= 10; i++)
                    {
                        ostatak = medjuzbroj % 10; // korak  2.
                        if (ostatak == 0) ostatak = 10; 
                        umnozak = ostatak * 2; // korak 3.
                        ostatak = umnozak % 11; //4
                        
                        medjuzbroj = ostatak + (vrije_chr = (oib[i]) - 48);// korak 5
                    }
                    //System.Console.WriteLine("kont : "+ umnozak +" ostatak : "+ ostatak);
                if ((oib[10]-48)== 11 - ostatak)
                    {
                        return true;
                    }
                    else if ((oib[10]-48)== 0 && ostatak ==1 )
                    {
                        return true;
                    }
                }
                return false;
            }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Class3
    {
       
       public string BinaryToString(string data)
        {
            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < data.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }


        public string stringToBinary(string data)
        {
            bool formatBits = false;

            char[] buffer = new char[(((data.Length * 8) + (formatBits ? (data.Length - 1) : 0)))];
            int index = 0;
            for (int i = 0; i < data.Length; i++)
            {
                string binary = Convert.ToString(data[i], 2).PadLeft(8, '0');
                for (int j = 0; j < 8; j++)
                {
                    buffer[index] = binary[j];
                    index++;
                }
                if (formatBits && i < (data.Length - 1))
                {
                    buffer[index] = ' ';
                    index++;
                }
            }
            string a = new string(buffer);

            return a;

        }



        private string Back_S(string data)
        {
            StringBuilder Data = new StringBuilder();
            Data.Append(data[5]);
            Data.Append(data[9]);
            Data.Append(data[0]); 
            Data.Append(data[12]);
            Data.Append(data[7]);
            Data.Append(data[3]); 
            Data.Append(data[11]);
            Data.Append(data[14]);
            Data.Append(data[1]);
            Data.Append(data[4]);
            Data.Append(data[13]);
            Data.Append(data[8]);
            Data.Append(data[2]);
            Data.Append(data[15]);
            Data.Append(data[6]);
            Data.Append(data[10]);
            string SData = Data.ToString();
            return SData;
        }
 

        private string  desifre_Key, S, sifreli_metin,best, son;
        public string decrypt(string data,string key,string metin)
        {
          this.desifre_Key = stringToBinary( key) ;
          this.sifreli_metin = data;
          string sonuc = "";

            for (int i = 0; i < sifreli_metin.Length; i += 16)
            {
                best = sifreli_metin.Substring(i, 16); 

                for (int j = 48; j >= 0; j -= 16) 
                {
                    string ASDF=this.desifre_Key.Substring(j, 16);
                    string sonuckey = "";
                    int x_o_r= 0;
                    for (int k = 0; k < 16; k++)
                    {
                        x_o_r= Convert.ToInt32(best[k]) ^ Convert.ToInt32(ASDF[k]);
                        sonuckey += x_o_r.ToString();
                    }
                    if (j == 32 || j == 16)
                    { 
                        S = this.Back_S(sonuckey); 
                    }
                    else
                    { 
                        S = sonuckey;
                        
                    }
                    best = S;
                }

                sonuc += best;
            }
            if (metin.Length % 2 == 1)
            { son = this.BinaryToString(sonuc.Remove(sonuc.Length - 8, 8));  }
            else
            { son = this.BinaryToString(sonuc); }

            return this.son; 
        }

    }
}

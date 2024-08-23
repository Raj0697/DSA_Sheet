string[] frs = expression.Replace("-", "+-").Split('+');
            int ffz=0, ffm=1,fz,fm;
            foreach(string s in frs)
            {
                if (string.IsNullOrEmpty(s)) continue;
                string[] zm = s.Split('/');
                fz = Convert.ToInt32(zm[0]);
                fm = Convert.ToInt32(zm[1]);            
                ffz = ffz * fm + ffm * fz;
                ffm = ffm * fm;
                int cd=gcd(ffz,ffm);
                ffz /= cd;
                ffm /= cd;
            }
            return string.Format("{0}/{1}", ffz, ffm);
        }

        //and a gcd method
        int gcd(int a,int b)
        {
            if (a < 0) a = -a;            
            while (b != 0)
            {
                int r = b;
                b = a % b;
                a = r;
            }
            return a;

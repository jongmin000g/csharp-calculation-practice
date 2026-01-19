// See https://aka.ms/new-console-template for more information

{
             int x=3; 
             int y=4;

             if (x < y)
             {
                 Console.WriteLine("x is smaller than y");
             }
             else
             {
                 Console.WriteLine("y is smaller than x");
         }
            
             int num = -4;
             string pnz = (num > 0) ? "positive" : ((num < 0) ? "negetive" : "zero");
             Console.WriteLine(("the number is ") + pnz);

             string cal = "+";
             switch (cal)
             {
                 case "+":
                     Console.WriteLine(x + y);
                     break;
                 case "-":
                     Console.WriteLine( x - y);
                     break;
                 case "*":
                        Console.WriteLine( x * y);
                     break;
                 case "/":
                     Console.WriteLine( x / y);
                     break;
                 default:
                     Console.WriteLine( "올바르지 않은 연산자입니다." );
                     break;
             } 
        int a = 10;
        int b = 20000;
        int c = 0;
        while (a < b)
        {
            a *= 2;
            c += 1;

        }
        Console.WriteLine(c);
        int d = 0;
        while (true)
        {
            d+=1;
            if (d<10)
               continue;

            Console.WriteLine("its done");
            break;

         }
        int j = 1;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine(j);
        int p = 2;
        int r = p;
        int q = 3;
        
        for (int i = 1; p < 10000 ; i++)
        {
            p *= q;
            if ( p < 10000)
                continue;

            int k = q%10;
            if ( k == 1 || k == 3 || k == 4 || k == 5 || k ==6 || k ==7 || k ==8 || k ==9)   
                Console.WriteLine(r + "에" + q + "을 " + i + "번 곱하면 10000이 넘습니다.");

            else
                Console.WriteLine(r + "에" + q + "를 " + i + "번 곱하면 10000이 넘습니다.");


        }
        string star = "*";

        for (int i = 0; i <5; i ++)
        {
            Console.WriteLine(star);
            star += "**";
        }

        for ( int i = 2;  i <10 ; i++)
        {
            for ( int k = 1; k <10 ; k++)
            {
                Console.WriteLine(i + "x" + j +" = "+ (i*j));
            }
        }
        } // 기본 연산 및 제어문
        Console.WriteLine("--------------");


        {
            int[] a = new int[4];
            for (int i =0;i<4;i++)
            {
                a[i] = i+1;
                Console.WriteLine(a[i]);
            }

        } // 1차원 배열
        Console.WriteLine("--------------");
        {
            int[,,]a = new int[3,3,3];
        for (int i=0;i<3;i++)
        {
            for (int j=0;j<3;j++)
            {
                for (int k=0;k<3;k++)   
            {
                a[i,j,k] = i + j + k;
                Console.WriteLine("i"+i+", j"+j+", k"+k+" = "+a[i,j,k]);

            }
        }
        }
        int[][] b= new int[][] {new int[]{1,2,3}, new int[]{4,5,6}, new int[]{7,8,9}};
        Console.WriteLine(b[0][1]);
        int[] c = {1,2,3,4,5};
        Console.WriteLine(c[2]);
        int[,] d = {{1,2,3 },{4,5,6 },{7,8,9 } };
        Console.WriteLine(d[1,2]);
        } // 다차원 배열
        Console.WriteLine("--------------");

        {
        List<string> names = new List<string>(4);


        names.Add("min");
        names.Insert(0,"Jong");
        names.Add("Kim");
        names.Add("Park");
        names.RemoveAt(3);
        names.Add("Kim");
        names.Remove("Kim");
        Console.WriteLine(names[0] + names[1] + " " + names[2]);
        Console.WriteLine(names.Contains("Kim"));
        
        } // List
        Console.WriteLine("--------------");

        //{
           //List<string> test = new List<string>(4) {"one", "two", "three", "four"};
            //test.Clear();
            //Console.WriteLine("Count: " + test.Count + test[0]);
        //오류코드

        //}
        {
            int[][] b= new int[][] {new int[]{1,2,3}, new int[]{4,5,6}, new int[]{7,8,9}};
        b[0][1] = 10;
        Console.WriteLine(b[0][1]);
        } // jagged array
        Console.WriteLine("--------------");

        {
            Dictionary<string, string> city = new Dictionary<string, string>(3);
        city.Add("KR", "Seoul");
        city.Add("US", "Washington D.C.");
        city.Add("JP", "Tokyo");
        city.Remove("US");
        Console.WriteLine(city["KR"] + city["JP"]);

        foreach (KeyValuePair<string, string> pair in city)
        {
            Console.WriteLine("국가: " + pair.Key + ", 수도: " + pair.Value);
        }

        } // Dictionary
        Console.WriteLine("--------------");

        {
            int a = 1;
            int b = 3;
            for (int i =0; i <9; i++)
            {
                a*=b;
            }
            Console.WriteLine("초항 1, 공비 3, 10번째 항: "+a);
            Console.WriteLine("--------------");
        } // 등비수열

        {
            int[][] a = new int[][] { new int[] {1,5,9}, new int [] {4,8,12},new int[] {7,11,15} };
            Console.WriteLine("10보다 큰 수 :");
            foreach( int[] i in a )
            {
                foreach ( int j in i )
                {
                    if ( j > 10 )
                        Console.WriteLine(j);
                }
            }
            Console.WriteLine("--------------");
        } // 2차원 배열에서 조건에 맞는 값 출력

        {
            int[] a = new int[11];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i + 1;
            }
            Console.WriteLine("1~n 뒤집기:");
            for (int i = 0; i < (a.Length/2); i++)
            { 
                int b = a[i];
                a[i] = a[(a.Length)-i-1];
                a[(a.Length)-i-1] = b;
            }
            foreach (int n in a)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("--------------");

        } // 1~n 뒤집기

        {
            string[,] a = new string[5,5];
            Console.WriteLine("2차원 배열 대소 비교:");
            for (int i = 0; i < 5; i++)
            {
                for(int j=0;j<5;j++)
                {
                    a[i,j] = (i>j) ? "true" : ( i==j ? "same" : "false");
                    Console.WriteLine("a["+i+"]["+j+"] = "+ a[i,j]);
                }
            }
            Console.WriteLine("--------------");
        } // 2차원 배열 대소 비교

        {
            List<int> numbers = new List<int>();
            Console.WriteLine("0과 5의 조합으로 만든 수:");
            int a1=0;
            int b1=0;
            int c1=0;
            for (int a = 0; a < 2;a++)
            {
                a1 =a*5;
                for (int b = 0; b < 2;b++)
                {
                    b1 =b*5;
                    for (int c = 0; c < 2;c++)
                    {
                        c1=c*5;
                        numbers.Add( 100*a1 + 10*b1 + c1);
                        numbers.Remove(0);
                    }
                }
            }
            foreach(int n in numbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("--------------");
        } // 0과5의 조합으로 만든 수

        {
            int a = 0;
            Dictionary<string,int> xp = new Dictionary<string,int>();
            xp.Add("고블린", 10);
            xp.Add("오크", 20);
            xp.Add("트롤", 30);
            foreach (int b in xp.Values)
            {
                a += b;
            }
            Console.WriteLine("평균 경험치: " + (a/xp.Count));
            Console.WriteLine("--------------");
        } // 평균 경험치 계산

        {
            Dictionary<string,string> dictionary = new Dictionary<string,string>();
            Dictionary<string, string> dictionary1 = new Dictionary<string, string>();
            dictionary.Add("apple", "사과");
            dictionary.Add("banana", "바나나");
            dictionary.Add("orange", "오렌지");
            Console.WriteLine("사전 뒤집기");
            foreach (KeyValuePair<string,string> pair in dictionary)
            {
                dictionary1.Add(pair.Value, pair.Key);
                Console.WriteLine("한국어: " + pair.Value + ", 영어: " + pair.Key);
            }
            Console.WriteLine("--------------");
        } // 사전 뒤집기

        {

            int[,] a = {{1,2},{3,4}};
            int[,] b = {{5,6},{7,8}};
            int[,] c = new int[2,2];
            int[,] d = new int[2,2];
            Console.WriteLine("행렬 a: 1, 2   행렬 b: 5,6");
            Console.WriteLine("          3, 4          7,8");
            for (int i=0;i<2;i++)
            {
                for (int j=0;j<2;j++)
                {
                    c[i,j] = a[i,j] + b[i,j];
                    Console.WriteLine("합["+i+"]["+j+"] = " + c[i,j]);
                }
                for (int j=0;j<2;j++)
                {
                    d[i,j] = a[i,0] * b[0,j] + a[i,1] * b[1,j];
                    Console.WriteLine("곱["+i+"]["+j+"] = " + d[i,j]);
                }
            }
            Console.WriteLine("--------------");
        } // 2x2 행렬 덧셈과 곱셈

        {
            int[,] a = {{1,2,3},{4,5,6},{7,8,9}};
            int[,] b = new int[3,3];
            int[,] c = new int[3,3];
            Console.WriteLine("행렬 a: 1,2,3");
            Console.WriteLine("          4,5,6");
            Console.WriteLine("          7,8,9");
            for (int i=0;i<3;i++)
            {
                for (int j=0;j<3;j++)
                {
                    b[i,j] = a[i,j]*2;
                    Console.WriteLine("합["+i+"]["+j+"] = " + b[i,j]);
                    
                }
                for (int j=0;j<3;j++)
                {
                    c[i,j] = a[i,0]*a[0,j] + a[i,1]*a[1,j] + a[i,2]*a[2,j];
                    Console.WriteLine("곱["+i+"]["+j+"] = " + c[i,j]);
                }
            }
            Console.WriteLine("--------------");
        } // 3x3 행렬 덧셈과 곱셈

        {
            int[] a = new int[10]{5,2,7,9,6,-1,3,8,4,10};
            int[] b = new int[a.Length];
            Console.WriteLine("ascending sort:");
            
            for (int i=0;i<a.Length-1;i++)
            {
                if (a[i]>a[i+1])
                    {
                        b[i] = a[i];
                        a[i] = a[i+1];
                        a[i+1] = b[i];
                        i = -1;
                    }
            
            }
            foreach (int n in a)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("--------------");
        } // ascending sort

        {
            List<int> a = new List<int>() {5,2,7,9,6,-1,3,8,4,10};
            Console.WriteLine("ascending sort with List:");
           
                for (int i=0;i<a.Count-1;i++)
                {
                    if (a[i]>a[i+1])
                        {
                            int b = a[i];
                            a[i] = a[i+1];
                            a[i+1] = b;
                            i = -1;
                        }
            
                }
                foreach (int n in a)
                {
                    Console.WriteLine(n);
                }
                
            
        } // ascending sort with List

        {
            //int Powerof(int p,int q)
            //{
            //     int p1 = 1;
            //     for ( int i = 0; i<q ; i++)
            //     {
            //         p1 *= p;
            //     }
            //     return p1;
            // } // Powerof 함수, 사용하지 않음
            Console.WriteLine("--------------");
            Console.WriteLine("1부터 n까지 0과 5의 개수 세기:");
            int count = 0;
            int n = 0;
            int number = 2004;
            if ( number > 0)
            {
            
            for ( int i = 1 ; i <= number ; i ++ )
            {
                int k = i;
                while (k>0)
            {
                k /= 10;
                n ++;
            }

                for ( int j = 0 ; j < n ; j ++ )
                {
                        int P10 = 1;
                        for ( int m =0 ; m < j ; m ++ )
                        {
                            P10 *= 10;
                        }
                    
                        int a = i/P10 %10;
                        if ( a == 0 || a == 5)
                        {
                            count ++;
                        }
                    
                }
                n = 0;
            }
            Console.WriteLine("0과 5의 개수: " + count);
            }
            else
            Console.WriteLine("양수를 입력하세요.");
        } // 1부터 n까지 0과 5의 개수 세기

        {
            int count = 0;
            int number = 2004;
            Console.WriteLine("1부터 "+number+"까지 0과 5의 개수 세기 (다른 방법):");
            if (  number > 0)
            {   
                for ( int i = 1 ; i <= number ; i ++)
                   {
                    int k = i;
                    while(k>0)
                    {
                        int a = k % 10;
                        if ( a == 0 || a == 5)
                        {
                            count ++;
                        }
                        k /= 10;                        
                    }
                   }
                
                
                Console.WriteLine("0과 5의 개수: " + count);
            }
        
            
            else
            Console.WriteLine("양수를 입력하세요.");
        } // 1부터 n까지 0과 5의 개수 세기 (다른 방법)


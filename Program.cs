           int Nature_Numbers( int M, int N )
           {
           
           if(M<=0)
            { 
                Nature_Numbers (M+1,N);
                return M;
             }
              else
                {
                  if(M==N)  
                   {
                    Console.WriteLine(M + " ");
                    return M;
                   }
             
                }
            
              Console.Write(M + " ");
              Nature_Numbers (M+1,N);
              
              return M ;
            }
           
       Nature_Numbers (10,30);


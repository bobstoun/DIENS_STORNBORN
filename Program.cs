

//int FiLLArray = (int[,]matr);
//  for (int og = 0; og < matr.GetLength(0); og++)
  
//  for (int oe = 0; oe < matr.GetLength(1); oe++)

//  {
  // Console.Write($"{matr [og, oe]}");
//  }

  // Console.WriteLine();
  //}   
int[,] cip =  new int[,]
{
{0,1,1,1,0,0,0,0,0,1,1,1,0,0},
{0,1,1,1,2,0,0,0,0,1,1,1,0,0},
{0,0,0,0,0,0,0,1,0,0,0,0,0,0},
{1,1,0,0,0,0,1,1,1,0,0,0,1,1},
{0,1,1,0,0,0,0,0,0,0,0,1,1,0},
{0,0,1,1,1,1,1,1,1,1,1,1,0,0},
};
  void Prontcip (int[,]cip)

  {
   for (int i = 0; i < cip.GetLongLength(0);i++)

{
        for (int j = 0; j < cip.GetLength(1);j++)
  {
    if (cip[i,j] == 0) Console.Write($" ");
    
      else Console.Write($"+");
  } 
      Console.WriteLine();   
}
  }
  
Prontcip(cip);

 



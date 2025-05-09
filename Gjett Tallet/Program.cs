 
     Random random = new Random();
     int randomNumber = random.Next(1, 101); 
     Console.WriteLine("Jeg tenker på et tall mellom 1 og 100, hva gjetter du?");
     

     string input;
     
     while (true)
     {
         input = Console.ReadLine();
         
         if (int.TryParse(input, out int userGuess))
         {
             if (userGuess == randomNumber)
             {
                 Console.WriteLine("Riktig, bra gjetta!! Vil du kjøre en runde til?");
                 string svar = Console.ReadLine();
                 if (svar.ToLower() == "ja")
                 {
                     randomNumber = random.Next(1, 101);
                     Console.WriteLine("Jeg tenker på et tall mellom 1 og 100, hva gjetter du?");
                 }
                 else
                 {
                     Console.WriteLine("Takk for nå! Hadeee!");
                     break;
                 }
             }
             else if (userGuess < randomNumber)
             {
                 Console.WriteLine("Gjett litt højere");
             }
             else if (userGuess > randomNumber)
             {
                 Console.WriteLine("Tallet er litt lavere");
             }

         }
     }
     
 
        
        
        
        
        
        
      
    






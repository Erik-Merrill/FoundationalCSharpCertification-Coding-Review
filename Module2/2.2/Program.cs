Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;


/*if (daysUntilExpiration <= 10){
    if (daysUntilExpiration <=5){
        if (daysUntilExpiration == 1){
           Console.WriteLine("Your subscription expires within a day!\nRenew now and save 20%!");
            discountPercentage = 20;
        } else {
            Console.WriteLine("Your subscription has expired.");
        }
        Console.WriteLine($"Your subscription expires in {daysUntilExpiration}\n Renew now and save 10%!");
        discountPercentage = 10;
    } 
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}*/

if (daysUntilExpiration == 0){
    Console.WriteLine("Your subscription has expired.");
} else if (daysUntilExpiration <=1){
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
} else if (daysUntilExpiration <=5){
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration}");
    discountPercentage = 10;    
} else if (daysUntilExpiration <= 10){
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0){
    Console.WriteLine($"Renew now and receive a {discountPercentage}% discount!");
}
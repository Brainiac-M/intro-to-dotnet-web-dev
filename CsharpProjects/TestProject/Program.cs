Random random = new Random();
int daysUntilExpiration = random.Next(15);
int discountPercentage = 0;

if ( daysUntilExpiration <= 10 ){
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if( daysUntilExpiration <= 5){
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");
}
else if( daysUntilExpiration == 1){
    discountPercentage = 20;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");
}
else if( daysUntilExpiration == 0){
    Console.WriteLine($"Your subscription has expired.");
}

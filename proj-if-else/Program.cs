Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = daysUntilExpiration == 1 ? 20 : 10;
string message = "";
string discountMessage = $"\nRenew now and save {discountPercentage}%!";

Console.WriteLine($"Days until expiration: {daysUntilExpiration}.");

if (daysUntilExpiration <= 10)
{
  message = "Your subscription will expire soon. Renew now!";
}

if (daysUntilExpiration <= 5)
{
  message = $"Your subscription expires in {daysUntilExpiration} days. {discountMessage}";
}

if (daysUntilExpiration == 0)
{
  message = "Your subscription has expired.";
}

if (daysUntilExpiration == 1)
{
  message = $"Your subscription expires within a day! {discountMessage}";
}

Console.WriteLine(message);

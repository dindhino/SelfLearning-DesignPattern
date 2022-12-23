// See https://aka.ms/new-console-template for more information
Stock abcStock = new Stock();

BuyStock buyStockOrder = new BuyStock(abcStock);
SellStock sellStockOrder = new SellStock(abcStock);

Broker broker = new Broker();
broker.TakeOrder(buyStockOrder);
broker.TakeOrder(sellStockOrder);

broker.PlaceOrders();

Console.ReadLine();
// See https://aka.ms/new-console-template for more information
using OOTPLab1;

var toyotaWebShop = new WebShop(new ToyotaWebShopFactory());
toyotaWebShop.SellCar(); // sells a Toyota Camry

var fordWebShop = new WebShop(new FordWebShopFactory());
fordWebShop.SellCar(); // sells a Ford Explorer

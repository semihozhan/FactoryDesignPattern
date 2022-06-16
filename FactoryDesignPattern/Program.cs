using FactoryDesignPattern;

Creater creater = new Creater();
Games atari = creater.FactoryMethod(GameTypes.Atari);
Games playstation = creater.FactoryMethod(GameTypes.Playstation);
Games computer= creater.FactoryMethod(GameTypes.Computer);

atari.Platform();
playstation.Platform();
computer.Platform();

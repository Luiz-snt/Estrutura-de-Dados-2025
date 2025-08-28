using Queue;

Random random = new Random();

CallCenter center = new CallCenter();
center.Call(1234);
center.Call(5678);
center.Call(1468);
center.Call(9641);
center.Call(4321);
center.Call(1122);

while (center.AreWaitingCalls())
{
    IncomingCall call = center.Answer("Paulão");
    Console.WriteLine($"Chamado {call.Id} do clinte {call.ClientId}, atentido por {call.Consultant}");

    Console.WriteLine($"-- Em: {call.StartTime} --");

    Thread.Sleep(random.Next(1000, 10000));

    center.End(call);

    Console.WriteLine($"Chamado {call.Id} do cliente {call.ClientId}, encerrado por {call.Consultant} ");
    Console.WriteLine($"-- Em: {call.EndTime} --");
}
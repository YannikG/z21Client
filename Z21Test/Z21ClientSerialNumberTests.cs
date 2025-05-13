using Z21Test.Base;

namespace Z21Test;

public class Z21ClientSerialNumberTests : BaseUnitTestWithSendAsync
{
    private readonly byte[] _expectedCommandSent = { 0x04, 0, 0x10, 0 };
    private const int _expectedCommandSentLength = 4;
    [SetUp]
    public void Setup()
    {
        BaseSetup();
        
        
        FinalizeSetup();
    }

    [Test]
    public void Test_GetSerialNumber_Happy()
    {
        _client.GetSerialNumber();
        
        Assert.That(_sentBytes, Is.EqualTo(_expectedCommandSentLength));
        Assert.That(_sentDatagram, Is.EqualTo(_expectedCommandSent));
    }
}
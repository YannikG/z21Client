using Moq;
using Z21;

namespace Z21Test.Base;

public class BaseUnitTestWithSendAsync
{
    protected Mock<IZ21Communicator> _mockCommunicator;
    protected Client _client;
    protected byte[] _sentDatagram;
    protected int _sentBytes;
    
    /// <summary>
    /// Setup communicator mock to catch sent commands.
    /// </summary>
    protected void BaseSetup()
    {
        _mockCommunicator = new Mock<IZ21Communicator>();
        
        _mockCommunicator.Setup(m => m.SendAsync(It.IsAny<byte[]>(), It.IsAny<int>()))
            .Callback((byte[] datagram, int bytes) =>
            {
                _sentDatagram = datagram;
                _sentBytes = bytes;
            });
    }
    
    /// <summary>
    /// Initialize client with communicator mock.
    /// </summary>
    protected void FinalizeSetup()
    {
        _client = new Client(_mockCommunicator.Object);
    }
}
/* Z21 - C#-Implementierung des Protokolls der Kommunikation mit der digitalen
 * Steuerzentrale Z21 oder z21 von Fleischmann/Roco
 * ---------------------------------------------------------------------------
 * Datei:     z21.cs
 * Version:   16.06.2014
 * Besitzer:  Mathias Rentsch (rentsch@online.de)
 * Lizenz:    GPL
 *
 * Die Anwendung und die Quelltextdateien sind freie Software und stehen unter der
 * GNU General Public License. Der Originaltext dieser Lizenz kann eingesehen werden
 * unter http://www.gnu.org/licenses/gpl.html.
 * 
 */

using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Versioning;
using System.Threading.Tasks;

namespace Z21
{
    public class Z21Communicator(int port) : UdpClient(port), IZ21Communicator
    {
        [SupportedOSPlatform("windows")]
        void IZ21Communicator.AllowNatTraversal(bool v) => base.AllowNatTraversal(v);

        void IZ21Communicator.BeginReceive(AsyncCallback asyncCallback, object value) => base.BeginReceive(asyncCallback, value);

        void IZ21Communicator.Close() => base.Close();

        void IZ21Communicator.Connect(IPAddress address, int port) => base.Connect(address, port);

        void IZ21Communicator.Dispose() => base.Dispose();

        byte[] IZ21Communicator.EndReceive(IAsyncResult res, ref IPEndPoint? iPEndPoint) => base.EndReceive(res, ref iPEndPoint);

        async Task<int> IZ21Communicator.SendAsync(byte[] datagram, int bytes) => await base.SendAsync(datagram, bytes);
    }
}

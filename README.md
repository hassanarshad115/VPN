<H1>
PureVPN </H1>
ATOM VPN SDK demo for Windows Desktop Applications
This is a demo application for Windows Desktop Applications with basic usage of ATOM VPN SDK which will help the developers to create smooth applications over ATOM SDK quickly.

<h1>SDK Features covered in this Demo</h1>
Connection with Parameters
Connection with Pre-Shared Key (PSK)
Connection with Dedicated IP
Connection with Multiple Protocols (Auto-Retry Functionality)
Connection with Real-time Optimized Servers (Countries based on latency from user in Real-time)
<h1>Compatibility</h1>
Compatible with Microsoft Visual Studio 2015 and onwards
Minimum .Net Framework 4.5 required
Compatible with ATOM SDK Version 1.0.4 and onwards
Supported Protocols
IKEv2
L2TP
PPTP
SSTP
TCP
UDP
<h1>SDK Installation</h1>
Install the latest version of Atom Windows SDK through NuGet.

Install-Package Atom.SDK.Net -Version 1.0.4
A configuration file is provided along with the SDK namely “Atom.SDK.Net.dll.config” which needs to be configured to work properly and should be present in the same directory as your installation directory e.g. C:\ProgramFiles\YourSoftware. Default values are pre-filled for the developer ease.

Run Atom.SDK.Installer.exe to install supporting services and drivers. The services will be installed and copied to the paths provided in the config file.

<h1>Getting Started with the Code</h1>
ATOM SDK needs to be initialized with a “SecretKey” provided to you after you buy the subscription which is typically a hex-numeric literal.

var atomManagerInstance = AtomManager.Initialize(“SECRETKEY_GOES_HERE”);
OR

It can be initialized using an instance of AtomConfiguration. It should have a VpnInterfaceName which will be used to create the Network Interface for VPN connection.

var atomConfiguration = new AtomConfiguration(“SECRETKEY_GOES_HERE”);
atomConfiguration.VpnInterfaceName = "Atom";
atomConfiguration.BaseUrl = "YOUR_BASE_URL"; // Optional
var atomManagerInstance = AtomManager.Initialize(atomConfiguration);
PS: ATOM SDK is a singleton, and must be initialized before accessing its methods, otherwise NullObjectReference Exception will be thrown.

<h1>Events to Register</h1>
ATOM SDK offers five events to register for the ease of the developer.

StateChanged
Connected
Disconnected
DialError
Redialing
Details of these events can be seen in the inline documentation or method summaries. You need to register these events to get notified about what’s happening behind the scenes

atomManagerInstance.Connected += AtomManagerInstance_Connected;
atomManagerInstance.DialError += AtomManagerInstance_DialError;
atomManagerInstance.Disconnected += AtomManagerInstance_Disconnected;
atomManagerInstance.StateChanged += AtomManagerInstance_StateChanged;
atomManagerInstance.Redialing += AtomManagerInstance_Redialing;
Events will be registered with the respective EventArgs customized for the ease of the developer.

<h1>VPN Authentication</h1>
ATOM SDK provided two ways to authenticate your vpn user. First one is to offer VPN Credentials directly to the SDK which you may create through the Admin Panel provided by ATOM.

atomManagerInstance.Credentials = new Credentials(“VPNUsername”, “VPNPassword”);
Alternatively, if you don’t want to take hassle of creating users yourself, leave it on us and we will do the rest for you! Easy isn't it.

atomManagerInstance.UUID = “UniqueUserID”;
You just need to provide a Unique User ID for your user e.g. any unique hash or even user’s email which you think remains consistent and unique for your user. ATOM SDK will generate VPN Account behind the scenes automatically and gets your user connected!

<h1>VPN Connection</h1>
You need to declare an object of “VPNProperties” Class to define your connection preferences. Details of all the available properties can be seen in the inline documentation of “VPNProperties” Class. For the least, you need to give Country and Protocol with which you want to connect.

var vpnProperties = new VPNProperties(Country country, Protocol protocol);
Fetch Countries
You can get the Countries list through ATOM SDK.

var countries = atomManagerInstance.GetCountries();
<h1>Fetch Protocols</h1>
Protocols can be obtained through ATOM SDK as well.

var protocols = atomManagerInstance.GetProtocols(); 
<h1>How to Connect</h1>
As soon as you call Connect method, the events you were listening to will get the updates about the states being changed and Dial Error (if any occurs as well).

After initializing the VPNProperties, just call Connect method of ATOM SDK.

<h1>Connection with Parameters</h1>
It is the simplest way of connection which is well explained in the steps above. You just need to provide the Country and the Protocol objects and call the Connect method.

var vpnProperties = new VPNProperties(Country country, Protocol protocol);
atomManagerInstance.Connect(properties);
<h1>Connection with Pre-Shared Key (PSK)</h1>
In this way of connection, it is pre-assumed that you have your own backend server which communicates with ATOM Backend APIs directly and creates a Pre-Shared Key (usually called as PSK) which you can then provide to the SDK for dialing. While providing PSK, no VPN Property other than PSK is required to make the connection. ATOM SDK will handle the rest.

var vpnProperties = new VPNProperties(string PSK);
atomManagerInstance.Connect(properties);
<h1>Connection with Dedicated IP</h1>
You can also make your user comfortable with this type of connection by just providing them with a Dedicated DNS Host and they will always connect to a dedicated server! For this purpose, ATOM SDK provides you with the following constructor.

var vpnProperties = new VPNProperties(string hostName, Protocol protocol); 
atomManagerInstance.Connect(properties);
<h1>Connection with Real-time Optimized Servers</h1>
This one is same as the first one i.e. “Connection with Parameters” with a slight addition of using Real-time optimized servers best from your user’s location. You just need to set this property to TRUE and rest will be handled by the ATOM SDK.

vpnProperties.UseOptimization= true;
For more information, please see the inline documentation of VPNProperties Class.

If you want to show your user the best location for him on your GUI then ATOM SDK have it ready for you as well! ATOM SDK has a method exposed namely “GetOptimizedCountries()” which adds a property “Latency” in the country object which has the real-time latency of all countries from your user’s location (only if ping is enabled on your user’s system and ISP doesn’t blocks any of our datacenters). You can use this property to find the best speed countries from your user’s location.

<h1>Connection with Multiple Protocols (Auto-Retry Functionality)</h1>
You can provide Three Protocols at max so ATOM SDK can attempt automatically on your behalf to get your user connected with the Secondary or Tertiary protocol if your base Protocol fails to connect.

vpnProperties.SecondaryProtocol = ProtocolObject;
vpnProperties.TertiaryProtocol = ProtocolObject;
For more information, please see the inline documentation of VPNProperties Class.

<h1>Cancel VPN Connection</h1>
You can cancel connection between dialing process by calling the Cancel method.

atomManagerInstance.Cancel();
<h1>Disconnect VPN Connection</h1>
To disconnect, simply call the Disconnect method of AtomManager.

atomManagerInstance.Disconnect();

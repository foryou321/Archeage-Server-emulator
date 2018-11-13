﻿using ArcheAgeGame.ArcheAge.Network.Connections;
using LocalCommons.Network;
using LocalCommons.Utilities;

namespace ArcheAgeGame.ArcheAge.Network
{
    public sealed class NP_SCUnitMovementsPacket_0x0066 : NetPacket
    {
        public NP_SCUnitMovementsPacket_0x0066(ClientConnection net) : base(01, 0x0066)
        {
            //1.0.1406
            //SCUnitMovementsPacket
            //          opcode count bc     c  time     flag ix     iy     iz     vel.x vel.y vel.z rot.x rot.y rot.z s.av0    s.av1    s.av2    s.s s.t s.z  s.st 
            //3500 DD01 6600   0100  042D01 03 93560100 00   AF067B FB6A77 4E0A03 FCFF  FBFF  FFFF  1E00  EAFF  033C  78BE163A 0DAB6FBA E31E923A 00  00  B300 00
            //          opcode count bc     c  time     flag ix     iy     iz     vel.x vel.y vel.z rot.x rot.y rot.z a.dm.x a.dm.y a.dm.x a.s a.a a.f
            //2700 DD01 6600   0100  77C000 01 F2C90B00 00   CAAB79 AC3578 6A7303 0000  0000  0000  00    00    39    00     00     00     01  00  04
            //2700 DD01 6600   0100  7DFA00 01 99BE1A00 00   CAA979 BA3678 6A7303 23FF  4CFE  0000  00    00    3B    00     00     00     01  00  04

			//ns.WriteHex("2700DD016600010077C00001F2C90B0000AAA57A0518764A5C03000000000000000039000000010004");
//	        ns.WriteHex("3500DD0166000100042D01039356010000AAA57A0518764A5C03FCFFFBFFFFFF1E00EAFF033C78BE163A0DAB6FBAE31E923A0000B30000");



			//return;

            //c: 1-actor; 2-vehicle; 3-ship; 4-shipRequest; 5-transfer; 6-default;
	  //      Uint24 X = Float24.ToInt32(LocalCommons.Utilities.Helpers.ConvertX(x));
	  //      Uint24 Y = Float24.ToInt32(LocalCommons.Utilities.Helpers.ConvertX(y));
			//Uint24 Z = Float24.ToInt32(LocalCommons.Utilities.Helpers.ConvertX(z));
            //0100
			short count = 1; //count h
            ns.Write((short)count); //count h id=0 
            for (int i = 0; i < count; i++) //  - <for id="0">
            {
                //042D01
                //bc = 0x012D04;
                ns.Write((Uint24)net.CurrentAccount.Character.LiveObjectId);//UnitID bc b size=3  //liveObjectId d3 from SCUnitStatePacket
                byte c = 1;
                ns.Write((byte)c); //type c id=1 
                int time = 0;
                ns.Write((int)time); //time d 
                byte flag = 0;
                ns.Write((byte)flag); //flags c id=2 

                switch (flag) //  - <bitwise_switch id="2">
                {
                    case 0x10: //  - <case id="0x10">
                        int scType = 0;
                        byte phase = 0;
                        ns.Write((int)scType); //scType d 
                        ns.Write((byte)phase); //phase c 
                        break; //  </case>
                    default: //  <case id="default 
                        break;
                } //  </bitwise_switch>
                switch (c) //  - <switch id="1">
                {
                    case 1: //  - <case id="1">
							//ns.Write((Uint24)X); //ix d3 
							//ns.Write((Uint24)Y); //iy d3 
							//ns.Write((Uint24)Z); //iz d3 
						ns.Write(LocalCommons.Utilities.Helpers.ConvertX(net.CurrentAccount.Character.Position.X), 0, 3);
						ns.Write(LocalCommons.Utilities.Helpers.ConvertY(net.CurrentAccount.Character.Position.Y), 0, 3);
						ns.Write(LocalCommons.Utilities.Helpers.ConvertZ(net.CurrentAccount.Character.Position.Z), 0, 3);
						ns.Write((short)0); //vel.x h 
                        ns.Write((short)0); //vel.y h 
                        ns.Write((short)0); //vel.z h 
                        ns.Write((byte)0); //rot.x C 
                        ns.Write((byte)0); //rot.y C 
                        ns.Write((byte)0); //rot.z C 
                        ns.Write((byte)0); //actor.deltaMovement.x C 
                        ns.Write((byte)0); //actor.deltaMovement.y C 
                        ns.Write((byte)0); //actor.deltaMovement.z C 
                        ns.Write((byte)1); //actor.stance C 
                        ns.Write((byte)0); //actor.alertness C 
                        ns.Write((byte)4); //actor.flags C 
                        switch (flag) //  - <bitwise_switch id="2">
                        {
                            case 0x20: //  - <case id="0x20">
                                ns.Write((byte)0); //actor.gcFlags C 
                                ns.Write((byte)0); //actor.gcPartId C 

												   //ns.Write((Uint24)X); //ix d3 
												   //ns.Write((Uint24)Y); //iy d3 
												   //ns.Write((Uint24)Z); //iz d3 
								ns.Write(LocalCommons.Utilities.Helpers.ConvertX(net.CurrentAccount.Character.Position.X), 0, 3);
								ns.Write(LocalCommons.Utilities.Helpers.ConvertY(net.CurrentAccount.Character.Position.Y), 0, 3);
								ns.Write(LocalCommons.Utilities.Helpers.ConvertZ(net.CurrentAccount.Character.Position.Z), 0, 3);
								ns.Write((byte)0); //rot.x C 
                                ns.Write((byte)0); //rot.y C 
                                ns.Write((byte)0); //rot.z C 
                                break; //  </case>
                            case 0x40: //  - <case id="0x40">
                                ns.Write((int)0); //actor.climbData d 
                                break; //  </case>
                            case 0x60: //  - <case id="0x60">
                                ns.Write((int)0); //actor.gcId d 
                                break; //  </case>
                            case 0x80: //  - <case id="0x80">
                                ns.Write((short)0); //actor.fallVel h 
                                break; //  </case>
                            default: //  <case id="default 
                                break;
                        } //  </bitwise_switch>
                        break; //  </case>
                    case 2: //  - <case id="2">
							//ns.Write((Uint24)X); //ix d3 
							//ns.Write((Uint24)Y); //iy d3 
							//ns.Write((Uint24)Z); //iz d3 
						ns.Write(LocalCommons.Utilities.Helpers.ConvertX(net.CurrentAccount.Character.Position.X), 0, 3);
						ns.Write(LocalCommons.Utilities.Helpers.ConvertY(net.CurrentAccount.Character.Position.Y), 0, 3);
						ns.Write(LocalCommons.Utilities.Helpers.ConvertZ(net.CurrentAccount.Character.Position.Z), 0, 3);
						ns.Write((short)0); //vel.x h 
                        ns.Write((short)0); //vel.y h 
                        ns.Write((short)0); //vel.z h 
                        ns.Write((short)0); //rot.x h 
                        ns.Write((short)0); //rot.y h 
                        ns.Write((short)0); //rot.z h 
                        ns.Write((float)0); //vehicle.angVel[0] f 
                        ns.Write((float)0); //vehicle.angVel[1] f 
                        ns.Write((float)0); //vehicle.angVel[2] f 
                        ns.Write((byte)0); //vehicle.steering C 
                        ns.Write((byte)0); //vehicle.wheelVelCount C 
                        break; //  </case>
                    case 3: //  - <case id="3">
							//ns.Write((Uint24)X); //ix d3 
							//ns.Write((Uint24)Y); //iy d3 
							//ns.Write((Uint24)Z); //iz d3 
						ns.Write(LocalCommons.Utilities.Helpers.ConvertX(net.CurrentAccount.Character.Position.X), 0, 3);
						ns.Write(LocalCommons.Utilities.Helpers.ConvertY(net.CurrentAccount.Character.Position.Y), 0, 3);
						ns.Write(LocalCommons.Utilities.Helpers.ConvertZ(net.CurrentAccount.Character.Position.Z), 0, 3);
						ns.Write((short)0); //vel.x h 
                        ns.Write((short)0); //vel.y h 
                        ns.Write((short)0); //vel.z h 
                        ns.Write((short)0); //rot.x h 
                        ns.Write((short)0); //rot.y h 
                        ns.Write((short)0); //rot.z h 
                        ns.Write((float)0); //ship.angVel[0] f 
                        ns.Write((float)0); //ship.angVel[1] f 
                        ns.Write((float)0); //ship.angVel[2] f 
                        ns.Write((byte)0); //ship.steering C 
                        ns.Write((byte)0); //ship.throttle C 
                        ns.Write((short)0); //ship.zoneId h 
                        ns.Write((byte)0); //ship.stucked C 
                        break; //  </case>
                    case 4: //  - <case id="4">
                        ns.Write((byte)0); //shipRequest.throttle C 
                        ns.Write((byte)0); //shipRequest.steering C 
                        break; //  </case>
                    case 5: //  - <case id="5">
							//ns.Write((Uint24)X); //ix d3 
							//ns.Write((Uint24)Y); //iy d3 
							//ns.Write((Uint24)Z); //iz d3 
						ns.Write(LocalCommons.Utilities.Helpers.ConvertX(net.CurrentAccount.Character.Position.X), 0, 3);
						ns.Write(LocalCommons.Utilities.Helpers.ConvertY(net.CurrentAccount.Character.Position.Y), 0, 3);
						ns.Write(LocalCommons.Utilities.Helpers.ConvertZ(net.CurrentAccount.Character.Position.Z), 0, 3);
						ns.Write((short)0); //vel.x h 
                        ns.Write((short)0); //vel.y h 
                        ns.Write((short)0); //vel.z h 
                        ns.Write((short)0); //rot.x h 
                        ns.Write((short)0); //rot.y h 
                        ns.Write((short)0); //rot.z h 
                        ns.Write((float)0); //transfer.angVel[0] f 
                        ns.Write((float)0); //transfer.angVel[1] f 
                        ns.Write((float)0); //transfer.angVel[2] f 
                        ns.Write((int)0); //transfer.steering d 
                        ns.Write((int)0); //transfer.pathPointIndex d 
                        ns.Write((float)0); //transfer.speed f 
                        ns.Write((byte)0); //transfer.reverse C 
                        break; //  </case>
                    default: //  - <case id="default">
							 //ns.Write((Uint24)X); //ix d3 
							 //ns.Write((Uint24)Y); //iy d3 
							 //ns.Write((Uint24)Z); //iz d3 
						ns.Write(LocalCommons.Utilities.Helpers.ConvertX(net.CurrentAccount.Character.Position.X), 0, 3);
						ns.Write(LocalCommons.Utilities.Helpers.ConvertY(net.CurrentAccount.Character.Position.Y), 0, 3);
						ns.Write(LocalCommons.Utilities.Helpers.ConvertZ(net.CurrentAccount.Character.Position.Z), 0, 3);
						ns.Write((short)0); //vel.x h 
                        ns.Write((short)0); //vel.y h 
                        ns.Write((short)0); //vel.z h 
                        ns.Write((short)0); //rot.x h 
                        ns.Write((short)0); //rot.y h 
                        ns.Write((short)0); //rot.z h 
                        break;   //  </case>
                } //  </switch>
            } //  </for>
        }
    }
}

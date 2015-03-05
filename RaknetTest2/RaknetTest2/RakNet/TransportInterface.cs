/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace RakNet {

using System;
using System.Runtime.InteropServices;

public class TransportInterface : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TransportInterface(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TransportInterface obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TransportInterface() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_TransportInterface(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual bool Start(ushort port, bool serverMode) {
    bool ret = RakNetPINVOKE.TransportInterface_Start(swigCPtr, port, serverMode);
    return ret;
  }

  public virtual void Stop() {
    RakNetPINVOKE.TransportInterface_Stop(swigCPtr);
  }

  public virtual void CloseConnection(SystemAddress systemAddress) {
    RakNetPINVOKE.TransportInterface_CloseConnection(swigCPtr, SystemAddress.getCPtr(systemAddress));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual Packet Receive() {
    IntPtr cPtr = RakNetPINVOKE.TransportInterface_Receive(swigCPtr);
    Packet ret = (cPtr == IntPtr.Zero) ? null : new Packet(cPtr, false);
    return ret;
  }

  public virtual void DeallocatePacket(Packet packet) {
    RakNetPINVOKE.TransportInterface_DeallocatePacket(swigCPtr, Packet.getCPtr(packet));
  }

  public virtual SystemAddress HasNewIncomingConnection() {
    SystemAddress ret = new SystemAddress(RakNetPINVOKE.TransportInterface_HasNewIncomingConnection(swigCPtr), true);
    return ret;
  }

  public virtual SystemAddress HasLostConnection() {
    SystemAddress ret = new SystemAddress(RakNetPINVOKE.TransportInterface_HasLostConnection(swigCPtr), true);
    return ret;
  }

  public virtual CommandParserInterface GetCommandParser() {
    IntPtr cPtr = RakNetPINVOKE.TransportInterface_GetCommandParser(swigCPtr);
    CommandParserInterface ret = (cPtr == IntPtr.Zero) ? null : new CommandParserInterface(cPtr, false);
    return ret;
  }

  public void Send(SystemAddress systemAddress, byte[] inByteArray) {
    RakNetPINVOKE.TransportInterface_Send(swigCPtr, SystemAddress.getCPtr(systemAddress), inByteArray);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
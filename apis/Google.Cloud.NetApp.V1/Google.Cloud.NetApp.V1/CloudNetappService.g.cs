// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/netapp/v1/cloud_netapp_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.NetApp.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/netapp/v1/cloud_netapp_service.proto</summary>
  public static partial class CloudNetappServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/netapp/v1/cloud_netapp_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CloudNetappServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFnb29nbGUvY2xvdWQvbmV0YXBwL3YxL2Nsb3VkX25ldGFwcF9zZXJ2aWNl",
            "LnByb3RvEhZnb29nbGUuY2xvdWQubmV0YXBwLnYxGhxnb29nbGUvYXBpL2Fu",
            "bm90YXRpb25zLnByb3RvGhdnb29nbGUvYXBpL2NsaWVudC5wcm90bxofZ29v",
            "Z2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNv",
            "dXJjZS5wcm90bxotZ29vZ2xlL2Nsb3VkL25ldGFwcC92MS9hY3RpdmVfZGly",
            "ZWN0b3J5LnByb3RvGiBnb29nbGUvY2xvdWQvbmV0YXBwL3YxL2ttcy5wcm90",
            "bxooZ29vZ2xlL2Nsb3VkL25ldGFwcC92MS9yZXBsaWNhdGlvbi5wcm90bxol",
            "Z29vZ2xlL2Nsb3VkL25ldGFwcC92MS9zbmFwc2hvdC5wcm90bxopZ29vZ2xl",
            "L2Nsb3VkL25ldGFwcC92MS9zdG9yYWdlX3Bvb2wucHJvdG8aI2dvb2dsZS9j",
            "bG91ZC9uZXRhcHAvdjEvdm9sdW1lLnByb3RvGiNnb29nbGUvbG9uZ3J1bm5p",
            "bmcvb3BlcmF0aW9ucy5wcm90bxobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5LnBy",
            "b3RvGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvIoACChFPcGVy",
            "YXRpb25NZXRhZGF0YRI0CgtjcmVhdGVfdGltZRgBIAEoCzIaLmdvb2dsZS5w",
            "cm90b2J1Zi5UaW1lc3RhbXBCA+BBAxIxCghlbmRfdGltZRgCIAEoCzIaLmdv",
            "b2dsZS5wcm90b2J1Zi5UaW1lc3RhbXBCA+BBAxITCgZ0YXJnZXQYAyABKAlC",
            "A+BBAxIRCgR2ZXJiGAQgASgJQgPgQQMSGwoOc3RhdHVzX21lc3NhZ2UYBSAB",
            "KAlCA+BBAxIjChZyZXF1ZXN0ZWRfY2FuY2VsbGF0aW9uGAYgASgIQgPgQQMS",
            "GAoLYXBpX3ZlcnNpb24YByABKAlCA+BBAzLzOwoGTmV0QXBwErgBChBMaXN0",
            "U3RvcmFnZVBvb2xzEi8uZ29vZ2xlLmNsb3VkLm5ldGFwcC52MS5MaXN0U3Rv",
            "cmFnZVBvb2xzUmVxdWVzdBowLmdvb2dsZS5jbG91ZC5uZXRhcHAudjEuTGlz",
            "dFN0b3JhZ2VQb29sc1Jlc3BvbnNlIkGC0+STAjISMC92MS97cGFyZW50PXBy",
            "b2plY3RzLyovbG9jYXRpb25zLyp9L3N0b3JhZ2VQb29sc9pBBnBhcmVudBL2",
            "AQoRQ3JlYXRlU3RvcmFnZVBvb2wSMC5nb29nbGUuY2xvdWQubmV0YXBwLnYx",
            "LkNyZWF0ZVN0b3JhZ2VQb29sUmVxdWVzdBodLmdvb2dsZS5sb25ncnVubmlu",
            "Zy5PcGVyYXRpb24ijwGC0+STAkAiMC92MS97cGFyZW50PXByb2plY3RzLyov",
            "bG9jYXRpb25zLyp9L3N0b3JhZ2VQb29sczoMc3RvcmFnZV9wb29s2kEjcGFy",
            "ZW50LHN0b3JhZ2VfcG9vbCxzdG9yYWdlX3Bvb2xfaWTKQSAKC1N0b3JhZ2VQ",
            "b29sEhFPcGVyYXRpb25NZXRhZGF0YRKlAQoOR2V0U3RvcmFnZVBvb2wSLS5n",
            "b29nbGUuY2xvdWQubmV0YXBwLnYxLkdldFN0b3JhZ2VQb29sUmVxdWVzdBoj",
            "Lmdvb2dsZS5jbG91ZC5uZXRhcHAudjEuU3RvcmFnZVBvb2wiP4LT5JMCMhIw",
            "L3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovc3RvcmFnZVBvb2xz",
            "Lyp92kEEbmFtZRL4AQoRVXBkYXRlU3RvcmFnZVBvb2wSMC5nb29nbGUuY2xv",
            "dWQubmV0YXBwLnYxLlVwZGF0ZVN0b3JhZ2VQb29sUmVxdWVzdBodLmdvb2ds",
            "ZS5sb25ncnVubmluZy5PcGVyYXRpb24ikQGC0+STAk0yPS92MS97c3RvcmFn",
            "ZV9wb29sLm5hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9zdG9yYWdlUG9v",
            "bHMvKn06DHN0b3JhZ2VfcG9vbNpBGHN0b3JhZ2VfcG9vbCx1cGRhdGVfbWFz",
            "a8pBIAoLU3RvcmFnZVBvb2wSEU9wZXJhdGlvbk1ldGFkYXRhEtIBChFEZWxl",
            "dGVTdG9yYWdlUG9vbBIwLmdvb2dsZS5jbG91ZC5uZXRhcHAudjEuRGVsZXRl",
            "U3RvcmFnZVBvb2xSZXF1ZXN0Gh0uZ29vZ2xlLmxvbmdydW5uaW5nLk9wZXJh",
            "dGlvbiJsgtPkkwIyKjAvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMv",
            "Ki9zdG9yYWdlUG9vbHMvKn3aQQRuYW1lykEqChVnb29nbGUucHJvdG9idWYu",
            "RW1wdHkSEU9wZXJhdGlvbk1ldGFkYXRhEqQBCgtMaXN0Vm9sdW1lcxIqLmdv",
            "b2dsZS5jbG91ZC5uZXRhcHAudjEuTGlzdFZvbHVtZXNSZXF1ZXN0GisuZ29v",
            "Z2xlLmNsb3VkLm5ldGFwcC52MS5MaXN0Vm9sdW1lc1Jlc3BvbnNlIjyC0+ST",
            "Ai0SKy92MS97cGFyZW50PXByb2plY3RzLyovbG9jYXRpb25zLyp9L3ZvbHVt",
            "ZXPaQQZwYXJlbnQSkQEKCUdldFZvbHVtZRIoLmdvb2dsZS5jbG91ZC5uZXRh",
            "cHAudjEuR2V0Vm9sdW1lUmVxdWVzdBoeLmdvb2dsZS5jbG91ZC5uZXRhcHAu",
            "djEuVm9sdW1lIjqC0+STAi0SKy92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0",
            "aW9ucy8qL3ZvbHVtZXMvKn3aQQRuYW1lEs8BCgxDcmVhdGVWb2x1bWUSKy5n",
            "b29nbGUuY2xvdWQubmV0YXBwLnYxLkNyZWF0ZVZvbHVtZVJlcXVlc3QaHS5n",
            "b29nbGUubG9uZ3J1bm5pbmcuT3BlcmF0aW9uInOC0+STAjUiKy92MS97cGFy",
            "ZW50PXByb2plY3RzLyovbG9jYXRpb25zLyp9L3ZvbHVtZXM6BnZvbHVtZdpB",
            "F3BhcmVudCx2b2x1bWUsdm9sdW1lX2lkykEbCgZWb2x1bWUSEU9wZXJhdGlv",
            "bk1ldGFkYXRhEtEBCgxVcGRhdGVWb2x1bWUSKy5nb29nbGUuY2xvdWQubmV0",
            "YXBwLnYxLlVwZGF0ZVZvbHVtZVJlcXVlc3QaHS5nb29nbGUubG9uZ3J1bm5p",
            "bmcuT3BlcmF0aW9uInWC0+STAjwyMi92MS97dm9sdW1lLm5hbWU9cHJvamVj",
            "dHMvKi9sb2NhdGlvbnMvKi92b2x1bWVzLyp9OgZ2b2x1bWXaQRJ2b2x1bWUs",
            "dXBkYXRlX21hc2vKQRsKBlZvbHVtZRIRT3BlcmF0aW9uTWV0YWRhdGESwwEK",
            "DERlbGV0ZVZvbHVtZRIrLmdvb2dsZS5jbG91ZC5uZXRhcHAudjEuRGVsZXRl",
            "Vm9sdW1lUmVxdWVzdBodLmdvb2dsZS5sb25ncnVubmluZy5PcGVyYXRpb24i",
            "Z4LT5JMCLSorL3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovdm9s",
            "dW1lcy8qfdpBBG5hbWXKQSoKFWdvb2dsZS5wcm90b2J1Zi5FbXB0eRIRT3Bl",
            "cmF0aW9uTWV0YWRhdGEStwEKDFJldmVydFZvbHVtZRIrLmdvb2dsZS5jbG91",
            "ZC5uZXRhcHAudjEuUmV2ZXJ0Vm9sdW1lUmVxdWVzdBodLmdvb2dsZS5sb25n",
            "cnVubmluZy5PcGVyYXRpb24iW4LT5JMCNyIyL3YxL3tuYW1lPXByb2plY3Rz",
            "LyovbG9jYXRpb25zLyovdm9sdW1lcy8qfTpyZXZlcnQ6ASrKQRsKBlZvbHVt",
            "ZRIRT3BlcmF0aW9uTWV0YWRhdGEStgEKDUxpc3RTbmFwc2hvdHMSLC5nb29n",
            "bGUuY2xvdWQubmV0YXBwLnYxLkxpc3RTbmFwc2hvdHNSZXF1ZXN0Gi0uZ29v",
            "Z2xlLmNsb3VkLm5ldGFwcC52MS5MaXN0U25hcHNob3RzUmVzcG9uc2UiSILT",
            "5JMCORI3L3YxL3twYXJlbnQ9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi92b2x1",
            "bWVzLyp9L3NuYXBzaG90c9pBBnBhcmVudBKjAQoLR2V0U25hcHNob3QSKi5n",
            "b29nbGUuY2xvdWQubmV0YXBwLnYxLkdldFNuYXBzaG90UmVxdWVzdBogLmdv",
            "b2dsZS5jbG91ZC5uZXRhcHAudjEuU25hcHNob3QiRoLT5JMCORI3L3YxL3tu",
            "YW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovdm9sdW1lcy8qL3NuYXBzaG90",
            "cy8qfdpBBG5hbWUS6AEKDkNyZWF0ZVNuYXBzaG90Ei0uZ29vZ2xlLmNsb3Vk",
            "Lm5ldGFwcC52MS5DcmVhdGVTbmFwc2hvdFJlcXVlc3QaHS5nb29nbGUubG9u",
            "Z3J1bm5pbmcuT3BlcmF0aW9uIocBgtPkkwJDIjcvdjEve3BhcmVudD1wcm9q",
            "ZWN0cy8qL2xvY2F0aW9ucy8qL3ZvbHVtZXMvKn0vc25hcHNob3RzOghzbmFw",
            "c2hvdNpBG3BhcmVudCxzbmFwc2hvdCxzbmFwc2hvdF9pZMpBHQoIU25hcHNo",
            "b3QSEU9wZXJhdGlvbk1ldGFkYXRhEtMBCg5EZWxldGVTbmFwc2hvdBItLmdv",
            "b2dsZS5jbG91ZC5uZXRhcHAudjEuRGVsZXRlU25hcHNob3RSZXF1ZXN0Gh0u",
            "Z29vZ2xlLmxvbmdydW5uaW5nLk9wZXJhdGlvbiJzgtPkkwI5KjcvdjEve25h",
            "bWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi92b2x1bWVzLyovc25hcHNob3Rz",
            "Lyp92kEEbmFtZcpBKgoVZ29vZ2xlLnByb3RvYnVmLkVtcHR5EhFPcGVyYXRp",
            "b25NZXRhZGF0YRLqAQoOVXBkYXRlU25hcHNob3QSLS5nb29nbGUuY2xvdWQu",
            "bmV0YXBwLnYxLlVwZGF0ZVNuYXBzaG90UmVxdWVzdBodLmdvb2dsZS5sb25n",
            "cnVubmluZy5PcGVyYXRpb24iiQGC0+STAkwyQC92MS97c25hcHNob3QubmFt",
            "ZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3ZvbHVtZXMvKi9zbmFwc2hvdHMv",
            "Kn06CHNuYXBzaG902kEUc25hcHNob3QsdXBkYXRlX21hc2vKQR0KCFNuYXBz",
            "aG90EhFPcGVyYXRpb25NZXRhZGF0YRLMAQoVTGlzdEFjdGl2ZURpcmVjdG9y",
            "aWVzEjQuZ29vZ2xlLmNsb3VkLm5ldGFwcC52MS5MaXN0QWN0aXZlRGlyZWN0",
            "b3JpZXNSZXF1ZXN0GjUuZ29vZ2xlLmNsb3VkLm5ldGFwcC52MS5MaXN0QWN0",
            "aXZlRGlyZWN0b3JpZXNSZXNwb25zZSJGgtPkkwI3EjUvdjEve3BhcmVudD1w",
            "cm9qZWN0cy8qL2xvY2F0aW9ucy8qfS9hY3RpdmVEaXJlY3Rvcmllc9pBBnBh",
            "cmVudBK2AQoSR2V0QWN0aXZlRGlyZWN0b3J5EjEuZ29vZ2xlLmNsb3VkLm5l",
            "dGFwcC52MS5HZXRBY3RpdmVEaXJlY3RvcnlSZXF1ZXN0GicuZ29vZ2xlLmNs",
            "b3VkLm5ldGFwcC52MS5BY3RpdmVEaXJlY3RvcnkiRILT5JMCNxI1L3YxL3tu",
            "YW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovYWN0aXZlRGlyZWN0b3JpZXMv",
            "Kn3aQQRuYW1lEpMCChVDcmVhdGVBY3RpdmVEaXJlY3RvcnkSNC5nb29nbGUu",
            "Y2xvdWQubmV0YXBwLnYxLkNyZWF0ZUFjdGl2ZURpcmVjdG9yeVJlcXVlc3Qa",
            "HS5nb29nbGUubG9uZ3J1bm5pbmcuT3BlcmF0aW9uIqQBgtPkkwJJIjUvdjEv",
            "e3BhcmVudD1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qfS9hY3RpdmVEaXJlY3Rv",
            "cmllczoQYWN0aXZlX2RpcmVjdG9yedpBK3BhcmVudCxhY3RpdmVfZGlyZWN0",
            "b3J5LGFjdGl2ZV9kaXJlY3RvcnlfaWTKQSQKD0FjdGl2ZURpcmVjdG9yeRIR",
            "T3BlcmF0aW9uTWV0YWRhdGESlQIKFVVwZGF0ZUFjdGl2ZURpcmVjdG9yeRI0",
            "Lmdvb2dsZS5jbG91ZC5uZXRhcHAudjEuVXBkYXRlQWN0aXZlRGlyZWN0b3J5",
            "UmVxdWVzdBodLmdvb2dsZS5sb25ncnVubmluZy5PcGVyYXRpb24ipgGC0+ST",
            "AloyRi92MS97YWN0aXZlX2RpcmVjdG9yeS5uYW1lPXByb2plY3RzLyovbG9j",
            "YXRpb25zLyovYWN0aXZlRGlyZWN0b3JpZXMvKn06EGFjdGl2ZV9kaXJlY3Rv",
            "cnnaQRxhY3RpdmVfZGlyZWN0b3J5LHVwZGF0ZV9tYXNrykEkCg9BY3RpdmVE",
            "aXJlY3RvcnkSEU9wZXJhdGlvbk1ldGFkYXRhEt8BChVEZWxldGVBY3RpdmVE",
            "aXJlY3RvcnkSNC5nb29nbGUuY2xvdWQubmV0YXBwLnYxLkRlbGV0ZUFjdGl2",
            "ZURpcmVjdG9yeVJlcXVlc3QaHS5nb29nbGUubG9uZ3J1bm5pbmcuT3BlcmF0",
            "aW9uInGC0+STAjcqNS92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8q",
            "L2FjdGl2ZURpcmVjdG9yaWVzLyp92kEEbmFtZcpBKgoVZ29vZ2xlLnByb3Rv",
            "YnVmLkVtcHR5EhFPcGVyYXRpb25NZXRhZGF0YRKwAQoOTGlzdEttc0NvbmZp",
            "Z3MSLS5nb29nbGUuY2xvdWQubmV0YXBwLnYxLkxpc3RLbXNDb25maWdzUmVx",
            "dWVzdBouLmdvb2dsZS5jbG91ZC5uZXRhcHAudjEuTGlzdEttc0NvbmZpZ3NS",
            "ZXNwb25zZSI/gtPkkwIwEi4vdjEve3BhcmVudD1wcm9qZWN0cy8qL2xvY2F0",
            "aW9ucy8qfS9rbXNDb25maWdz2kEGcGFyZW50EugBCg9DcmVhdGVLbXNDb25m",
            "aWcSLi5nb29nbGUuY2xvdWQubmV0YXBwLnYxLkNyZWF0ZUttc0NvbmZpZ1Jl",
            "cXVlc3QaHS5nb29nbGUubG9uZ3J1bm5pbmcuT3BlcmF0aW9uIoUBgtPkkwI8",
            "Ii4vdjEve3BhcmVudD1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qfS9rbXNDb25m",
            "aWdzOgprbXNfY29uZmln2kEfcGFyZW50LGttc19jb25maWcsa21zX2NvbmZp",
            "Z19pZMpBHgoJS21zQ29uZmlnEhFPcGVyYXRpb25NZXRhZGF0YRKdAQoMR2V0",
            "S21zQ29uZmlnEisuZ29vZ2xlLmNsb3VkLm5ldGFwcC52MS5HZXRLbXNDb25m",
            "aWdSZXF1ZXN0GiEuZ29vZ2xlLmNsb3VkLm5ldGFwcC52MS5LbXNDb25maWci",
            "PYLT5JMCMBIuL3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyova21z",
            "Q29uZmlncy8qfdpBBG5hbWUS6gEKD1VwZGF0ZUttc0NvbmZpZxIuLmdvb2ds",
            "ZS5jbG91ZC5uZXRhcHAudjEuVXBkYXRlS21zQ29uZmlnUmVxdWVzdBodLmdv",
            "b2dsZS5sb25ncnVubmluZy5PcGVyYXRpb24ihwGC0+STAkcyOS92MS97a21z",
            "X2NvbmZpZy5uYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyova21zQ29uZmln",
            "cy8qfToKa21zX2NvbmZpZ9pBFmttc19jb25maWcsdXBkYXRlX21hc2vKQR4K",
            "CUttc0NvbmZpZxIRT3BlcmF0aW9uTWV0YWRhdGESwgEKDkVuY3J5cHRWb2x1",
            "bWVzEi0uZ29vZ2xlLmNsb3VkLm5ldGFwcC52MS5FbmNyeXB0Vm9sdW1lc1Jl",
            "cXVlc3QaHS5nb29nbGUubG9uZ3J1bm5pbmcuT3BlcmF0aW9uImKC0+STAjsi",
            "Ni92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2ttc0NvbmZpZ3Mv",
            "Kn06ZW5jcnlwdDoBKspBHgoJS21zQ29uZmlnEhFPcGVyYXRpb25NZXRhZGF0",
            "YRK0AQoPVmVyaWZ5S21zQ29uZmlnEi4uZ29vZ2xlLmNsb3VkLm5ldGFwcC52",
            "MS5WZXJpZnlLbXNDb25maWdSZXF1ZXN0Gi8uZ29vZ2xlLmNsb3VkLm5ldGFw",
            "cC52MS5WZXJpZnlLbXNDb25maWdSZXNwb25zZSJAgtPkkwI6IjUvdjEve25h",
            "bWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9rbXNDb25maWdzLyp9OnZlcmlm",
            "eToBKhLMAQoPRGVsZXRlS21zQ29uZmlnEi4uZ29vZ2xlLmNsb3VkLm5ldGFw",
            "cC52MS5EZWxldGVLbXNDb25maWdSZXF1ZXN0Gh0uZ29vZ2xlLmxvbmdydW5u",
            "aW5nLk9wZXJhdGlvbiJqgtPkkwIwKi4vdjEve25hbWU9cHJvamVjdHMvKi9s",
            "b2NhdGlvbnMvKi9rbXNDb25maWdzLyp92kEEbmFtZcpBKgoVZ29vZ2xlLnBy",
            "b3RvYnVmLkVtcHR5EhFPcGVyYXRpb25NZXRhZGF0YRLCAQoQTGlzdFJlcGxp",
            "Y2F0aW9ucxIvLmdvb2dsZS5jbG91ZC5uZXRhcHAudjEuTGlzdFJlcGxpY2F0",
            "aW9uc1JlcXVlc3QaMC5nb29nbGUuY2xvdWQubmV0YXBwLnYxLkxpc3RSZXBs",
            "aWNhdGlvbnNSZXNwb25zZSJLgtPkkwI8EjovdjEve3BhcmVudD1wcm9qZWN0",
            "cy8qL2xvY2F0aW9ucy8qL3ZvbHVtZXMvKn0vcmVwbGljYXRpb25z2kEGcGFy",
            "ZW50Eq8BCg5HZXRSZXBsaWNhdGlvbhItLmdvb2dsZS5jbG91ZC5uZXRhcHAu",
            "djEuR2V0UmVwbGljYXRpb25SZXF1ZXN0GiMuZ29vZ2xlLmNsb3VkLm5ldGFw",
            "cC52MS5SZXBsaWNhdGlvbiJJgtPkkwI8EjovdjEve25hbWU9cHJvamVjdHMv",
            "Ki9sb2NhdGlvbnMvKi92b2x1bWVzLyovcmVwbGljYXRpb25zLyp92kEEbmFt",
            "ZRL9AQoRQ3JlYXRlUmVwbGljYXRpb24SMC5nb29nbGUuY2xvdWQubmV0YXBw",
            "LnYxLkNyZWF0ZVJlcGxpY2F0aW9uUmVxdWVzdBodLmdvb2dsZS5sb25ncnVu",
            "bmluZy5PcGVyYXRpb24ilgGC0+STAkkiOi92MS97cGFyZW50PXByb2plY3Rz",
            "LyovbG9jYXRpb25zLyovdm9sdW1lcy8qfS9yZXBsaWNhdGlvbnM6C3JlcGxp",
            "Y2F0aW9u2kEhcGFyZW50LHJlcGxpY2F0aW9uLHJlcGxpY2F0aW9uX2lkykEg",
            "CgtSZXBsaWNhdGlvbhIRT3BlcmF0aW9uTWV0YWRhdGES3AEKEURlbGV0ZVJl",
            "cGxpY2F0aW9uEjAuZ29vZ2xlLmNsb3VkLm5ldGFwcC52MS5EZWxldGVSZXBs",
            "aWNhdGlvblJlcXVlc3QaHS5nb29nbGUubG9uZ3J1bm5pbmcuT3BlcmF0aW9u",
            "InaC0+STAjwqOi92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3Zv",
            "bHVtZXMvKi9yZXBsaWNhdGlvbnMvKn3aQQRuYW1lykEqChVnb29nbGUucHJv",
            "dG9idWYuRW1wdHkSEU9wZXJhdGlvbk1ldGFkYXRhEv8BChFVcGRhdGVSZXBs",
            "aWNhdGlvbhIwLmdvb2dsZS5jbG91ZC5uZXRhcHAudjEuVXBkYXRlUmVwbGlj",
            "YXRpb25SZXF1ZXN0Gh0uZ29vZ2xlLmxvbmdydW5uaW5nLk9wZXJhdGlvbiKY",
            "AYLT5JMCVTJGL3YxL3tyZXBsaWNhdGlvbi5uYW1lPXByb2plY3RzLyovbG9j",
            "YXRpb25zLyovdm9sdW1lcy8qL3JlcGxpY2F0aW9ucy8qfToLcmVwbGljYXRp",
            "b27aQRdyZXBsaWNhdGlvbix1cGRhdGVfbWFza8pBIAoLUmVwbGljYXRpb24S",
            "EU9wZXJhdGlvbk1ldGFkYXRhEs8BCg9TdG9wUmVwbGljYXRpb24SLi5nb29n",
            "bGUuY2xvdWQubmV0YXBwLnYxLlN0b3BSZXBsaWNhdGlvblJlcXVlc3QaHS5n",
            "b29nbGUubG9uZ3J1bm5pbmcuT3BlcmF0aW9uIm2C0+STAkQiPy92MS97bmFt",
            "ZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3ZvbHVtZXMvKi9yZXBsaWNhdGlv",
            "bnMvKn06c3RvcDoBKspBIAoLUmVwbGljYXRpb24SEU9wZXJhdGlvbk1ldGFk",
            "YXRhEtUBChFSZXN1bWVSZXBsaWNhdGlvbhIwLmdvb2dsZS5jbG91ZC5uZXRh",
            "cHAudjEuUmVzdW1lUmVwbGljYXRpb25SZXF1ZXN0Gh0uZ29vZ2xlLmxvbmdy",
            "dW5uaW5nLk9wZXJhdGlvbiJvgtPkkwJGIkEvdjEve25hbWU9cHJvamVjdHMv",
            "Ki9sb2NhdGlvbnMvKi92b2x1bWVzLyovcmVwbGljYXRpb25zLyp9OnJlc3Vt",
            "ZToBKspBIAoLUmVwbGljYXRpb24SEU9wZXJhdGlvbk1ldGFkYXRhEvMBChtS",
            "ZXZlcnNlUmVwbGljYXRpb25EaXJlY3Rpb24SOi5nb29nbGUuY2xvdWQubmV0",
            "YXBwLnYxLlJldmVyc2VSZXBsaWNhdGlvbkRpcmVjdGlvblJlcXVlc3QaHS5n",
            "b29nbGUubG9uZ3J1bm5pbmcuT3BlcmF0aW9uInmC0+STAlAiSy92MS97bmFt",
            "ZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3ZvbHVtZXMvKi9yZXBsaWNhdGlv",
            "bnMvKn06cmV2ZXJzZURpcmVjdGlvbjoBKspBIAoLUmVwbGljYXRpb24SEU9w",
            "ZXJhdGlvbk1ldGFkYXRhGknKQRVuZXRhcHAuZ29vZ2xlYXBpcy5jb23SQS5o",
            "dHRwczovL3d3dy5nb29nbGVhcGlzLmNvbS9hdXRoL2Nsb3VkLXBsYXRmb3Jt",
            "QooCChpjb20uZ29vZ2xlLmNsb3VkLm5ldGFwcC52MUIXQ2xvdWROZXRhcHBT",
            "ZXJ2aWNlUHJvdG9QAVoyY2xvdWQuZ29vZ2xlLmNvbS9nby9uZXRhcHAvYXBp",
            "djEvbmV0YXBwcGI7bmV0YXBwcGKqAhZHb29nbGUuQ2xvdWQuTmV0QXBwLlYx",
            "ygIWR29vZ2xlXENsb3VkXE5ldEFwcFxWMeoCGUdvb2dsZTo6Q2xvdWQ6Ok5l",
            "dEFwcDo6VjHqQU4KHmNvbXB1dGUuZ29vZ2xlYXBpcy5jb20vTmV0d29yaxIs",
            "cHJvamVjdHMve3Byb2plY3R9L2dsb2JhbC9uZXR3b3Jrcy97bmV0d29ya31i",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.NetApp.V1.ActiveDirectoryReflection.Descriptor, global::Google.Cloud.NetApp.V1.KmsReflection.Descriptor, global::Google.Cloud.NetApp.V1.ReplicationReflection.Descriptor, global::Google.Cloud.NetApp.V1.SnapshotReflection.Descriptor, global::Google.Cloud.NetApp.V1.StoragePoolReflection.Descriptor, global::Google.Cloud.NetApp.V1.VolumeReflection.Descriptor, global::Google.LongRunning.OperationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.NetApp.V1.OperationMetadata), global::Google.Cloud.NetApp.V1.OperationMetadata.Parser, new[]{ "CreateTime", "EndTime", "Target", "Verb", "StatusMessage", "RequestedCancellation", "ApiVersion" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents the metadata of the long-running operation.
  /// </summary>
  public sealed partial class OperationMetadata : pb::IMessage<OperationMetadata>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OperationMetadata> _parser = new pb::MessageParser<OperationMetadata>(() => new OperationMetadata());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OperationMetadata> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.NetApp.V1.CloudNetappServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OperationMetadata() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OperationMetadata(OperationMetadata other) : this() {
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      endTime_ = other.endTime_ != null ? other.endTime_.Clone() : null;
      target_ = other.target_;
      verb_ = other.verb_;
      statusMessage_ = other.statusMessage_;
      requestedCancellation_ = other.requestedCancellation_;
      apiVersion_ = other.apiVersion_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OperationMetadata Clone() {
      return new OperationMetadata(this);
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. The time the operation was created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "end_time" field.</summary>
    public const int EndTimeFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp endTime_;
    /// <summary>
    /// Output only. The time the operation finished running.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp EndTime {
      get { return endTime_; }
      set {
        endTime_ = value;
      }
    }

    /// <summary>Field number for the "target" field.</summary>
    public const int TargetFieldNumber = 3;
    private string target_ = "";
    /// <summary>
    /// Output only. Server-defined resource path for the target of the operation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Target {
      get { return target_; }
      set {
        target_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "verb" field.</summary>
    public const int VerbFieldNumber = 4;
    private string verb_ = "";
    /// <summary>
    /// Output only. Name of the verb executed by the operation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Verb {
      get { return verb_; }
      set {
        verb_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status_message" field.</summary>
    public const int StatusMessageFieldNumber = 5;
    private string statusMessage_ = "";
    /// <summary>
    /// Output only. Human-readable status of the operation, if any.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StatusMessage {
      get { return statusMessage_; }
      set {
        statusMessage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "requested_cancellation" field.</summary>
    public const int RequestedCancellationFieldNumber = 6;
    private bool requestedCancellation_;
    /// <summary>
    /// Output only. Identifies whether the user has requested cancellation
    /// of the operation. Operations that have been canceled successfully
    /// have [Operation.error][] value with a
    /// [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
    /// `Code.CANCELLED`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool RequestedCancellation {
      get { return requestedCancellation_; }
      set {
        requestedCancellation_ = value;
      }
    }

    /// <summary>Field number for the "api_version" field.</summary>
    public const int ApiVersionFieldNumber = 7;
    private string apiVersion_ = "";
    /// <summary>
    /// Output only. API version used to start the operation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ApiVersion {
      get { return apiVersion_; }
      set {
        apiVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OperationMetadata);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OperationMetadata other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(EndTime, other.EndTime)) return false;
      if (Target != other.Target) return false;
      if (Verb != other.Verb) return false;
      if (StatusMessage != other.StatusMessage) return false;
      if (RequestedCancellation != other.RequestedCancellation) return false;
      if (ApiVersion != other.ApiVersion) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (endTime_ != null) hash ^= EndTime.GetHashCode();
      if (Target.Length != 0) hash ^= Target.GetHashCode();
      if (Verb.Length != 0) hash ^= Verb.GetHashCode();
      if (StatusMessage.Length != 0) hash ^= StatusMessage.GetHashCode();
      if (RequestedCancellation != false) hash ^= RequestedCancellation.GetHashCode();
      if (ApiVersion.Length != 0) hash ^= ApiVersion.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (createTime_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CreateTime);
      }
      if (endTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(EndTime);
      }
      if (Target.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Target);
      }
      if (Verb.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Verb);
      }
      if (StatusMessage.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(StatusMessage);
      }
      if (RequestedCancellation != false) {
        output.WriteRawTag(48);
        output.WriteBool(RequestedCancellation);
      }
      if (ApiVersion.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(ApiVersion);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (createTime_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CreateTime);
      }
      if (endTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(EndTime);
      }
      if (Target.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Target);
      }
      if (Verb.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Verb);
      }
      if (StatusMessage.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(StatusMessage);
      }
      if (RequestedCancellation != false) {
        output.WriteRawTag(48);
        output.WriteBool(RequestedCancellation);
      }
      if (ApiVersion.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(ApiVersion);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (endTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EndTime);
      }
      if (Target.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Target);
      }
      if (Verb.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Verb);
      }
      if (StatusMessage.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StatusMessage);
      }
      if (RequestedCancellation != false) {
        size += 1 + 1;
      }
      if (ApiVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ApiVersion);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OperationMetadata other) {
      if (other == null) {
        return;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.endTime_ != null) {
        if (endTime_ == null) {
          EndTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        EndTime.MergeFrom(other.EndTime);
      }
      if (other.Target.Length != 0) {
        Target = other.Target;
      }
      if (other.Verb.Length != 0) {
        Verb = other.Verb;
      }
      if (other.StatusMessage.Length != 0) {
        StatusMessage = other.StatusMessage;
      }
      if (other.RequestedCancellation != false) {
        RequestedCancellation = other.RequestedCancellation;
      }
      if (other.ApiVersion.Length != 0) {
        ApiVersion = other.ApiVersion;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 18: {
            if (endTime_ == null) {
              EndTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EndTime);
            break;
          }
          case 26: {
            Target = input.ReadString();
            break;
          }
          case 34: {
            Verb = input.ReadString();
            break;
          }
          case 42: {
            StatusMessage = input.ReadString();
            break;
          }
          case 48: {
            RequestedCancellation = input.ReadBool();
            break;
          }
          case 58: {
            ApiVersion = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 18: {
            if (endTime_ == null) {
              EndTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EndTime);
            break;
          }
          case 26: {
            Target = input.ReadString();
            break;
          }
          case 34: {
            Verb = input.ReadString();
            break;
          }
          case 42: {
            StatusMessage = input.ReadString();
            break;
          }
          case 48: {
            RequestedCancellation = input.ReadBool();
            break;
          }
          case 58: {
            ApiVersion = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code

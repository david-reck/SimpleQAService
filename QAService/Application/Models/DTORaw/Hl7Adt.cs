using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace QAService.Application.Models.DTORaw
{
    public partial class Hl7Adt
    {
        [JsonProperty("HL7Message")]
        public Hl7Message Hl7Message { get; set; }
    }

    public partial class Hl7Message
    {
        [JsonProperty("MSH")]
        public Msh Msh { get; set; }

        [JsonProperty("EVN")]
        public Evn Evn { get; set; }

        [JsonProperty("PID")]
        public Pid Pid { get; set; }

        [JsonProperty("ZPD")]
        public Zpd Zpd { get; set; }

        [JsonProperty("PD1")]
        public Pd1 Pd1 { get; set; }

        [JsonProperty("NK1")]
        public Nk1[] Nk1 { get; set; }

        [JsonProperty("PV1")]
        public Pv1 Pv1 { get; set; }

        [JsonProperty("PV2")]
        public Pv2 Pv2 { get; set; }

        [JsonProperty("ZPV")]
        public Dictionary<string, Zpv> Zpv { get; set; }

        [JsonProperty("DG1")]
        public Dg1 Dg1 { get; set; }

        [JsonProperty("GT1")]
        public Gt1 Gt1 { get; set; }
    }

    public partial class Dg1
    {
        [JsonProperty("DG1.1")]
        public Dg11 Dg11 { get; set; }

        [JsonProperty("DG1.2")]
        public Dg12 Dg12 { get; set; }

        [JsonProperty("DG1.3")]
        public Dg13 Dg13 { get; set; }

        [JsonProperty("DG1.4")]
        public Dg14 Dg14 { get; set; }

        [JsonProperty("DG1.5")]
        public object Dg15 { get; set; }

        [JsonProperty("DG1.6")]
        public Dg16 Dg16 { get; set; }
    }

    public partial class Dg11
    {
        [JsonProperty("DG1.1.1")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Dg111 { get; set; }
    }

    public partial class Dg12
    {
        [JsonProperty("DG1.2.1")]
        public string Dg121 { get; set; }
    }

    public partial class Dg13
    {
        [JsonProperty("DG1.3.1")]
        public string Dg131 { get; set; }

        [JsonProperty("DG1.3.2")]
        public string Dg132 { get; set; }

        [JsonProperty("DG1.3.3")]
        public string Dg133 { get; set; }
    }

    public partial class Dg14
    {
        [JsonProperty("DG1.4.1")]
        public string Dg141 { get; set; }
    }

    public partial class Dg16
    {
        [JsonProperty("DG1.6.1")]
        public string Dg161 { get; set; }
    }

    public partial class Evn
    {
        [JsonProperty("EVN.1")]
        public Evn1 Evn1 { get; set; }

        [JsonProperty("EVN.2")]
        public Evn2 Evn2 { get; set; }

        [JsonProperty("EVN.3")]
        public object Evn3 { get; set; }

        [JsonProperty("EVN.4")]
        public Evn4 Evn4 { get; set; }

        [JsonProperty("EVN.5")]
        public Evn5 Evn5 { get; set; }

        [JsonProperty("EVN.6")]
        public Evn6 Evn6 { get; set; }
    }

    public partial class Evn1
    {
        [JsonProperty("EVN.1.1")]
        public string Evn11 { get; set; }
    }

    public partial class Evn2
    {
        [JsonProperty("EVN.2.1")]
        public string Evn21 { get; set; }
    }

    public partial class Evn4
    {
        [JsonProperty("EVN.4.1")]
        public string Evn41 { get; set; }
    }

    public partial class Evn5
    {
        [JsonProperty("EVN.5.1")]
        public string Evn51 { get; set; }

        [JsonProperty("EVN.5.2")]
        public string Evn52 { get; set; }

        [JsonProperty("EVN.5.3")]
        public string Evn53 { get; set; }

        [JsonProperty("EVN.5.4")]
        public string Evn54 { get; set; }

        [JsonProperty("EVN.5.5")]
        public object Evn55 { get; set; }

        [JsonProperty("EVN.5.6")]
        public object Evn56 { get; set; }

        [JsonProperty("EVN.5.7")]
        public object Evn57 { get; set; }

        [JsonProperty("EVN.5.8")]
        public object Evn58 { get; set; }

        [JsonProperty("EVN.5.9")]
        public string Evn59 { get; set; }

        [JsonProperty("EVN.5.10")]
        public object Evn510 { get; set; }

        [JsonProperty("EVN.5.11")]
        public object Evn511 { get; set; }

        [JsonProperty("EVN.5.12")]
        public object Evn512 { get; set; }

        [JsonProperty("EVN.5.13")]
        public object Evn513 { get; set; }

        [JsonProperty("EVN.5.14")]
        public string Evn514 { get; set; }
    }

    public partial class Evn6
    {
        [JsonProperty("EVN.6.1")]
        public string Evn61 { get; set; }
    }

    public partial class Gt1
    {
        [JsonProperty("GT1.1")]
        public Gt11 Gt11 { get; set; }

        [JsonProperty("GT1.2")]
        public Gt12 Gt12 { get; set; }

        [JsonProperty("GT1.3")]
        public Gt13 Gt13 { get; set; }

        [JsonProperty("GT1.4")]
        public object Gt14 { get; set; }

        [JsonProperty("GT1.5")]
        public Gt15 Gt15 { get; set; }

        [JsonProperty("GT1.6")]
        public Gt16 Gt16 { get; set; }

        [JsonProperty("GT1.7")]
        public object Gt17 { get; set; }

        [JsonProperty("GT1.8")]
        public Gt18 Gt18 { get; set; }

        [JsonProperty("GT1.9")]
        public Gt19 Gt19 { get; set; }

        [JsonProperty("GT1.10")]
        public Gt110 Gt110 { get; set; }

        [JsonProperty("GT1.11")]
        public Gt111 Gt111 { get; set; }

        [JsonProperty("GT1.12")]
        public object Gt112 { get; set; }

        [JsonProperty("GT1.13")]
        public object Gt113 { get; set; }

        [JsonProperty("GT1.14")]
        public object Gt114 { get; set; }

        [JsonProperty("GT1.15")]
        public object Gt115 { get; set; }

        [JsonProperty("GT1.16")]
        public Gt116 Gt116 { get; set; }

        [JsonProperty("GT1.17")]
        public Gt117 Gt117 { get; set; }

        [JsonProperty("GT1.18")]
        public object Gt118 { get; set; }

        [JsonProperty("GT1.19")]
        public object Gt119 { get; set; }

        [JsonProperty("GT1.20")]
        public Gt120 Gt120 { get; set; }
    }

    public partial class Gt11
    {
        [JsonProperty("GT1.1.1")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Gt111 { get; set; }
    }

    public partial class Gt110
    {
        [JsonProperty("GT1.10.1")]
        public string Gt1101 { get; set; }
    }

    public partial class Gt111
    {
        [JsonProperty("GT1.11.1")]
        public string Gt1111 { get; set; }
    }

    public partial class Gt116
    {
        [JsonProperty("GT1.16.1")]
        public string Gt1161 { get; set; }
    }

    public partial class Gt117
    {
        [JsonProperty("GT1.17.1")]
        public string Gt1171 { get; set; }

        [JsonProperty("GT1.17.2")]
        public object Gt1172 { get; set; }

        [JsonProperty("GT1.17.3")]
        public string Gt1173 { get; set; }

        [JsonProperty("GT1.17.4")]
        public string Gt1174 { get; set; }

        [JsonProperty("GT1.17.5")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Gt1175 { get; set; }

        [JsonProperty("GT1.17.6")]
        public string Gt1176 { get; set; }
    }

    public partial class Gt12
    {
        [JsonProperty("GT1.2.1")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Gt121 { get; set; }
    }

    public partial class Gt120
    {
        [JsonProperty("GT1.20.1")]
        public string Gt1201 { get; set; }
    }

    public partial class Gt13
    {
        [JsonProperty("GT1.3.1")]
        public string Gt131 { get; set; }

        [JsonProperty("GT1.3.2")]
        public string Gt132 { get; set; }
    }

    public partial class Gt15
    {
        [JsonProperty("GT1.5.1")]
        public string Gt151 { get; set; }

        [JsonProperty("GT1.5.2")]
        public object Gt152 { get; set; }

        [JsonProperty("GT1.5.3")]
        public string Gt153 { get; set; }

        [JsonProperty("GT1.5.4")]
        public string Gt154 { get; set; }

        [JsonProperty("GT1.5.5")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Gt155 { get; set; }

        [JsonProperty("GT1.5.6")]
        public string Gt156 { get; set; }

        [JsonProperty("GT1.5.7")]
        public object Gt157 { get; set; }

        [JsonProperty("GT1.5.8")]
        public object Gt158 { get; set; }

        [JsonProperty("GT1.5.9")]
        public string Gt159 { get; set; }
    }

    public partial class Gt16
    {
        [JsonProperty("GT1.6.1")]
        public string Gt161 { get; set; }

        [JsonProperty("GT1.6.2")]
        public object Gt162 { get; set; }

        [JsonProperty("GT1.6.3")]
        public object Gt163 { get; set; }

        [JsonProperty("GT1.6.4")]
        public object Gt164 { get; set; }

        [JsonProperty("GT1.6.5")]
        public object Gt165 { get; set; }

        [JsonProperty("GT1.6.6")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Gt166 { get; set; }

        [JsonProperty("GT1.6.7")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Gt167 { get; set; }
    }

    public partial class Gt18
    {
        [JsonProperty("GT1.8.1")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Gt181 { get; set; }
    }

    public partial class Gt19
    {
        [JsonProperty("GT1.9.1")]
        public string Gt191 { get; set; }
    }

    public partial class Msh
    {
        [JsonProperty("MSH.1")]
        public string Msh1 { get; set; }

        [JsonProperty("MSH.2")]
        public string Msh2 { get; set; }

        [JsonProperty("MSH.3")]
        public Msh3 Msh3 { get; set; }

        [JsonProperty("MSH.4")]
        public Msh4 Msh4 { get; set; }

        [JsonProperty("MSH.5")]
        public Msh5 Msh5 { get; set; }

        [JsonProperty("MSH.6")]
        public Msh6 Msh6 { get; set; }

        [JsonProperty("MSH.7")]
        public Msh7 Msh7 { get; set; }

        [JsonProperty("MSH.8")]
        public Msh8 Msh8 { get; set; }

        [JsonProperty("MSH.9")]
        public Msh9 Msh9 { get; set; }

        [JsonProperty("MSH.10")]
        public Msh10 Msh10 { get; set; }

        [JsonProperty("MSH.11")]
        public Msh11 Msh11 { get; set; }

        [JsonProperty("MSH.12")]
        public Msh12 Msh12 { get; set; }
    }

    public partial class Msh10
    {
        [JsonProperty("MSH.10.1")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Msh101 { get; set; }
    }

    public partial class Msh11
    {
        [JsonProperty("MSH.11.1")]
        public string Msh111 { get; set; }
    }

    public partial class Msh12
    {
        [JsonProperty("MSH.12.1")]
        public string Msh121 { get; set; }
    }

    public partial class Msh3
    {
        [JsonProperty("MSH.3.1")]
        public string Msh31 { get; set; }
    }

    public partial class Msh4
    {
        [JsonProperty("MSH.4.1")]
        public string Msh41 { get; set; }
    }

    public partial class Msh5
    {
        [JsonProperty("MSH.5.1")]
        public string Msh51 { get; set; }
    }

    public partial class Msh6
    {
        [JsonProperty("MSH.6.1")]
        public string Msh61 { get; set; }
    }

    public partial class Msh7
    {
        [JsonProperty("MSH.7.1")]
        public string Msh71 { get; set; }
    }

    public partial class Msh8
    {
        [JsonProperty("MSH.8.1")]
        public string Msh81 { get; set; }
    }

    public partial class Msh9
    {
        [JsonProperty("MSH.9.1")]
        public string Msh91 { get; set; }

        [JsonProperty("MSH.9.2")]
        public string Msh92 { get; set; }
    }

    public partial class Nk1
    {
        [JsonProperty("NK1.1")]
        public Nk11 Nk11 { get; set; }

        [JsonProperty("NK1.2")]
        public Nk12 Nk12 { get; set; }

        [JsonProperty("NK1.3")]
        public Nk13 Nk13 { get; set; }

        [JsonProperty("NK1.4")]
        public Nk14 Nk14 { get; set; }

        [JsonProperty("NK1.5")]
        public Nk15 Nk15 { get; set; }

        [JsonProperty("NK1.6")]
        public object Nk16 { get; set; }

        [JsonProperty("NK1.7")]
        public Nk17 Nk17 { get; set; }
    }

    public partial class Nk11
    {
        [JsonProperty("NK1.1.1")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Nk111 { get; set; }
    }

    public partial class Nk12
    {
        [JsonProperty("NK1.2.1")]
        public string Nk121 { get; set; }

        [JsonProperty("NK1.2.2")]
        public string Nk122 { get; set; }
    }

    public partial class Nk13
    {
        [JsonProperty("NK1.3.1")]
        public string Nk131 { get; set; }
    }

    public partial class Nk14
    {
        [JsonProperty("NK1.4.1")]
        public string Nk141 { get; set; }

        [JsonProperty("NK1.4.2")]
        public object Nk142 { get; set; }

        [JsonProperty("NK1.4.3")]
        public string Nk143 { get; set; }

        [JsonProperty("NK1.4.4")]
        public string Nk144 { get; set; }

        [JsonProperty("NK1.4.5")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Nk145 { get; set; }

        [JsonProperty("NK1.4.6")]
        public string Nk146 { get; set; }
    }

    public partial class Nk15
    {
        [JsonProperty("NK1.5.1")]
        public string Nk151 { get; set; }

        [JsonProperty("NK1.5.2")]
        public object Nk152 { get; set; }

        [JsonProperty("NK1.5.3")]
        public string Nk153 { get; set; }

        [JsonProperty("NK1.5.4")]
        public object Nk154 { get; set; }

        [JsonProperty("NK1.5.5")]
        public object Nk155 { get; set; }

        [JsonProperty("NK1.5.6")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Nk156 { get; set; }

        [JsonProperty("NK1.5.7")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Nk157 { get; set; }
    }

    public partial class Nk17
    {
        [JsonProperty("NK1.7.1")]
        public string Nk171 { get; set; }
    }

    public partial class Pd1
    {
        [JsonProperty("PD1.1")]
        public object Pd11 { get; set; }

        [JsonProperty("PD1.2")]
        public object Pd12 { get; set; }

        [JsonProperty("PD1.3")]
        public Pd13 Pd13 { get; set; }

        [JsonProperty("PD1.4")]
        public Pd14 Pd14 { get; set; }
    }

    public partial class Pd13
    {
        [JsonProperty("PD1.3.1")]
        public string Pd131 { get; set; }

        [JsonProperty("PD1.3.2")]
        public object Pd132 { get; set; }

        [JsonProperty("PD1.3.3")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Pd133 { get; set; }
    }

    public partial class Pd14
    {
        [JsonProperty("PD1.4.1")]
        public string Pd141 { get; set; }

        [JsonProperty("PD1.4.2")]
        public string Pd142 { get; set; }

        [JsonProperty("PD1.4.3")]
        public string Pd143 { get; set; }

        [JsonProperty("PD1.4.4")]
        public string Pd144 { get; set; }

        [JsonProperty("PD1.4.5")]
        public object Pd145 { get; set; }

        [JsonProperty("PD1.4.6")]
        public object Pd146 { get; set; }

        [JsonProperty("PD1.4.7")]
        public object Pd147 { get; set; }

        [JsonProperty("PD1.4.8")]
        public object Pd148 { get; set; }

        [JsonProperty("PD1.4.9")]
        public string Pd149 { get; set; }

        [JsonProperty("PD1.4.10")]
        public object Pd1410 { get; set; }

        [JsonProperty("PD1.4.11")]
        public object Pd1411 { get; set; }

        [JsonProperty("PD1.4.12")]
        public object Pd1412 { get; set; }

        [JsonProperty("PD1.4.13")]
        public string Pd1413 { get; set; }
    }

    public partial class Pid
    {
        [JsonProperty("PID.1")]
        public Pid1 Pid1 { get; set; }

        [JsonProperty("PID.2")]
        public Pid2 Pid2 { get; set; }

        [JsonProperty("PID.3")]
        public Pid3 Pid3 { get; set; }

        [JsonProperty("PID.4")]
        public object Pid4 { get; set; }

        [JsonProperty("PID.5")]
        public Pid5 Pid5 { get; set; }

        [JsonProperty("PID.6")]
        public object Pid6 { get; set; }

        [JsonProperty("PID.7")]
        public Pid7 Pid7 { get; set; }

        [JsonProperty("PID.8")]
        public Pid8 Pid8 { get; set; }

        [JsonProperty("PID.9")]
        public object Pid9 { get; set; }

        [JsonProperty("PID.10")]
        public Pid10 Pid10 { get; set; }

        [JsonProperty("PID.11")]
        public Pid11 Pid11 { get; set; }

        [JsonProperty("PID.12")]
        public Pid12 Pid12 { get; set; }

        [JsonProperty("PID.13")]
        public Pid13 Pid13 { get; set; }

        [JsonProperty("PID.14")]
        public object Pid14 { get; set; }

        [JsonProperty("PID.15")]
        public Pid15 Pid15 { get; set; }

        [JsonProperty("PID.16")]
        public Pid16 Pid16 { get; set; }

        [JsonProperty("PID.17")]
        public object Pid17 { get; set; }

        [JsonProperty("PID.18")]
        public Pid18 Pid18 { get; set; }

        [JsonProperty("PID.19")]
        public object Pid19 { get; set; }

        [JsonProperty("PID.20")]
        public object Pid20 { get; set; }

        [JsonProperty("PID.21")]
        public Pid21 Pid21 { get; set; }

        [JsonProperty("PID.22")]
        public Pid22 Pid22 { get; set; }

        [JsonProperty("PID.23")]
        public object Pid23 { get; set; }

        [JsonProperty("PID.24")]
        public Pid24 Pid24 { get; set; }

        [JsonProperty("PID.25")]
        public object Pid25 { get; set; }

        [JsonProperty("PID.26")]
        public object Pid26 { get; set; }

        [JsonProperty("PID.27")]
        public object Pid27 { get; set; }

        [JsonProperty("PID.28")]
        public object Pid28 { get; set; }

        [JsonProperty("PID.29")]
        public object Pid29 { get; set; }

        [JsonProperty("PID.30")]
        public Pid30 Pid30 { get; set; }
    }

    public partial class Pid1
    {
        [JsonProperty("PID.1.1")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Pid11 { get; set; }
    }

    public partial class Pid10
    {
        [JsonProperty("PID.10.1")]
        public string Pid101 { get; set; }
    }

    public partial class Pid11
    {
        [JsonProperty("PID.11.1")]
        public string Pid111 { get; set; }

        [JsonProperty("PID.11.2")]
        public object Pid112 { get; set; }

        [JsonProperty("PID.11.3")]
        public string Pid113 { get; set; }

        [JsonProperty("PID.11.4")]
        public string Pid114 { get; set; }

        [JsonProperty("PID.11.5")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Pid115 { get; set; }

        [JsonProperty("PID.11.6")]
        public string Pid116 { get; set; }

        [JsonProperty("PID.11.7")]
        public string Pid117 { get; set; }

        [JsonProperty("PID.11.8")]
        public object Pid118 { get; set; }

        [JsonProperty("PID.11.9")]
        public string Pid119 { get; set; }
    }

    public partial class Pid12
    {
        [JsonProperty("PID.12.1")]
        public string Pid121 { get; set; }
    }

    public partial class Pid13
    {
        [JsonProperty("PID.13.1")]
        public string Pid131 { get; set; }

        [JsonProperty("PID.13.2")]
        public string Pid132 { get; set; }

        [JsonProperty("PID.13.3")]
        public string Pid133 { get; set; }

        [JsonProperty("PID.13.4")]
        public object Pid134 { get; set; }

        [JsonProperty("PID.13.5")]
        public object Pid135 { get; set; }

        [JsonProperty("PID.13.6")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Pid136 { get; set; }

        [JsonProperty("PID.13.7")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Pid137 { get; set; }
    }

    public partial class Pid15
    {
        [JsonProperty("PID.15.1")]
        public string Pid151 { get; set; }
    }

    public partial class Pid16
    {
        [JsonProperty("PID.16.1")]
        public string Pid161 { get; set; }
    }

    public partial class Pid18
    {
        [JsonProperty("PID.18.1")]
        public string Pid181 { get; set; }
    }

    public partial class Pid2
    {
        [JsonProperty("PID.2.1")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Pid21 { get; set; }

        [JsonProperty("PID.2.2")]
        public object Pid22 { get; set; }

        [JsonProperty("PID.2.3")]
        public object Pid23 { get; set; }

        [JsonProperty("PID.2.4")]
        public string Pid24 { get; set; }

        [JsonProperty("PID.2.5")]
        public string Pid25 { get; set; }
    }

    public partial class Pid21
    {
        [JsonProperty("PID.21.1")]
        public string Pid211 { get; set; }

        [JsonProperty("PID.21.2")]
        public string Pid212 { get; set; }
    }

    public partial class Pid22
    {
        [JsonProperty("PID.22.1")]
        public string Pid221 { get; set; }
    }

    public partial class Pid24
    {
        [JsonProperty("PID.24.1")]
        public string Pid241 { get; set; }
    }

    public partial class Pid3
    {
        [JsonProperty("PID.3.1")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Pid31 { get; set; }

        [JsonProperty("PID.3.2")]
        public object Pid32 { get; set; }

        [JsonProperty("PID.3.3")]
        public object Pid33 { get; set; }

        [JsonProperty("PID.3.4")]
        public string Pid34 { get; set; }

        [JsonProperty("PID.3.5")]
        public string Pid35 { get; set; }
    }

    public partial class Pid30
    {
        [JsonProperty("PID.30.1")]
        public string Pid301 { get; set; }
    }

    public partial class Pid5
    {
        [JsonProperty("PID.5.1")]
        public string Pid51 { get; set; }

        [JsonProperty("PID.5.2")]
        public string Pid52 { get; set; }
    }

    public partial class Pid7
    {
        [JsonProperty("PID.7.1")]
        public string Pid71 { get; set; }
    }

    public partial class Pid8
    {
        [JsonProperty("PID.8.1")]
        public string Pid81 { get; set; }
    }

    public partial class Pv1
    {
        [JsonProperty("PV1.1")]
        public Pv11 Pv11 { get; set; }

        [JsonProperty("PV1.2")]
        public Pv12 Pv12 { get; set; }

        [JsonProperty("PV1.3")]
        public Pv13 Pv13 { get; set; }

        [JsonProperty("PV1.4")]
        public Pv14 Pv14 { get; set; }

        [JsonProperty("PV1.5")]
        public object Pv15 { get; set; }

        [JsonProperty("PV1.6")]
        public object Pv16 { get; set; }

        [JsonProperty("PV1.7")]
        public Pv17 Pv17 { get; set; }

        [JsonProperty("PV1.8")]
        public Pv18 Pv18 { get; set; }

        [JsonProperty("PV1.9")]
        public object Pv19 { get; set; }

        [JsonProperty("PV1.10")]
        public object Pv110 { get; set; }

        [JsonProperty("PV1.11")]
        public object Pv111 { get; set; }

        [JsonProperty("PV1.12")]
        public object Pv112 { get; set; }

        [JsonProperty("PV1.13")]
        public object Pv113 { get; set; }

        [JsonProperty("PV1.14")]
        public Pv114 Pv114 { get; set; }

        [JsonProperty("PV1.15")]
        public object Pv115 { get; set; }

        [JsonProperty("PV1.16")]
        public object Pv116 { get; set; }

        [JsonProperty("PV1.17")]
        public object Pv117 { get; set; }

        [JsonProperty("PV1.18")]
        public object Pv118 { get; set; }

        [JsonProperty("PV1.19")]
        public Pv119 Pv119 { get; set; }

        [JsonProperty("PV1.20")]
        public Pv120 Pv120 { get; set; }

        [JsonProperty("PV1.21")]
        public object Pv121 { get; set; }

        [JsonProperty("PV1.22")]
        public object Pv122 { get; set; }

        [JsonProperty("PV1.23")]
        public object Pv123 { get; set; }

        [JsonProperty("PV1.24")]
        public object Pv124 { get; set; }

        [JsonProperty("PV1.25")]
        public object Pv125 { get; set; }

        [JsonProperty("PV1.26")]
        public object Pv126 { get; set; }

        [JsonProperty("PV1.27")]
        public object Pv127 { get; set; }

        [JsonProperty("PV1.28")]
        public object Pv128 { get; set; }

        [JsonProperty("PV1.29")]
        public object Pv129 { get; set; }

        [JsonProperty("PV1.30")]
        public object Pv130 { get; set; }

        [JsonProperty("PV1.31")]
        public object Pv131 { get; set; }

        [JsonProperty("PV1.32")]
        public object Pv132 { get; set; }

        [JsonProperty("PV1.33")]
        public object Pv133 { get; set; }

        [JsonProperty("PV1.34")]
        public object Pv134 { get; set; }

        [JsonProperty("PV1.35")]
        public object Pv135 { get; set; }

        [JsonProperty("PV1.36")]
        public object Pv136 { get; set; }

        [JsonProperty("PV1.37")]
        public object Pv137 { get; set; }

        [JsonProperty("PV1.38")]
        public object Pv138 { get; set; }

        [JsonProperty("PV1.39")]
        public object Pv139 { get; set; }

        [JsonProperty("PV1.40")]
        public object Pv140 { get; set; }

        [JsonProperty("PV1.41")]
        public Pv141 Pv141 { get; set; }

        [JsonProperty("PV1.42")]
        public object Pv142 { get; set; }

        [JsonProperty("PV1.43")]
        public object Pv143 { get; set; }

        [JsonProperty("PV1.44")]
        public Pv144 Pv144 { get; set; }
    }

    public partial class Pv11
    {
        [JsonProperty("PV1.1.1")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Pv111 { get; set; }
    }

    public partial class Pv114
    {
        [JsonProperty("PV1.14.1")]
        public string Pv1141 { get; set; }
    }

    public partial class Pv119
    {
        [JsonProperty("PV1.19.1")]
        public string Pv1191 { get; set; }
    }

    public partial class Pv12
    {
        [JsonProperty("PV1.2.1")]
        public string Pv121 { get; set; }
    }

    public partial class Pv120
    {
        [JsonProperty("PV1.20.1")]
        public string Pv1201 { get; set; }
    }

    public partial class Pv13
    {
        [JsonProperty("PV1.3.1")]
        public string Pv131 { get; set; }

        [JsonProperty("PV1.3.2")]
        public object Pv132 { get; set; }

        [JsonProperty("PV1.3.3")]
        public object Pv133 { get; set; }

        [JsonProperty("PV1.3.4")]
        public string Pv134 { get; set; }

        [JsonProperty("PV1.3.5")]
        public object Pv135 { get; set; }

        [JsonProperty("PV1.3.6")]
        public object Pv136 { get; set; }

        [JsonProperty("PV1.3.7")]
        public object Pv137 { get; set; }

        [JsonProperty("PV1.3.8")]
        public object Pv138 { get; set; }

        [JsonProperty("PV1.3.9")]
        public object Pv139 { get; set; }

        [JsonProperty("PV1.3.10")]
        public object Pv1310 { get; set; }

        [JsonProperty("PV1.3.11")]
        public string Pv1311 { get; set; }
    }

    public partial class Pv14
    {
        [JsonProperty("PV1.4.1")]
        public string Pv141 { get; set; }
    }

    public partial class Pv141
    {
        [JsonProperty("PV1.41.1")]
        public string Pv1411 { get; set; }
    }

    public partial class Pv144
    {
        [JsonProperty("PV1.44.1")]
        public string Pv1441 { get; set; }
    }

    public partial class Pv17
    {
        [JsonProperty("PV1.7.1")]
        public string Pv171 { get; set; }

        [JsonProperty("PV1.7.2")]
        public string Pv172 { get; set; }

        [JsonProperty("PV1.7.3")]
        public string Pv173 { get; set; }

        [JsonProperty("PV1.7.4")]
        public string Pv174 { get; set; }

        [JsonProperty("PV1.7.5")]
        public object Pv175 { get; set; }

        [JsonProperty("PV1.7.6")]
        public object Pv176 { get; set; }

        [JsonProperty("PV1.7.7")]
        public object Pv177 { get; set; }

        [JsonProperty("PV1.7.8")]
        public object Pv178 { get; set; }

        [JsonProperty("PV1.7.9")]
        public string Pv179 { get; set; }

        [JsonProperty("PV1.7.10")]
        public object Pv1710 { get; set; }

        [JsonProperty("PV1.7.11")]
        public object Pv1711 { get; set; }

        [JsonProperty("PV1.7.12")]
        public object Pv1712 { get; set; }

        [JsonProperty("PV1.7.13")]
        public string Pv1713 { get; set; }
    }

    public partial class Pv18
    {
        [JsonProperty("PV1.8.1")]
        public string Pv181 { get; set; }

        [JsonProperty("PV1.8.2")]
        public string Pv182 { get; set; }

        [JsonProperty("PV1.8.3")]
        public string Pv183 { get; set; }

        [JsonProperty("PV1.8.4")]
        public string Pv184 { get; set; }

        [JsonProperty("PV1.8.5")]
        public object Pv185 { get; set; }

        [JsonProperty("PV1.8.6")]
        public object Pv186 { get; set; }

        [JsonProperty("PV1.8.7")]
        public object Pv187 { get; set; }

        [JsonProperty("PV1.8.8")]
        public object Pv188 { get; set; }

        [JsonProperty("PV1.8.9")]
        public string Pv189 { get; set; }

        [JsonProperty("PV1.8.10")]
        public object Pv1810 { get; set; }

        [JsonProperty("PV1.8.11")]
        public object Pv1811 { get; set; }

        [JsonProperty("PV1.8.12")]
        public object Pv1812 { get; set; }

        [JsonProperty("PV1.8.13")]
        public string Pv1813 { get; set; }
    }

    public partial class Pv2
    {
        [JsonProperty("PV2.1")]
        public object Pv21 { get; set; }

        [JsonProperty("PV2.2")]
        public object Pv22 { get; set; }

        [JsonProperty("PV2.3")]
        public object Pv23 { get; set; }

        [JsonProperty("PV2.4")]
        public object Pv24 { get; set; }

        [JsonProperty("PV2.5")]
        public object Pv25 { get; set; }

        [JsonProperty("PV2.6")]
        public object Pv26 { get; set; }

        [JsonProperty("PV2.7")]
        public object Pv27 { get; set; }

        [JsonProperty("PV2.8")]
        public Pv28 Pv28 { get; set; }

        [JsonProperty("PV2.9")]
        public object Pv29 { get; set; }

        [JsonProperty("PV2.10")]
        public object Pv210 { get; set; }

        [JsonProperty("PV2.11")]
        public object Pv211 { get; set; }

        [JsonProperty("PV2.12")]
        public object Pv212 { get; set; }

        [JsonProperty("PV2.13")]
        public object Pv213 { get; set; }

        [JsonProperty("PV2.14")]
        public object Pv214 { get; set; }

        [JsonProperty("PV2.15")]
        public object Pv215 { get; set; }

        [JsonProperty("PV2.16")]
        public object Pv216 { get; set; }

        [JsonProperty("PV2.17")]
        public object Pv217 { get; set; }

        [JsonProperty("PV2.18")]
        public object Pv218 { get; set; }

        [JsonProperty("PV2.19")]
        public object Pv219 { get; set; }

        [JsonProperty("PV2.20")]
        public object Pv220 { get; set; }

        [JsonProperty("PV2.21")]
        public object Pv221 { get; set; }

        [JsonProperty("PV2.22")]
        public Pv222 Pv222 { get; set; }

        [JsonProperty("PV2.23")]
        public object Pv223 { get; set; }

        [JsonProperty("PV2.24")]
        public object Pv224 { get; set; }

        [JsonProperty("PV2.25")]
        public object Pv225 { get; set; }

        [JsonProperty("PV2.26")]
        public object Pv226 { get; set; }

        [JsonProperty("PV2.27")]
        public object Pv227 { get; set; }

        [JsonProperty("PV2.28")]
        public object Pv228 { get; set; }

        [JsonProperty("PV2.29")]
        public object Pv229 { get; set; }

        [JsonProperty("PV2.30")]
        public object Pv230 { get; set; }

        [JsonProperty("PV2.31")]
        public object Pv231 { get; set; }

        [JsonProperty("PV2.32")]
        public Pv232 Pv232 { get; set; }
    }

    public partial class Pv222
    {
        [JsonProperty("PV2.22.1")]
        public string Pv2221 { get; set; }
    }

    public partial class Pv232
    {
        [JsonProperty("PV2.32.1")]
        public string Pv2321 { get; set; }
    }

    public partial class Pv28
    {
        [JsonProperty("PV2.8.1")]
        public string Pv281 { get; set; }
    }

    public partial class Zpd
    {
        [JsonProperty("ZPD.1")]
        public object Zpd1 { get; set; }

        [JsonProperty("ZPD.2")]
        public Zpd2[] Zpd2 { get; set; }

        [JsonProperty("ZPD.3")]
        public object Zpd3 { get; set; }

        [JsonProperty("ZPD.4")]
        public object Zpd4 { get; set; }

        [JsonProperty("ZPD.5")]
        public object Zpd5 { get; set; }

        [JsonProperty("ZPD.6")]
        public object Zpd6 { get; set; }

        [JsonProperty("ZPD.7")]
        public Zpd7 Zpd7 { get; set; }

        [JsonProperty("ZPD.8")]
        public object Zpd8 { get; set; }

        [JsonProperty("ZPD.9")]
        public object Zpd9 { get; set; }

        [JsonProperty("ZPD.10")]
        public object Zpd10 { get; set; }

        [JsonProperty("ZPD.11")]
        public object Zpd11 { get; set; }

        [JsonProperty("ZPD.12")]
        public object Zpd12 { get; set; }

        [JsonProperty("ZPD.13")]
        public object Zpd13 { get; set; }

        [JsonProperty("ZPD.14")]
        public object Zpd14 { get; set; }

        [JsonProperty("ZPD.15")]
        public object Zpd15 { get; set; }

        [JsonProperty("ZPD.16")]
        public object Zpd16 { get; set; }

        [JsonProperty("ZPD.17")]
        public object Zpd17 { get; set; }

        [JsonProperty("ZPD.18")]
        public object Zpd18 { get; set; }

        [JsonProperty("ZPD.19")]
        public object Zpd19 { get; set; }

        [JsonProperty("ZPD.20")]
        public object Zpd20 { get; set; }

        [JsonProperty("ZPD.21")]
        public object Zpd21 { get; set; }

        [JsonProperty("ZPD.22")]
        public object Zpd22 { get; set; }

        [JsonProperty("ZPD.23")]
        public object Zpd23 { get; set; }

        [JsonProperty("ZPD.24")]
        public Zpd24 Zpd24 { get; set; }
    }

    public partial class Zpd2
    {
        [JsonProperty("ZPD.2.1")]
        public string Zpd21 { get; set; }
    }

    public partial class Zpd24
    {
        [JsonProperty("ZPD.24.1")]
        public string Zpd241 { get; set; }
    }

    public partial class Zpd7
    {
        [JsonProperty("ZPD.7.1")]
        public string Zpd71 { get; set; }
    }

    public partial class Zpv
    {
        [JsonProperty("ZPV.12.1")]
        public string Zpv121 { get; set; }
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(long) || t == typeof(long?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

}

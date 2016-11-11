﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace RTO.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class RTOContext : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new RTOContext object using the connection string found in the 'RTOContext' section of the application configuration file.
        /// </summary>
        public RTOContext() : base("name=RTOContext", "RTOContext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new RTOContext object.
        /// </summary>
        public RTOContext(string connectionString) : base(connectionString, "RTOContext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new RTOContext object.
        /// </summary>
        public RTOContext(EntityConnection connection) : base(connection, "RTOContext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<RegDetail> RegDetails
        {
            get
            {
                if ((_RegDetails == null))
                {
                    _RegDetails = base.CreateObjectSet<RegDetail>("RegDetails");
                }
                return _RegDetails;
            }
        }
        private ObjectSet<RegDetail> _RegDetails;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the RegDetails EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToRegDetails(RegDetail regDetail)
        {
            base.AddObject("RegDetails", regDetail);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="RTOModel", Name="RegDetail")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class RegDetail : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new RegDetail object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="vehicleType">Initial value of the VehicleType property.</param>
        /// <param name="vehicleMake">Initial value of the VehicleMake property.</param>
        /// <param name="vehicleName">Initial value of the VehicleName property.</param>
        /// <param name="ownerName">Initial value of the OwnerName property.</param>
        /// <param name="monthOfManu">Initial value of the MonthOfManu property.</param>
        /// <param name="yearOfManu">Initial value of the YearOfManu property.</param>
        /// <param name="chassisNumber">Initial value of the ChassisNumber property.</param>
        /// <param name="engine">Initial value of the Engine property.</param>
        /// <param name="fuelUsed">Initial value of the FuelUsed property.</param>
        /// <param name="noOfCylinder">Initial value of the NoOfCylinder property.</param>
        /// <param name="validFrom">Initial value of the ValidFrom property.</param>
        /// <param name="validUntil">Initial value of the ValidUntil property.</param>
        /// <param name="regNumber">Initial value of the RegNumber property.</param>
        /// <param name="color">Initial value of the Color property.</param>
        public static RegDetail CreateRegDetail(global::System.Int32 id, global::System.String vehicleType, global::System.String vehicleMake, global::System.String vehicleName, global::System.String ownerName, global::System.Int32 monthOfManu, global::System.Int32 yearOfManu, global::System.String chassisNumber, global::System.String engine, global::System.String fuelUsed, global::System.Int32 noOfCylinder, global::System.DateTime validFrom, global::System.DateTime validUntil, global::System.String regNumber, global::System.String color)
        {
            RegDetail regDetail = new RegDetail();
            regDetail.Id = id;
            regDetail.VehicleType = vehicleType;
            regDetail.VehicleMake = vehicleMake;
            regDetail.VehicleName = vehicleName;
            regDetail.OwnerName = ownerName;
            regDetail.MonthOfManu = monthOfManu;
            regDetail.YearOfManu = yearOfManu;
            regDetail.ChassisNumber = chassisNumber;
            regDetail.Engine = engine;
            regDetail.FuelUsed = fuelUsed;
            regDetail.NoOfCylinder = noOfCylinder;
            regDetail.ValidFrom = validFrom;
            regDetail.ValidUntil = validUntil;
            regDetail.RegNumber = regNumber;
            regDetail.Color = color;
            return regDetail;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String VehicleType
        {
            get
            {
                return _VehicleType;
            }
            set
            {
                OnVehicleTypeChanging(value);
                ReportPropertyChanging("VehicleType");
                _VehicleType = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("VehicleType");
                OnVehicleTypeChanged();
            }
        }
        private global::System.String _VehicleType;
        partial void OnVehicleTypeChanging(global::System.String value);
        partial void OnVehicleTypeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String VehicleMake
        {
            get
            {
                return _VehicleMake;
            }
            set
            {
                OnVehicleMakeChanging(value);
                ReportPropertyChanging("VehicleMake");
                _VehicleMake = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("VehicleMake");
                OnVehicleMakeChanged();
            }
        }
        private global::System.String _VehicleMake;
        partial void OnVehicleMakeChanging(global::System.String value);
        partial void OnVehicleMakeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String VehicleName
        {
            get
            {
                return _VehicleName;
            }
            set
            {
                OnVehicleNameChanging(value);
                ReportPropertyChanging("VehicleName");
                _VehicleName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("VehicleName");
                OnVehicleNameChanged();
            }
        }
        private global::System.String _VehicleName;
        partial void OnVehicleNameChanging(global::System.String value);
        partial void OnVehicleNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String OwnerName
        {
            get
            {
                return _OwnerName;
            }
            set
            {
                OnOwnerNameChanging(value);
                ReportPropertyChanging("OwnerName");
                _OwnerName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("OwnerName");
                OnOwnerNameChanged();
            }
        }
        private global::System.String _OwnerName;
        partial void OnOwnerNameChanging(global::System.String value);
        partial void OnOwnerNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 MonthOfManu
        {
            get
            {
                return _MonthOfManu;
            }
            set
            {
                OnMonthOfManuChanging(value);
                ReportPropertyChanging("MonthOfManu");
                _MonthOfManu = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("MonthOfManu");
                OnMonthOfManuChanged();
            }
        }
        private global::System.Int32 _MonthOfManu;
        partial void OnMonthOfManuChanging(global::System.Int32 value);
        partial void OnMonthOfManuChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 YearOfManu
        {
            get
            {
                return _YearOfManu;
            }
            set
            {
                OnYearOfManuChanging(value);
                ReportPropertyChanging("YearOfManu");
                _YearOfManu = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("YearOfManu");
                OnYearOfManuChanged();
            }
        }
        private global::System.Int32 _YearOfManu;
        partial void OnYearOfManuChanging(global::System.Int32 value);
        partial void OnYearOfManuChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ChassisNumber
        {
            get
            {
                return _ChassisNumber;
            }
            set
            {
                OnChassisNumberChanging(value);
                ReportPropertyChanging("ChassisNumber");
                _ChassisNumber = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ChassisNumber");
                OnChassisNumberChanged();
            }
        }
        private global::System.String _ChassisNumber;
        partial void OnChassisNumberChanging(global::System.String value);
        partial void OnChassisNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Engine
        {
            get
            {
                return _Engine;
            }
            set
            {
                OnEngineChanging(value);
                ReportPropertyChanging("Engine");
                _Engine = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Engine");
                OnEngineChanged();
            }
        }
        private global::System.String _Engine;
        partial void OnEngineChanging(global::System.String value);
        partial void OnEngineChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FuelUsed
        {
            get
            {
                return _FuelUsed;
            }
            set
            {
                OnFuelUsedChanging(value);
                ReportPropertyChanging("FuelUsed");
                _FuelUsed = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("FuelUsed");
                OnFuelUsedChanged();
            }
        }
        private global::System.String _FuelUsed;
        partial void OnFuelUsedChanging(global::System.String value);
        partial void OnFuelUsedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 NoOfCylinder
        {
            get
            {
                return _NoOfCylinder;
            }
            set
            {
                OnNoOfCylinderChanging(value);
                ReportPropertyChanging("NoOfCylinder");
                _NoOfCylinder = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("NoOfCylinder");
                OnNoOfCylinderChanged();
            }
        }
        private global::System.Int32 _NoOfCylinder;
        partial void OnNoOfCylinderChanging(global::System.Int32 value);
        partial void OnNoOfCylinderChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime ValidFrom
        {
            get
            {
                return _ValidFrom;
            }
            set
            {
                OnValidFromChanging(value);
                ReportPropertyChanging("ValidFrom");
                _ValidFrom = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ValidFrom");
                OnValidFromChanged();
            }
        }
        private global::System.DateTime _ValidFrom;
        partial void OnValidFromChanging(global::System.DateTime value);
        partial void OnValidFromChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime ValidUntil
        {
            get
            {
                return _ValidUntil;
            }
            set
            {
                OnValidUntilChanging(value);
                ReportPropertyChanging("ValidUntil");
                _ValidUntil = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ValidUntil");
                OnValidUntilChanged();
            }
        }
        private global::System.DateTime _ValidUntil;
        partial void OnValidUntilChanging(global::System.DateTime value);
        partial void OnValidUntilChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String RegNumber
        {
            get
            {
                return _RegNumber;
            }
            set
            {
                OnRegNumberChanging(value);
                ReportPropertyChanging("RegNumber");
                _RegNumber = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("RegNumber");
                OnRegNumberChanged();
            }
        }
        private global::System.String _RegNumber;
        partial void OnRegNumberChanging(global::System.String value);
        partial void OnRegNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Color
        {
            get
            {
                return _Color;
            }
            set
            {
                OnColorChanging(value);
                ReportPropertyChanging("Color");
                _Color = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Color");
                OnColorChanged();
            }
        }
        private global::System.String _Color;
        partial void OnColorChanging(global::System.String value);
        partial void OnColorChanged();

        #endregion

    
    }

    #endregion

    
}
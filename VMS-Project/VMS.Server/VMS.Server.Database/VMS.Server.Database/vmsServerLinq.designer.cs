﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VMS.Server.Database
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="vmsServer")]
	public partial class vmsServerLinqDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertModule(Module instance);
    partial void UpdateModule(Module instance);
    partial void DeleteModule(Module instance);
    partial void InsertTracking(Tracking instance);
    partial void UpdateTracking(Tracking instance);
    partial void DeleteTracking(Tracking instance);
    partial void InsertSystemLog(SystemLog instance);
    partial void UpdateSystemLog(SystemLog instance);
    partial void DeleteSystemLog(SystemLog instance);
    #endregion
		
		public vmsServerLinqDataContext() : 
				base(global::VMS.Server.Database.Properties.Settings.Default.vmsServerConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public vmsServerLinqDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public vmsServerLinqDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public vmsServerLinqDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public vmsServerLinqDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Module> Modules
		{
			get
			{
				return this.GetTable<Module>();
			}
		}
		
		public System.Data.Linq.Table<Tracking> Trackings
		{
			get
			{
				return this.GetTable<Tracking>();
			}
		}
		
		public System.Data.Linq.Table<Session> Sessions
		{
			get
			{
				return this.GetTable<Session>();
			}
		}
		
		public System.Data.Linq.Table<SystemLog> SystemLogs
		{
			get
			{
				return this.GetTable<SystemLog>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Module")]
	public partial class Module : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ModuleNumber;
		
		private string _ModuleType;
		
		private System.Nullable<bool> _IsActive;
		
		private EntitySet<Tracking> _Trackings;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnModuleNumberChanging(string value);
    partial void OnModuleNumberChanged();
    partial void OnModuleTypeChanging(string value);
    partial void OnModuleTypeChanged();
    partial void OnIsActiveChanging(System.Nullable<bool> value);
    partial void OnIsActiveChanged();
    #endregion
		
		public Module()
		{
			this._Trackings = new EntitySet<Tracking>(new Action<Tracking>(this.attach_Trackings), new Action<Tracking>(this.detach_Trackings));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModuleNumber", DbType="NChar(11) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ModuleNumber
		{
			get
			{
				return this._ModuleNumber;
			}
			set
			{
				if ((this._ModuleNumber != value))
				{
					this.OnModuleNumberChanging(value);
					this.SendPropertyChanging();
					this._ModuleNumber = value;
					this.SendPropertyChanged("ModuleNumber");
					this.OnModuleNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModuleType", DbType="NChar(10)")]
		public string ModuleType
		{
			get
			{
				return this._ModuleType;
			}
			set
			{
				if ((this._ModuleType != value))
				{
					this.OnModuleTypeChanging(value);
					this.SendPropertyChanging();
					this._ModuleType = value;
					this.SendPropertyChanged("ModuleType");
					this.OnModuleTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsActive", DbType="Bit")]
		public System.Nullable<bool> IsActive
		{
			get
			{
				return this._IsActive;
			}
			set
			{
				if ((this._IsActive != value))
				{
					this.OnIsActiveChanging(value);
					this.SendPropertyChanging();
					this._IsActive = value;
					this.SendPropertyChanged("IsActive");
					this.OnIsActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Module_Tracking", Storage="_Trackings", ThisKey="ModuleNumber", OtherKey="ModuleID")]
		public EntitySet<Tracking> Trackings
		{
			get
			{
				return this._Trackings;
			}
			set
			{
				this._Trackings.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Trackings(Tracking entity)
		{
			this.SendPropertyChanging();
			entity.Module = this;
		}
		
		private void detach_Trackings(Tracking entity)
		{
			this.SendPropertyChanging();
			entity.Module = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tracking")]
	public partial class Tracking : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _TrackingID;
		
		private string _ModuleID;
		
		private System.Nullable<double> _Longtitude;
		
		private System.Nullable<double> _Latitude;
		
		private System.Nullable<double> _Speed;
		
		private System.Nullable<double> _FuelLevel;
		
		private System.Nullable<System.DateTime> _Time;
		
		private EntityRef<Module> _Module;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTrackingIDChanging(long value);
    partial void OnTrackingIDChanged();
    partial void OnModuleIDChanging(string value);
    partial void OnModuleIDChanged();
    partial void OnLongtitudeChanging(System.Nullable<double> value);
    partial void OnLongtitudeChanged();
    partial void OnLatitudeChanging(System.Nullable<double> value);
    partial void OnLatitudeChanged();
    partial void OnSpeedChanging(System.Nullable<double> value);
    partial void OnSpeedChanged();
    partial void OnFuelLevelChanging(System.Nullable<double> value);
    partial void OnFuelLevelChanged();
    partial void OnTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnTimeChanged();
    #endregion
		
		public Tracking()
		{
			this._Module = default(EntityRef<Module>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrackingID", DbType="BigInt NOT NULL", IsPrimaryKey=true)]
		public long TrackingID
		{
			get
			{
				return this._TrackingID;
			}
			set
			{
				if ((this._TrackingID != value))
				{
					this.OnTrackingIDChanging(value);
					this.SendPropertyChanging();
					this._TrackingID = value;
					this.SendPropertyChanged("TrackingID");
					this.OnTrackingIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModuleID", DbType="NChar(11)")]
		public string ModuleID
		{
			get
			{
				return this._ModuleID;
			}
			set
			{
				if ((this._ModuleID != value))
				{
					if (this._Module.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnModuleIDChanging(value);
					this.SendPropertyChanging();
					this._ModuleID = value;
					this.SendPropertyChanged("ModuleID");
					this.OnModuleIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Longtitude", DbType="Float")]
		public System.Nullable<double> Longtitude
		{
			get
			{
				return this._Longtitude;
			}
			set
			{
				if ((this._Longtitude != value))
				{
					this.OnLongtitudeChanging(value);
					this.SendPropertyChanging();
					this._Longtitude = value;
					this.SendPropertyChanged("Longtitude");
					this.OnLongtitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Latitude", DbType="Float")]
		public System.Nullable<double> Latitude
		{
			get
			{
				return this._Latitude;
			}
			set
			{
				if ((this._Latitude != value))
				{
					this.OnLatitudeChanging(value);
					this.SendPropertyChanging();
					this._Latitude = value;
					this.SendPropertyChanged("Latitude");
					this.OnLatitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Speed", DbType="Float")]
		public System.Nullable<double> Speed
		{
			get
			{
				return this._Speed;
			}
			set
			{
				if ((this._Speed != value))
				{
					this.OnSpeedChanging(value);
					this.SendPropertyChanging();
					this._Speed = value;
					this.SendPropertyChanged("Speed");
					this.OnSpeedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FuelLevel", DbType="Float")]
		public System.Nullable<double> FuelLevel
		{
			get
			{
				return this._FuelLevel;
			}
			set
			{
				if ((this._FuelLevel != value))
				{
					this.OnFuelLevelChanging(value);
					this.SendPropertyChanging();
					this._FuelLevel = value;
					this.SendPropertyChanged("FuelLevel");
					this.OnFuelLevelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Time", DbType="DateTime")]
		public System.Nullable<System.DateTime> Time
		{
			get
			{
				return this._Time;
			}
			set
			{
				if ((this._Time != value))
				{
					this.OnTimeChanging(value);
					this.SendPropertyChanging();
					this._Time = value;
					this.SendPropertyChanged("Time");
					this.OnTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Module_Tracking", Storage="_Module", ThisKey="ModuleID", OtherKey="ModuleNumber", IsForeignKey=true)]
		public Module Module
		{
			get
			{
				return this._Module.Entity;
			}
			set
			{
				Module previousValue = this._Module.Entity;
				if (((previousValue != value) 
							|| (this._Module.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Module.Entity = null;
						previousValue.Trackings.Remove(this);
					}
					this._Module.Entity = value;
					if ((value != null))
					{
						value.Trackings.Add(this);
						this._ModuleID = value.ModuleNumber;
					}
					else
					{
						this._ModuleID = default(string);
					}
					this.SendPropertyChanged("Module");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Session")]
	public partial class Session
	{
		
		private System.Nullable<long> _SessionID;
		
		private System.Nullable<long> _TrackingID;
		
		public Session()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SessionID", DbType="BigInt")]
		public System.Nullable<long> SessionID
		{
			get
			{
				return this._SessionID;
			}
			set
			{
				if ((this._SessionID != value))
				{
					this._SessionID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrackingID", DbType="BigInt")]
		public System.Nullable<long> TrackingID
		{
			get
			{
				return this._TrackingID;
			}
			set
			{
				if ((this._TrackingID != value))
				{
					this._TrackingID = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SystemLog")]
	public partial class SystemLog : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _LogValue;
		
		private System.Nullable<System.DateTime> _Time;
		
		private string _Type;
		
		private long _LogID;
		
		private string _Source;
		
		private string _StackTrace;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLogValueChanging(string value);
    partial void OnLogValueChanged();
    partial void OnTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnTimeChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    partial void OnLogIDChanging(long value);
    partial void OnLogIDChanged();
    partial void OnSourceChanging(string value);
    partial void OnSourceChanged();
    partial void OnStackTraceChanging(string value);
    partial void OnStackTraceChanged();
    #endregion
		
		public SystemLog()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LogValue", DbType="NVarChar(MAX)")]
		public string LogValue
		{
			get
			{
				return this._LogValue;
			}
			set
			{
				if ((this._LogValue != value))
				{
					this.OnLogValueChanging(value);
					this.SendPropertyChanging();
					this._LogValue = value;
					this.SendPropertyChanged("LogValue");
					this.OnLogValueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Time", DbType="DateTime")]
		public System.Nullable<System.DateTime> Time
		{
			get
			{
				return this._Time;
			}
			set
			{
				if ((this._Time != value))
				{
					this.OnTimeChanging(value);
					this.SendPropertyChanging();
					this._Time = value;
					this.SendPropertyChanged("Time");
					this.OnTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="NVarChar(50)")]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LogID", DbType="BigInt NOT NULL", IsPrimaryKey=true)]
		public long LogID
		{
			get
			{
				return this._LogID;
			}
			set
			{
				if ((this._LogID != value))
				{
					this.OnLogIDChanging(value);
					this.SendPropertyChanging();
					this._LogID = value;
					this.SendPropertyChanged("LogID");
					this.OnLogIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Source", DbType="NVarChar(MAX)")]
		public string Source
		{
			get
			{
				return this._Source;
			}
			set
			{
				if ((this._Source != value))
				{
					this.OnSourceChanging(value);
					this.SendPropertyChanging();
					this._Source = value;
					this.SendPropertyChanged("Source");
					this.OnSourceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StackTrace", DbType="NVarChar(MAX)")]
		public string StackTrace
		{
			get
			{
				return this._StackTrace;
			}
			set
			{
				if ((this._StackTrace != value))
				{
					this.OnStackTraceChanging(value);
					this.SendPropertyChanging();
					this._StackTrace = value;
					this.SendPropertyChanged("StackTrace");
					this.OnStackTraceChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591

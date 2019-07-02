﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqTo1
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="OkulSistemi")]
	public partial class LinqTODataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDer(Der instance);
    partial void UpdateDer(Der instance);
    partial void DeleteDer(Der instance);
    partial void InsertVeli(Veli instance);
    partial void UpdateVeli(Veli instance);
    partial void DeleteVeli(Veli instance);
    partial void InsertOgrenci(Ogrenci instance);
    partial void UpdateOgrenci(Ogrenci instance);
    partial void DeleteOgrenci(Ogrenci instance);
    partial void InsertOgrenciDer(OgrenciDer instance);
    partial void UpdateOgrenciDer(OgrenciDer instance);
    partial void DeleteOgrenciDer(OgrenciDer instance);
    partial void InsertOgretmen(Ogretmen instance);
    partial void UpdateOgretmen(Ogretmen instance);
    partial void DeleteOgretmen(Ogretmen instance);
    #endregion
		
		public LinqTODataContext() : 
				base(global::LinqTo1.Properties.Settings.Default.OkulSistemiConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LinqTODataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqTODataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqTODataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqTODataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Der> Ders
		{
			get
			{
				return this.GetTable<Der>();
			}
		}
		
		public System.Data.Linq.Table<Veli> Velis
		{
			get
			{
				return this.GetTable<Veli>();
			}
		}
		
		public System.Data.Linq.Table<Ogrenci> Ogrencis
		{
			get
			{
				return this.GetTable<Ogrenci>();
			}
		}
		
		public System.Data.Linq.Table<OgrenciDer> OgrenciDers
		{
			get
			{
				return this.GetTable<OgrenciDer>();
			}
		}
		
		public System.Data.Linq.Table<Ogretmen> Ogretmens
		{
			get
			{
				return this.GetTable<Ogretmen>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Ders")]
	public partial class Der : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DersId;
		
		private string _Adi;
		
		private System.Nullable<byte> _Saati;
		
		private EntitySet<OgrenciDer> _OgrenciDers;
		
		private EntitySet<Ogretmen> _Ogretmens;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDersIdChanging(int value);
    partial void OnDersIdChanged();
    partial void OnAdiChanging(string value);
    partial void OnAdiChanged();
    partial void OnSaatiChanging(System.Nullable<byte> value);
    partial void OnSaatiChanged();
    #endregion
		
		public Der()
		{
			this._OgrenciDers = new EntitySet<OgrenciDer>(new Action<OgrenciDer>(this.attach_OgrenciDers), new Action<OgrenciDer>(this.detach_OgrenciDers));
			this._Ogretmens = new EntitySet<Ogretmen>(new Action<Ogretmen>(this.attach_Ogretmens), new Action<Ogretmen>(this.detach_Ogretmens));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DersId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int DersId
		{
			get
			{
				return this._DersId;
			}
			set
			{
				if ((this._DersId != value))
				{
					this.OnDersIdChanging(value);
					this.SendPropertyChanging();
					this._DersId = value;
					this.SendPropertyChanged("DersId");
					this.OnDersIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adi", DbType="NVarChar(50)")]
		public string Adi
		{
			get
			{
				return this._Adi;
			}
			set
			{
				if ((this._Adi != value))
				{
					this.OnAdiChanging(value);
					this.SendPropertyChanging();
					this._Adi = value;
					this.SendPropertyChanged("Adi");
					this.OnAdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Saati", DbType="TinyInt")]
		public System.Nullable<byte> Saati
		{
			get
			{
				return this._Saati;
			}
			set
			{
				if ((this._Saati != value))
				{
					this.OnSaatiChanging(value);
					this.SendPropertyChanging();
					this._Saati = value;
					this.SendPropertyChanged("Saati");
					this.OnSaatiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Der_OgrenciDer", Storage="_OgrenciDers", ThisKey="DersId", OtherKey="DersID")]
		public EntitySet<OgrenciDer> OgrenciDers
		{
			get
			{
				return this._OgrenciDers;
			}
			set
			{
				this._OgrenciDers.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Der_Ogretmen", Storage="_Ogretmens", ThisKey="DersId", OtherKey="DersID")]
		public EntitySet<Ogretmen> Ogretmens
		{
			get
			{
				return this._Ogretmens;
			}
			set
			{
				this._Ogretmens.Assign(value);
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
		
		private void attach_OgrenciDers(OgrenciDer entity)
		{
			this.SendPropertyChanging();
			entity.Der = this;
		}
		
		private void detach_OgrenciDers(OgrenciDer entity)
		{
			this.SendPropertyChanging();
			entity.Der = null;
		}
		
		private void attach_Ogretmens(Ogretmen entity)
		{
			this.SendPropertyChanging();
			entity.Der = this;
		}
		
		private void detach_Ogretmens(Ogretmen entity)
		{
			this.SendPropertyChanging();
			entity.Der = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Veli")]
	public partial class Veli : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _VeliId;
		
		private string _VAdi;
		
		private string _Soyadi;
		
		private string _Adresi;
		
		private string _TelNo;
		
		private EntitySet<Ogrenci> _Ogrencis;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnVeliIdChanging(int value);
    partial void OnVeliIdChanged();
    partial void OnVAdiChanging(string value);
    partial void OnVAdiChanged();
    partial void OnSoyadiChanging(string value);
    partial void OnSoyadiChanged();
    partial void OnAdresiChanging(string value);
    partial void OnAdresiChanged();
    partial void OnTelNoChanging(string value);
    partial void OnTelNoChanged();
    #endregion
		
		public Veli()
		{
			this._Ogrencis = new EntitySet<Ogrenci>(new Action<Ogrenci>(this.attach_Ogrencis), new Action<Ogrenci>(this.detach_Ogrencis));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VeliId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int VeliId
		{
			get
			{
				return this._VeliId;
			}
			set
			{
				if ((this._VeliId != value))
				{
					this.OnVeliIdChanging(value);
					this.SendPropertyChanging();
					this._VeliId = value;
					this.SendPropertyChanged("VeliId");
					this.OnVeliIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VAdi", DbType="NVarChar(50)")]
		public string VAdi
		{
			get
			{
				return this._VAdi;
			}
			set
			{
				if ((this._VAdi != value))
				{
					this.OnVAdiChanging(value);
					this.SendPropertyChanging();
					this._VAdi = value;
					this.SendPropertyChanged("VAdi");
					this.OnVAdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Soyadi", DbType="NVarChar(50)")]
		public string Soyadi
		{
			get
			{
				return this._Soyadi;
			}
			set
			{
				if ((this._Soyadi != value))
				{
					this.OnSoyadiChanging(value);
					this.SendPropertyChanging();
					this._Soyadi = value;
					this.SendPropertyChanged("Soyadi");
					this.OnSoyadiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adresi", DbType="NVarChar(50)")]
		public string Adresi
		{
			get
			{
				return this._Adresi;
			}
			set
			{
				if ((this._Adresi != value))
				{
					this.OnAdresiChanging(value);
					this.SendPropertyChanging();
					this._Adresi = value;
					this.SendPropertyChanged("Adresi");
					this.OnAdresiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TelNo", DbType="Char(11)")]
		public string TelNo
		{
			get
			{
				return this._TelNo;
			}
			set
			{
				if ((this._TelNo != value))
				{
					this.OnTelNoChanging(value);
					this.SendPropertyChanging();
					this._TelNo = value;
					this.SendPropertyChanged("TelNo");
					this.OnTelNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Veli_Ogrenci", Storage="_Ogrencis", ThisKey="VeliId", OtherKey="VeliID")]
		public EntitySet<Ogrenci> Ogrencis
		{
			get
			{
				return this._Ogrencis;
			}
			set
			{
				this._Ogrencis.Assign(value);
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
		
		private void attach_Ogrencis(Ogrenci entity)
		{
			this.SendPropertyChanging();
			entity.Veli = this;
		}
		
		private void detach_Ogrencis(Ogrenci entity)
		{
			this.SendPropertyChanging();
			entity.Veli = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Ogrenci")]
	public partial class Ogrenci : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OgrenciId;
		
		private string _TCKN;
		
		private string _Adi;
		
		private string _Soyadi;
		
		private System.Nullable<int> _OkulNo;
		
		private System.Nullable<System.DateTime> _DogumTarihi;
		
		private System.Nullable<int> _VeliID;
		
		private EntitySet<OgrenciDer> _OgrenciDers;
		
		private EntityRef<Veli> _Veli;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOgrenciIdChanging(int value);
    partial void OnOgrenciIdChanged();
    partial void OnTCKNChanging(string value);
    partial void OnTCKNChanged();
    partial void OnAdiChanging(string value);
    partial void OnAdiChanged();
    partial void OnSoyadiChanging(string value);
    partial void OnSoyadiChanged();
    partial void OnOkulNoChanging(System.Nullable<int> value);
    partial void OnOkulNoChanged();
    partial void OnDogumTarihiChanging(System.Nullable<System.DateTime> value);
    partial void OnDogumTarihiChanged();
    partial void OnVeliIDChanging(System.Nullable<int> value);
    partial void OnVeliIDChanged();
    #endregion
		
		public Ogrenci()
		{
			this._OgrenciDers = new EntitySet<OgrenciDer>(new Action<OgrenciDer>(this.attach_OgrenciDers), new Action<OgrenciDer>(this.detach_OgrenciDers));
			this._Veli = default(EntityRef<Veli>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OgrenciId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int OgrenciId
		{
			get
			{
				return this._OgrenciId;
			}
			set
			{
				if ((this._OgrenciId != value))
				{
					this.OnOgrenciIdChanging(value);
					this.SendPropertyChanging();
					this._OgrenciId = value;
					this.SendPropertyChanged("OgrenciId");
					this.OnOgrenciIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TCKN", DbType="Char(11)")]
		public string TCKN
		{
			get
			{
				return this._TCKN;
			}
			set
			{
				if ((this._TCKN != value))
				{
					this.OnTCKNChanging(value);
					this.SendPropertyChanging();
					this._TCKN = value;
					this.SendPropertyChanged("TCKN");
					this.OnTCKNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adi", DbType="NVarChar(50)")]
		public string Adi
		{
			get
			{
				return this._Adi;
			}
			set
			{
				if ((this._Adi != value))
				{
					this.OnAdiChanging(value);
					this.SendPropertyChanging();
					this._Adi = value;
					this.SendPropertyChanged("Adi");
					this.OnAdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Soyadi", DbType="NVarChar(50)")]
		public string Soyadi
		{
			get
			{
				return this._Soyadi;
			}
			set
			{
				if ((this._Soyadi != value))
				{
					this.OnSoyadiChanging(value);
					this.SendPropertyChanging();
					this._Soyadi = value;
					this.SendPropertyChanged("Soyadi");
					this.OnSoyadiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OkulNo", DbType="Int")]
		public System.Nullable<int> OkulNo
		{
			get
			{
				return this._OkulNo;
			}
			set
			{
				if ((this._OkulNo != value))
				{
					this.OnOkulNoChanging(value);
					this.SendPropertyChanging();
					this._OkulNo = value;
					this.SendPropertyChanged("OkulNo");
					this.OnOkulNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DogumTarihi", DbType="Date")]
		public System.Nullable<System.DateTime> DogumTarihi
		{
			get
			{
				return this._DogumTarihi;
			}
			set
			{
				if ((this._DogumTarihi != value))
				{
					this.OnDogumTarihiChanging(value);
					this.SendPropertyChanging();
					this._DogumTarihi = value;
					this.SendPropertyChanged("DogumTarihi");
					this.OnDogumTarihiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VeliID", DbType="Int")]
		public System.Nullable<int> VeliID
		{
			get
			{
				return this._VeliID;
			}
			set
			{
				if ((this._VeliID != value))
				{
					if (this._Veli.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnVeliIDChanging(value);
					this.SendPropertyChanging();
					this._VeliID = value;
					this.SendPropertyChanged("VeliID");
					this.OnVeliIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ogrenci_OgrenciDer", Storage="_OgrenciDers", ThisKey="OgrenciId", OtherKey="OgrenciID")]
		public EntitySet<OgrenciDer> OgrenciDers
		{
			get
			{
				return this._OgrenciDers;
			}
			set
			{
				this._OgrenciDers.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Veli_Ogrenci", Storage="_Veli", ThisKey="VeliID", OtherKey="VeliId", IsForeignKey=true)]
		public Veli Veli
		{
			get
			{
				return this._Veli.Entity;
			}
			set
			{
				Veli previousValue = this._Veli.Entity;
				if (((previousValue != value) 
							|| (this._Veli.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Veli.Entity = null;
						previousValue.Ogrencis.Remove(this);
					}
					this._Veli.Entity = value;
					if ((value != null))
					{
						value.Ogrencis.Add(this);
						this._VeliID = value.VeliId;
					}
					else
					{
						this._VeliID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Veli");
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
		
		private void attach_OgrenciDers(OgrenciDer entity)
		{
			this.SendPropertyChanging();
			entity.Ogrenci = this;
		}
		
		private void detach_OgrenciDers(OgrenciDer entity)
		{
			this.SendPropertyChanging();
			entity.Ogrenci = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OgrenciDers")]
	public partial class OgrenciDer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OgrenciID;
		
		private int _DersID;
		
		private EntityRef<Der> _Der;
		
		private EntityRef<Ogrenci> _Ogrenci;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOgrenciIDChanging(int value);
    partial void OnOgrenciIDChanged();
    partial void OnDersIDChanging(int value);
    partial void OnDersIDChanged();
    #endregion
		
		public OgrenciDer()
		{
			this._Der = default(EntityRef<Der>);
			this._Ogrenci = default(EntityRef<Ogrenci>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OgrenciID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int OgrenciID
		{
			get
			{
				return this._OgrenciID;
			}
			set
			{
				if ((this._OgrenciID != value))
				{
					if (this._Ogrenci.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnOgrenciIDChanging(value);
					this.SendPropertyChanging();
					this._OgrenciID = value;
					this.SendPropertyChanged("OgrenciID");
					this.OnOgrenciIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DersID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int DersID
		{
			get
			{
				return this._DersID;
			}
			set
			{
				if ((this._DersID != value))
				{
					if (this._Der.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDersIDChanging(value);
					this.SendPropertyChanging();
					this._DersID = value;
					this.SendPropertyChanged("DersID");
					this.OnDersIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Der_OgrenciDer", Storage="_Der", ThisKey="DersID", OtherKey="DersId", IsForeignKey=true)]
		public Der Der
		{
			get
			{
				return this._Der.Entity;
			}
			set
			{
				Der previousValue = this._Der.Entity;
				if (((previousValue != value) 
							|| (this._Der.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Der.Entity = null;
						previousValue.OgrenciDers.Remove(this);
					}
					this._Der.Entity = value;
					if ((value != null))
					{
						value.OgrenciDers.Add(this);
						this._DersID = value.DersId;
					}
					else
					{
						this._DersID = default(int);
					}
					this.SendPropertyChanged("Der");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ogrenci_OgrenciDer", Storage="_Ogrenci", ThisKey="OgrenciID", OtherKey="OgrenciId", IsForeignKey=true)]
		public Ogrenci Ogrenci
		{
			get
			{
				return this._Ogrenci.Entity;
			}
			set
			{
				Ogrenci previousValue = this._Ogrenci.Entity;
				if (((previousValue != value) 
							|| (this._Ogrenci.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Ogrenci.Entity = null;
						previousValue.OgrenciDers.Remove(this);
					}
					this._Ogrenci.Entity = value;
					if ((value != null))
					{
						value.OgrenciDers.Add(this);
						this._OgrenciID = value.OgrenciId;
					}
					else
					{
						this._OgrenciID = default(int);
					}
					this.SendPropertyChanged("Ogrenci");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Ogretmen")]
	public partial class Ogretmen : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OgretmenId;
		
		private string _Adi;
		
		private string _Soyadi;
		
		private System.Nullable<int> _DersID;
		
		private System.Nullable<System.DateTime> _DogumTarihi;
		
		private bool _AktifMi;
		
		private EntityRef<Der> _Der;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOgretmenIdChanging(int value);
    partial void OnOgretmenIdChanged();
    partial void OnAdiChanging(string value);
    partial void OnAdiChanged();
    partial void OnSoyadiChanging(string value);
    partial void OnSoyadiChanged();
    partial void OnDersIDChanging(System.Nullable<int> value);
    partial void OnDersIDChanged();
    partial void OnDogumTarihiChanging(System.Nullable<System.DateTime> value);
    partial void OnDogumTarihiChanged();
    partial void OnAktifMiChanging(bool value);
    partial void OnAktifMiChanged();
    #endregion
		
		public Ogretmen()
		{
			this._Der = default(EntityRef<Der>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OgretmenId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int OgretmenId
		{
			get
			{
				return this._OgretmenId;
			}
			set
			{
				if ((this._OgretmenId != value))
				{
					this.OnOgretmenIdChanging(value);
					this.SendPropertyChanging();
					this._OgretmenId = value;
					this.SendPropertyChanged("OgretmenId");
					this.OnOgretmenIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adi", DbType="NVarChar(50)")]
		public string Adi
		{
			get
			{
				return this._Adi;
			}
			set
			{
				if ((this._Adi != value))
				{
					this.OnAdiChanging(value);
					this.SendPropertyChanging();
					this._Adi = value;
					this.SendPropertyChanged("Adi");
					this.OnAdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Soyadi", DbType="NVarChar(50)")]
		public string Soyadi
		{
			get
			{
				return this._Soyadi;
			}
			set
			{
				if ((this._Soyadi != value))
				{
					this.OnSoyadiChanging(value);
					this.SendPropertyChanging();
					this._Soyadi = value;
					this.SendPropertyChanged("Soyadi");
					this.OnSoyadiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DersID", DbType="Int")]
		public System.Nullable<int> DersID
		{
			get
			{
				return this._DersID;
			}
			set
			{
				if ((this._DersID != value))
				{
					if (this._Der.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDersIDChanging(value);
					this.SendPropertyChanging();
					this._DersID = value;
					this.SendPropertyChanged("DersID");
					this.OnDersIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DogumTarihi", DbType="Date")]
		public System.Nullable<System.DateTime> DogumTarihi
		{
			get
			{
				return this._DogumTarihi;
			}
			set
			{
				if ((this._DogumTarihi != value))
				{
					this.OnDogumTarihiChanging(value);
					this.SendPropertyChanging();
					this._DogumTarihi = value;
					this.SendPropertyChanged("DogumTarihi");
					this.OnDogumTarihiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AktifMi", DbType="Bit NOT NULL")]
		public bool AktifMi
		{
			get
			{
				return this._AktifMi;
			}
			set
			{
				if ((this._AktifMi != value))
				{
					this.OnAktifMiChanging(value);
					this.SendPropertyChanging();
					this._AktifMi = value;
					this.SendPropertyChanged("AktifMi");
					this.OnAktifMiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Der_Ogretmen", Storage="_Der", ThisKey="DersID", OtherKey="DersId", IsForeignKey=true)]
		public Der Der
		{
			get
			{
				return this._Der.Entity;
			}
			set
			{
				Der previousValue = this._Der.Entity;
				if (((previousValue != value) 
							|| (this._Der.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Der.Entity = null;
						previousValue.Ogretmens.Remove(this);
					}
					this._Der.Entity = value;
					if ((value != null))
					{
						value.Ogretmens.Add(this);
						this._DersID = value.DersId;
					}
					else
					{
						this._DersID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Der");
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
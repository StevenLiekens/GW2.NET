﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GW2NET.V1.Items.Converters
{
    using System;

    using GW2NET.Common;
    using GW2NET.Items;
	using ItemDTO = GW2NET.V1.Items.Json.ItemDTO;

    public sealed partial class WeaponConverter : IConverter<ItemDTO, Weapon>
	{
	    private readonly ITypeConverterFactory<ItemDTO, Weapon> converterFactory;

		private WeaponConverter(ITypeConverterFactory<ItemDTO, Weapon> converterFactory)
		{
		    if (converterFactory == null)
    		{
    		    throw new ArgumentNullException("converterFactory");
    		}

		    this.converterFactory = converterFactory;
		}

		 /// <inheritdoc />
        Weapon IConverter<ItemDTO, Weapon>.Convert(ItemDTO value, object state)
		{
		    if (value == null)
    		{
    		    throw new ArgumentNullException("value");
    		}

			string discriminator = value.Weapon == null ? null : value.Weapon.Type;
			var converter = this.converterFactory.Create(discriminator);
			var entity = converter.Convert(value, value);
			this.Merge(entity, value, state);
			return entity;
		}

		// Implement this method in a buddy class to set properties that are specific to 'Weapon' (if any)
    	partial void Merge(Weapon entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class WeaponConverter
		{
		    partial void Merge(Weapon entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
	}

#region Axe
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="Axe"/>.</summary>
    public sealed partial class AxeConverter : IConverter<ItemDTO, Weapon>
    {
	    /// <inheritdoc />
        public Weapon Convert(ItemDTO value, object state)
        {
    		var entity = new Axe();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'Axe' (if any)
    	partial void Merge(Axe entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class AxeConverter
		{
		    partial void Merge(Axe entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region Dagger
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="Dagger"/>.</summary>
    public sealed partial class DaggerConverter : IConverter<ItemDTO, Weapon>
    {
	    /// <inheritdoc />
        public Weapon Convert(ItemDTO value, object state)
        {
    		var entity = new Dagger();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'Dagger' (if any)
    	partial void Merge(Dagger entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class DaggerConverter
		{
		    partial void Merge(Dagger entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region Focus
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="Focus"/>.</summary>
    public sealed partial class FocusConverter : IConverter<ItemDTO, Weapon>
    {
	    /// <inheritdoc />
        public Weapon Convert(ItemDTO value, object state)
        {
    		var entity = new Focus();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'Focus' (if any)
    	partial void Merge(Focus entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class FocusConverter
		{
		    partial void Merge(Focus entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region GreatSword
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="GreatSword"/>.</summary>
    public sealed partial class GreatSwordConverter : IConverter<ItemDTO, Weapon>
    {
	    /// <inheritdoc />
        public Weapon Convert(ItemDTO value, object state)
        {
    		var entity = new GreatSword();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'GreatSword' (if any)
    	partial void Merge(GreatSword entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class GreatSwordConverter
		{
		    partial void Merge(GreatSword entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region Hammer
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="Hammer"/>.</summary>
    public sealed partial class HammerConverter : IConverter<ItemDTO, Weapon>
    {
	    /// <inheritdoc />
        public Weapon Convert(ItemDTO value, object state)
        {
    		var entity = new Hammer();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'Hammer' (if any)
    	partial void Merge(Hammer entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class HammerConverter
		{
		    partial void Merge(Hammer entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region Harpoon
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="Harpoon"/>.</summary>
    public sealed partial class HarpoonConverter : IConverter<ItemDTO, Weapon>
    {
	    /// <inheritdoc />
        public Weapon Convert(ItemDTO value, object state)
        {
    		var entity = new Harpoon();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'Harpoon' (if any)
    	partial void Merge(Harpoon entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class HarpoonConverter
		{
		    partial void Merge(Harpoon entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region LargeBundle
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="LargeBundle"/>.</summary>
    public sealed partial class LargeBundleConverter : IConverter<ItemDTO, Weapon>
    {
	    /// <inheritdoc />
        public Weapon Convert(ItemDTO value, object state)
        {
    		var entity = new LargeBundle();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'LargeBundle' (if any)
    	partial void Merge(LargeBundle entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class LargeBundleConverter
		{
		    partial void Merge(LargeBundle entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region LongBow
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="LongBow"/>.</summary>
    public sealed partial class LongBowConverter : IConverter<ItemDTO, Weapon>
    {
	    /// <inheritdoc />
        public Weapon Convert(ItemDTO value, object state)
        {
    		var entity = new LongBow();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'LongBow' (if any)
    	partial void Merge(LongBow entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class LongBowConverter
		{
		    partial void Merge(LongBow entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region Mace
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="Mace"/>.</summary>
    public sealed partial class MaceConverter : IConverter<ItemDTO, Weapon>
    {
	    /// <inheritdoc />
        public Weapon Convert(ItemDTO value, object state)
        {
    		var entity = new Mace();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'Mace' (if any)
    	partial void Merge(Mace entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class MaceConverter
		{
		    partial void Merge(Mace entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region Pistol
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="Pistol"/>.</summary>
    public sealed partial class PistolConverter : IConverter<ItemDTO, Weapon>
    {
	    /// <inheritdoc />
        public Weapon Convert(ItemDTO value, object state)
        {
    		var entity = new Pistol();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'Pistol' (if any)
    	partial void Merge(Pistol entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class PistolConverter
		{
		    partial void Merge(Pistol entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region Rifle
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="Rifle"/>.</summary>
    public sealed partial class RifleConverter : IConverter<ItemDTO, Weapon>
    {
	    /// <inheritdoc />
        public Weapon Convert(ItemDTO value, object state)
        {
    		var entity = new Rifle();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'Rifle' (if any)
    	partial void Merge(Rifle entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class RifleConverter
		{
		    partial void Merge(Rifle entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region Scepter
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="Scepter"/>.</summary>
    public sealed partial class ScepterConverter : IConverter<ItemDTO, Weapon>
    {
	    /// <inheritdoc />
        public Weapon Convert(ItemDTO value, object state)
        {
    		var entity = new Scepter();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'Scepter' (if any)
    	partial void Merge(Scepter entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class ScepterConverter
		{
		    partial void Merge(Scepter entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region Shield
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="Shield"/>.</summary>
    public sealed partial class ShieldConverter : IConverter<ItemDTO, Weapon>
    {
	    /// <inheritdoc />
        public Weapon Convert(ItemDTO value, object state)
        {
    		var entity = new Shield();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'Shield' (if any)
    	partial void Merge(Shield entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class ShieldConverter
		{
		    partial void Merge(Shield entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region ShortBow
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="ShortBow"/>.</summary>
    public sealed partial class ShortBowConverter : IConverter<ItemDTO, Weapon>
    {
	    /// <inheritdoc />
        public Weapon Convert(ItemDTO value, object state)
        {
    		var entity = new ShortBow();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'ShortBow' (if any)
    	partial void Merge(ShortBow entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class ShortBowConverter
		{
		    partial void Merge(ShortBow entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region SmallBundle
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="SmallBundle"/>.</summary>
    public sealed partial class SmallBundleConverter : IConverter<ItemDTO, Weapon>
    {
	    /// <inheritdoc />
        public Weapon Convert(ItemDTO value, object state)
        {
    		var entity = new SmallBundle();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'SmallBundle' (if any)
    	partial void Merge(SmallBundle entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class SmallBundleConverter
		{
		    partial void Merge(SmallBundle entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region SpearGun
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="SpearGun"/>.</summary>
    public sealed partial class SpearGunConverter : IConverter<ItemDTO, Weapon>
    {
	    /// <inheritdoc />
        public Weapon Convert(ItemDTO value, object state)
        {
    		var entity = new SpearGun();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'SpearGun' (if any)
    	partial void Merge(SpearGun entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class SpearGunConverter
		{
		    partial void Merge(SpearGun entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region Staff
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="Staff"/>.</summary>
    public sealed partial class StaffConverter : IConverter<ItemDTO, Weapon>
    {
	    /// <inheritdoc />
        public Weapon Convert(ItemDTO value, object state)
        {
    		var entity = new Staff();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'Staff' (if any)
    	partial void Merge(Staff entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class StaffConverter
		{
		    partial void Merge(Staff entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region Sword
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="Sword"/>.</summary>
    public sealed partial class SwordConverter : IConverter<ItemDTO, Weapon>
    {
	    /// <inheritdoc />
        public Weapon Convert(ItemDTO value, object state)
        {
    		var entity = new Sword();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'Sword' (if any)
    	partial void Merge(Sword entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class SwordConverter
		{
		    partial void Merge(Sword entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region Torch
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="Torch"/>.</summary>
    public sealed partial class TorchConverter : IConverter<ItemDTO, Weapon>
    {
	    /// <inheritdoc />
        public Weapon Convert(ItemDTO value, object state)
        {
    		var entity = new Torch();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'Torch' (if any)
    	partial void Merge(Torch entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class TorchConverter
		{
		    partial void Merge(Torch entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region Toy
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="Toy"/>.</summary>
    public sealed partial class ToyConverter : IConverter<ItemDTO, Weapon>
    {
	    /// <inheritdoc />
        public Weapon Convert(ItemDTO value, object state)
        {
    		var entity = new Toy();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'Toy' (if any)
    	partial void Merge(Toy entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class ToyConverter
		{
		    partial void Merge(Toy entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region Trident
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="Trident"/>.</summary>
    public sealed partial class TridentConverter : IConverter<ItemDTO, Weapon>
    {
	    /// <inheritdoc />
        public Weapon Convert(ItemDTO value, object state)
        {
    		var entity = new Trident();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'Trident' (if any)
    	partial void Merge(Trident entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class TridentConverter
		{
		    partial void Merge(Trident entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region TwoHandedToy
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="TwoHandedToy"/>.</summary>
    public sealed partial class TwoHandedToyConverter : IConverter<ItemDTO, Weapon>
    {
	    /// <inheritdoc />
        public Weapon Convert(ItemDTO value, object state)
        {
    		var entity = new TwoHandedToy();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'TwoHandedToy' (if any)
    	partial void Merge(TwoHandedToy entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class TwoHandedToyConverter
		{
		    partial void Merge(TwoHandedToy entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region UnknownWeapon
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="UnknownWeapon"/>.</summary>
    public sealed partial class UnknownWeaponConverter : IConverter<ItemDTO, Weapon>
    {
	    /// <inheritdoc />
        public Weapon Convert(ItemDTO value, object state)
        {
    		var entity = new UnknownWeapon();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'UnknownWeapon' (if any)
    	partial void Merge(UnknownWeapon entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class UnknownWeaponConverter
		{
		    partial void Merge(UnknownWeapon entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region WarHorn
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="WarHorn"/>.</summary>
    public sealed partial class WarHornConverter : IConverter<ItemDTO, Weapon>
    {
	    /// <inheritdoc />
        public Weapon Convert(ItemDTO value, object state)
        {
    		var entity = new WarHorn();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'WarHorn' (if any)
    	partial void Merge(WarHorn entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class WarHornConverter
		{
		    partial void Merge(WarHorn entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

}

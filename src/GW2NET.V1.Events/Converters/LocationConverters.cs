﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GW2NET.V1.Events.Converters
{
    using System;

    using GW2NET.Common;
    using GW2NET.DynamicEvents;
	using LocationDTO = GW2NET.V1.Events.Json.LocationDTO;

    public sealed partial class LocationConverter : IConverter<LocationDTO, Location>
	{
	    private readonly ITypeConverterFactory<LocationDTO, Location> converterFactory;

		private LocationConverter(ITypeConverterFactory<LocationDTO, Location> converterFactory)
		{
		    if (converterFactory == null)
    		{
    		    throw new ArgumentNullException("converterFactory");
    		}

		    this.converterFactory = converterFactory;
		}

		 /// <inheritdoc />
        Location IConverter<LocationDTO, Location>.Convert(LocationDTO value, object state)
		{
		    if (value == null)
    		{
    		    throw new ArgumentNullException("value");
    		}

			string discriminator = value.Type;
			var converter = this.converterFactory.Create(discriminator);
			var entity = converter.Convert(value, value);
			this.Merge(entity, value, state);
			return entity;
		}

		// Implement this method in a buddy class to set properties that are specific to 'Location' (if any)
    	partial void Merge(Location entity, LocationDTO dto, object state);

		/*
		// Use this template
		public partial class LocationConverter
		{
		    partial void Merge(Location entity, LocationDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
	}

#region CylinderLocation
    /// <summary>Converts objects of type <see cref="LocationDTO"/> to objects of type <see cref="CylinderLocation"/>.</summary>
    public sealed partial class CylinderLocationConverter : IConverter<LocationDTO, Location>
    {
	    /// <inheritdoc />
        public Location Convert(LocationDTO value, object state)
        {
    		var entity = new CylinderLocation();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'CylinderLocation' (if any)
    	partial void Merge(CylinderLocation entity, LocationDTO dto, object state);

		/*
		// Use this template
		public partial class CylinderLocationConverter
		{
		    partial void Merge(CylinderLocation entity, LocationDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region PolygonLocation
    /// <summary>Converts objects of type <see cref="LocationDTO"/> to objects of type <see cref="PolygonLocation"/>.</summary>
    public sealed partial class PolygonLocationConverter : IConverter<LocationDTO, Location>
    {
	    /// <inheritdoc />
        public Location Convert(LocationDTO value, object state)
        {
    		var entity = new PolygonLocation();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'PolygonLocation' (if any)
    	partial void Merge(PolygonLocation entity, LocationDTO dto, object state);

		/*
		// Use this template
		public partial class PolygonLocationConverter
		{
		    partial void Merge(PolygonLocation entity, LocationDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region SphereLocation
    /// <summary>Converts objects of type <see cref="LocationDTO"/> to objects of type <see cref="SphereLocation"/>.</summary>
    public sealed partial class SphereLocationConverter : IConverter<LocationDTO, Location>
    {
	    /// <inheritdoc />
        public Location Convert(LocationDTO value, object state)
        {
    		var entity = new SphereLocation();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'SphereLocation' (if any)
    	partial void Merge(SphereLocation entity, LocationDTO dto, object state);

		/*
		// Use this template
		public partial class SphereLocationConverter
		{
		    partial void Merge(SphereLocation entity, LocationDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region UnknownLocation
    /// <summary>Converts objects of type <see cref="LocationDTO"/> to objects of type <see cref="UnknownLocation"/>.</summary>
    public sealed partial class UnknownLocationConverter : IConverter<LocationDTO, Location>
    {
	    /// <inheritdoc />
        public Location Convert(LocationDTO value, object state)
        {
    		var entity = new UnknownLocation();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'UnknownLocation' (if any)
    	partial void Merge(UnknownLocation entity, LocationDTO dto, object state);

		/*
		// Use this template
		public partial class UnknownLocationConverter
		{
		    partial void Merge(UnknownLocation entity, LocationDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

}
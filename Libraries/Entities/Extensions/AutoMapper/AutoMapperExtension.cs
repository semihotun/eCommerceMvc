﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Linq.Expressions;
namespace Entities.Extensions.AutoMapper
{
    public static class AutoMapperExtension
    {
        public static void AutoMapperSettings(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AuthoMapperProfile());
                mc.AddProfile(new AdminAuthoMapperProfile());
            });
            IMapper mapper = AutoMapperConfig.Get().CreateMapper();
            services.AddSingleton(mapper);
        }
        public static IQueryable<TDestination> MapTo<TDestination>(
            this IQueryable source,
            params Expression<Func<TDestination, object>>[] membersToExpand
        )
        {
            return source.ProjectTo<TDestination>(AutoMapperConfig.Get(), null, membersToExpand);
        }
        public static T MapTo<T>(this object src)
        {
            IMapper mapper = new Mapper(AutoMapperConfig.Get());
            return (T)mapper.Map(src, src.GetType(), typeof(T));
        }
        public static TDest MapTo<T, TDest>(this T src, TDest data)
        {
            IMapper mapper = new Mapper(AutoMapperConfig.Get());
            return mapper.Map<T, TDest>(src, data);
        }
        public static T MapTo<T>(this T src, T data)
        {
            IMapper mapper = new Mapper(AutoMapperConfig.Get());
            return mapper.Map<T, T>(data, src);
        }
        //public static TTarget MapTo<TSource, TTarget>(this TSource aSource, TTarget aTarget)
        //{
        //    const BindingFlags flags = BindingFlags.Public |
        //                               BindingFlags.Instance | BindingFlags.NonPublic;
        //    
        //    var srcFields = (from PropertyInfo aProp in typeof(TSource).GetProperties(flags)
        //        where aProp.CanRead     //check if prop is readable
        //        select new
        //        {
        //            Name = aProp.Name,
        //            Type = Nullable.GetUnderlyingType(aProp.PropertyType) ??
        //                   aProp.PropertyType
        //        }).ToList();
        //    var trgFields = (from PropertyInfo aProp in aTarget.GetType().GetProperties(flags)
        //        where aProp.CanWrite   //check if prop is writeable
        //        select new
        //        {
        //            Name = aProp.Name,
        //            Type = Nullable.GetUnderlyingType(aProp.PropertyType) ??
        //                   aProp.PropertyType
        //        }).ToList();
        //    var commonFields = srcFields.Intersect(trgFields).ToList();
        //    /*assign values*/
        //    foreach (var aField in commonFields)
        //    {
        //        var value = aSource.GetType().GetProperty(aField.Name).GetValue(aSource, null);
        //        PropertyInfo propertyInfos = aTarget.GetType().GetProperty(aField.Name);
        //        propertyInfos.SetValue(aTarget, value, null);
        //    }
        //    return aTarget;
        //}
        //public static TTarget CreateMapped<TSource, TTarget>(this TSource aSource) where TTarget : new()
        //{
        //    return aSource.MapTo(new TTarget());
        //}
    }
}

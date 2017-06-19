using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BizzLayer
{
    public static class ManagerService
    {
        public static IQueryable<Client> GetClients(Client searchCrit)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var result = from el in dc.Client
                             where
                             String.IsNullOrEmpty(searchCrit.last_name) || el.last_name.StartsWith(searchCrit.last_name)
                             &&
                             String.IsNullOrEmpty(searchCrit.first_name) || el.first_name.StartsWith(searchCrit.first_name)
                             &&
                             String.IsNullOrEmpty(searchCrit.city) || el.city.StartsWith(searchCrit.city)
                             &&
                             String.IsNullOrEmpty(searchCrit.flat) || el.flat.StartsWith(searchCrit.flat)
                             &&
                             String.IsNullOrEmpty(searchCrit.home) || el.home.StartsWith(searchCrit.home)
                             &&
                             String.IsNullOrEmpty(searchCrit.street) || el.street.StartsWith(searchCrit.street)
                             select el;
                return result;
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static void UpdateClient(Client client)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var result = (from el in dc.Client
                              where
                              el.id_client == client.id_client
                              select el).SingleOrDefault();
                if(result==null)
                {
                    return;
                }
                result.name = client.name;
                result.last_name = client.name;
                result.home = client.home;
                result.city = client.city;
                result.flat = client.flat;
                result.street = client.street;
                dc.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static void DeleteClient(Client client)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var res = (from el in dc.Client
                           where el.id_client == client.id_client
                           select el).SingleOrDefault();
                if (res == null)
                {
                    return;
                }
                dc.Client.Remove(res);
                dc.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static void NewClient(Client client)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                //var res = (from el in dc.Client
                  //         where el.username == personel.username
                    //       select el).SingleOrDefault();
                //if (res == null)
                //{
                    dc.Client.Add(client);
                    dc.SaveChanges();
                    return;
                //}
                //throw new ServiceException("Username already exists!");
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static IQueryable<DataLayer.Object> GetObjects(DataLayer.Object searchCrit)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var result = from el in dc.Object
                             where
                             String.IsNullOrEmpty(searchCrit.body_type) || el.body_type.StartsWith(searchCrit.body_type)
                             &&
                             (searchCrit.id_client == null) || (el.id_client == searchCrit.id_client)
                             &&
                             String.IsNullOrEmpty(searchCrit.manufacturer) || el.manufacturer.StartsWith(searchCrit.manufacturer)
                             &&
                             String.IsNullOrEmpty(searchCrit.model) || el.model.StartsWith(searchCrit.model)
                             &&
                             String.IsNullOrEmpty(searchCrit.name) || el.name.StartsWith(searchCrit.name)
                             &&
                             String.IsNullOrEmpty(searchCrit.other) || el.other.StartsWith(searchCrit.other)
                             &&
                             String.IsNullOrEmpty(searchCrit.engine) || el.other.StartsWith(searchCrit.engine)
                             &&
                             (searchCrit.year == null) || (el.year == searchCrit.year)
                             select el;
                return result;
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static void UpdateObjects(DataLayer.Object obj)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var result = (from el in dc.Object
                              where
                              el.id_object == obj.id_object
                              select el).SingleOrDefault();
                if (result == null)
                {
                    return;
                }
                result.name = obj.name;
                result.body_type = obj.body_type;
                result.id_client = obj.id_client;
                result.manufacturer = obj.manufacturer;
                result.model = obj.model;
                result.other = obj.other;
                result.year = obj.year;
                result.engine = obj.engine;
                dc.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static void DeleteObject(DataLayer.Object obj)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var res = (from el in dc.Object
                           where el.id_object == obj.id_object
                           select el).SingleOrDefault();
                if (res == null)
                {
                    return;
                }
                dc.Object.Remove(res);
                dc.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static IQueryable<Request> GetRequests(Request searchCrit)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var result = from el in dc.Request
                             where
                             String.IsNullOrEmpty(searchCrit.description) || el.description.StartsWith(searchCrit.description)
                             &&
                             (searchCrit.id_activity == null) || (el.id_activity == searchCrit.id_activity)
                             &&
                             (searchCrit.id_object == null) || (el.id_object == searchCrit.id_object)
                             &&
                             (searchCrit.id_personel == null) || (el.id_personel == searchCrit.id_personel)
                             &&
                             String.IsNullOrEmpty(searchCrit.status) || el.status.StartsWith(searchCrit.status)
                             &&
                             String.IsNullOrEmpty(searchCrit.result) || el.result.StartsWith(searchCrit.result)
                             &&
                             (searchCrit.date_fin_cancel == null) || (el.date_fin_cancel == searchCrit.date_fin_cancel)
                             &&
                             (searchCrit.date_request == null) || (el.date_request == searchCrit.date_request)
                             select el;
                return result;
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static void UpdateRequest(Request request)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var result = (from el in dc.Request
                              where
                              el.id_request == request.id_request
                              select el).SingleOrDefault();
                if (result == null)
                {
                    return;
                }
                result.date_fin_cancel = request.date_fin_cancel;
                result.date_request = request.date_request;
                result.description = request.description;
                result.id_activity = request.id_activity;
                result.id_object = request.id_object;
                result.id_personel = request.id_personel;
                result.result = request.result;
                result.status = request.status;
                dc.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static void DeleteRequest(Request request)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var res = (from el in dc.Request
                           where el.id_request == request.id_request
                           select el).SingleOrDefault();
                if (res == null)
                {
                    return;
                }
                dc.Request.Remove(res);
                dc.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static IQueryable<Activity> GetActivities(Activity searchCrit)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var result = from el in dc.Activity
                             where
                             String.IsNullOrEmpty(searchCrit.description) || el.description.StartsWith(searchCrit.description)
                             &&
                             (searchCrit.id_personel == null) || (el.id_personel == searchCrit.id_personel)
                             &&
                             String.IsNullOrEmpty(searchCrit.status) || el.status.StartsWith(searchCrit.status)
                             &&
                             String.IsNullOrEmpty(searchCrit.result) || el.result.StartsWith(searchCrit.result)
                             &&
                             (searchCrit.date_fin_cancel == null) || (el.date_fin_cancel == searchCrit.date_fin_cancel)
                             &&
                             (searchCrit.date_request == null) || (el.date_request == searchCrit.date_request)
                             &&
                             String.IsNullOrEmpty(searchCrit.act_type) || el.act_type.StartsWith(searchCrit.act_type)
                             &&
                             (searchCrit.seq_no == null) || (el.seq_no == searchCrit.seq_no)
                             select el;
                return result;
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static void UpdateActivity(Activity request)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var result = (from el in dc.Activity
                              where
                              el.id_request == request.id_request
                              select el).SingleOrDefault();
                if (result == null)
                {
                    return;
                }
                result.date_fin_cancel = request.date_fin_cancel;
                result.date_request = request.date_request;
                result.description = request.description;
                result.id_activity = request.id_activity;
                result.id_personel = request.id_personel;
                result.result = request.result;
                result.status = request.status;
                result.act_type = request.act_type;
                result.seq_no = request.seq_no;
                dc.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static void DeleteActivity(Activity activity)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var res = (from el in dc.Activity
                           where el.id_activity == activity.id_activity
                           select el).SingleOrDefault();
                if (res == null)
                {
                    return;
                }
                dc.Activity.Remove(res);
                dc.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }
    }
}

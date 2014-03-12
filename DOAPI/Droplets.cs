using DigitalOcean.Structs;
using RestSharp;

namespace DigitalOcean
{
    public partial class DOClient
    {
        public virtual Droplets GetDroplets()
        {
            var request = new RestRequest();
            request.Resource = "droplets/";
            return Execute<Droplets>(request);
        }

        /// <summary>
        ///     Create a new Droplet
        /// </summary>
        /// <param name="name">Name of the droplet - must be formatted by hostname rules</param>
        /// <param name="size_id">The ID of the size you'd like the server to be.</param>
        /// <param name="image_id">The ID of the image you'd like to be used.</param>
        /// <param name="region_id">The ID of the region you'd like the droplet in.</param>
        /// <param name="ssh_key_ids">
        ///     Numeric CSV, comma separated list of ssh_key_ids that you would like to be added to the
        ///     server.
        /// </param>
        /// <param name="private_networking">
        ///     if set to <c>true</c> and the region supports it private networking will be enabledm
        ///     disabled by default.
        /// </param>
        /// <param name="backups_enabled">if set to <c>true</c> backups will be enabled, disabled by default.</param>
        /// <typeparam name="T">The type of object to create and populate with the returned data.</typeparam>
        public virtual CreateDropletStatus CreateDroplet(string name, int size_id, int image_id, int region_id,
            string ssh_key_ids = "", bool private_networking = false, bool backups_enabled = false)
        {
            var request = new RestRequest();
            request.Resource = "droplets/new";
            request.AddParameter("name", name);
            request.AddParameter("size_id", size_id);
            request.AddParameter("image_id", image_id);
            request.AddParameter("region_id", region_id);
            request.AddParameter("private_networking", private_networking);
            request.AddParameter("backups_enabled", backups_enabled);
            request.AddParameter("ssh_key_ids", ssh_key_ids);
            return Execute<CreateDropletStatus>(request);
        }

        public virtual Event RestartDroplet(int server_id)
        {
            var request = new RestRequest();
            request.Resource = "droplets/" + server_id + "/reboot/";
            return Execute<Event>(request);
        }

        public virtual Event PowercycleDroplet(int server_id)
        {
            var request = new RestRequest();
            request.Resource = "droplets/" + server_id + "/power_cycle/";
            return Execute<Event>(request);
        }

        public virtual Event ShutdownDroplet(int server_id)
        {
            var request = new RestRequest();
            request.Resource = "droplets/" + server_id + "/shutdown/";
            return Execute<Event>(request);
        }

        public virtual Event PoweroffDroplet(int server_id)
        {
            var request = new RestRequest();
            request.Resource = "droplets/" + server_id + "/power_off/";
            return Execute<Event>(request);
        }

        public virtual Event PoweronDroplet(int server_id)
        {
            var request = new RestRequest();
            request.Resource = "droplets/" + server_id + "/power_on/";
            return Execute<Event>(request);
        }

        public virtual Event ResetPasswordDroplet(int server_id)
        {
            var request = new RestRequest();
            request.Resource = "droplets/" + server_id + "/password_reset/";
            return Execute<Event>(request);
        }

        public virtual Event ResizeDroplet(int server_id, int size_id)
        {
            var request = new RestRequest();
            request.Resource = "droplets/" + server_id + "/resize/";
            request.AddParameter("size_id", size_id);
            return Execute<Event>(request);
        }

        public virtual Event SnapshotDroplet(int server_id, string snapshot_name = "")
        {
            var request = new RestRequest();
            request.Resource = "droplets/" + server_id + "/snapshot/";
            if (snapshot_name != "")
            {
                request.AddParameter("name", snapshot_name);
            }
            return Execute<Event>(request);
        }

        public virtual Event RestoreDroplet(int server_id, int image_id)
        {
            var request = new RestRequest();
            request.Resource = "droplets/" + server_id + "/restore/";
            request.AddParameter("image_id ", image_id);
            return Execute<Event>(request);
        }

        public virtual Event RebuildeDroplet(int server_id, int image_id)
        {
            var request = new RestRequest();
            request.Resource = "droplets/" + server_id + "/rebuild/";
            request.AddParameter("image_id ", image_id);
            return Execute<Event>(request);
        }

        public virtual Event RenameDroplet(int server_id, int name)
        {
            var request = new RestRequest();
            request.Resource = "droplets/" + server_id + "/rename/";
            request.AddParameter("name ", name);
            return Execute<Event>(request);
        }

        public virtual Event DestroyDroplet(int server_id, bool scrub_data = false)
        {
            var request = new RestRequest();
            request.Resource = "droplets/" + server_id + "/destroy/";
            request.AddParameter("scrub_data ", scrub_data);
            return Execute<Event>(request);
        }
    }
}
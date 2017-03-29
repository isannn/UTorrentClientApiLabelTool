using System;
using System.Collections.Generic;
using System.Linq;
using UTorrent.Api;
using UTorrent.Api.Data;

namespace UTorrent.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new UTorrentClient("127.0.0.1",8088,"admin", "111111");
            //client.SetSetting("port", 8088);
            var response = client.GetList();
            List<Torrent> torrents = response.Result.Torrents.ToList();
            foreach (var torrent in torrents)
            {
                Console.WriteLine(torrent.Name);
            }
            List<Label> labelsList = response.Result.Label.ToList();
            foreach (var label in labelsList)
            {
                Console.WriteLine($"{label.Name}:{label.Count}");
            }

        }
    }
}


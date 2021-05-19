﻿using System;
using MySql.Data;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			// Alle namen ophalen
			var names = GetNames();

			// Stop de namen in de html
			return View(names);
		}

		public List<string> GetNames()
		{
			// stel in waar de database gevonden kan worden
			string connectionString = "Server=172.16.160.21;Port=3306;Database=fastfood;Uid=lgg;Pwd=0P%Y9fI2GdO#;";

			// maak een lege lijst waar we de namen in gaan opslaan
			List<string> names = new List<string>();

			// verbinding maken met de database
			using (MySqlConnection conn = new MySqlConnection(connectionString))
			{
				// verbinding openen
				conn.Open();

				// SQL query die we willen uitvoeren
				MySqlCommand cmd = new MySqlCommand("select * from product", conn);

				// resultaat van de query lezen
				using (var reader = cmd.ExecuteReader())
				{
					// elke keer een regel (of eigenlijk: database rij) lezen
					while (reader.Read())
					{
						// selecteer de kolommen die je wil lezen. In dit geval kiezen we de kolom "naam"
						string Name = reader["Naam"].ToString();

						// voeg de naam toe aan de lijst met namen
						names.Add(Name);
					}
				}
			}

			// return de lijst met namen
			return names;
		}


		[Route("privacy")]
		public IActionResult Privacy()
		{
			return View();
		}

		[Route("locatie")]
		public IActionResult locatie()
		{
			return View();
		}

		public IActionResult ShowAll()
		{
			return View();
		}

		[Route("contact")]
		public IActionResult Contact()
		{
			return View();
		}


		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}

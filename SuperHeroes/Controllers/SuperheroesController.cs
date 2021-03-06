﻿using SuperHeroes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHeroes.Controllers
{
    public class SuperheroesController : Controller
    {
        ApplicationDbContext context;
        public SuperheroesController()
        {
            context = new ApplicationDbContext();
        }
        // GET: Superheroes
        public ActionResult Index()
        {
            IEnumerable<SuperHeroes.Models.SuperHero> index = context.superHeroes.AsEnumerable();
            return View(index);
        }

        // GET: Superheroes/Details/5
        public ActionResult Details(int id)
        {
            SuperHero superHero = context.superHeroes.Where(c => c.id == id).Single();
            return View(superHero);
        }

        // GET: Superheroes/Create
        public ActionResult Create()
        { SuperHero superHero = new SuperHero();
            return View(superHero);
        }

        // POST: Superheroes/Create
        [HttpPost]
        public ActionResult Create(SuperHero superHero)
        {
            try
            {
                // TODO: Add insert logic here
                context.superHeroes.Add(superHero);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheroes/Edit/5
        public ActionResult Edit(int id)
        {
            SuperHero superHero = context.superHeroes.Where(c => c.id == id).Single();
            return View(superHero);
        }

        // POST: Superheroes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SuperHero superHero)
        {
            try
            {
                // TODO: Add update logic here

                SuperHero superHeroe = context.superHeroes.Where(c => c.id == id).Single();
                superHeroe.name = superHero.name;
                superHeroe.alterEgo = superHero.alterEgo;
                superHeroe.primaryAbilies = superHero.primaryAbilies;
                superHeroe.secondaryAbilities = superHero.secondaryAbilities;
                superHeroe.catchphrase = superHero.catchphrase;
                
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheroes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            SuperHero superHero = context.superHeroes.Where(c => c.id == id).Single();
            return View( superHero);
        }

        // POST: Superheroes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                SuperHero superHero = context.superHeroes.Where(c => c.id == id).Single();
                context.superHeroes.Remove(superHero);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

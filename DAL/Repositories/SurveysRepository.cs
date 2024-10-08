﻿using DAL.Context;
using DAL.Entities;


namespace DAL.Repositories;

public interface ISurveysRepository
{
    Survey? GetSurveyById(int id);
}

internal class SurveysRepository(SomeCoolContext context) : Repository<Survey>(context), ISurveysRepository
{
    public Survey? GetSurveyById(int id) => GetById(id);
}
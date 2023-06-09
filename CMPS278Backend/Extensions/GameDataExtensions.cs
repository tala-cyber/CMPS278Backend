﻿using CMPS278Backend.Models.Games;
using CMPS278Backend.ModelsDTO.GameDTOs;

namespace CMPS278Backend.Extensions;

public static class GameDataExtensions
{
    public static GameData ToGameData(this GameDataDTO data)
    {
        GameData gameData = data.ToBaseDataModel<GameData>();
        gameData.Reviews = data.Reviews.Select(review => review.ToGameReview()).ToList();
        return gameData;
    }
    
    public static GameDataDTO ToGameDataDTO(this GameData data)
    {
        GameDataDTO appData = data.ToBaseDataModelDTO<GameDataDTO>();
        appData.Reviews = data.Reviews.Select(review => review.ToGameReviewDTO()).ToList();
        return appData;
    }
}
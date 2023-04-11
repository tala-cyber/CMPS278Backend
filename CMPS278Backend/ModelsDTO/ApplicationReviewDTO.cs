﻿namespace CMPS278Backend.ModelsDTO;

public class ApplicationReviewDTO
{
    public string  Id        { get; set; }
    public string? UserName  { get; set; }
    public string? UserImage { get; set; }
    public string? Date      { get; set; }
    public float?  Score     { get; set; }
    public string? ScoreText { get; set; }
    public string? Url       { get; set; }
    public string? Title     { get; set; }
    public string? Text      { get; set; }
    public string? ReplyDate { get; set; }
    public string? ReplyText { get; set; }
    public string? Version   { get; set; }
    public int?    ThumbsUp  { get; set; }
}
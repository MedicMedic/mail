﻿namespace MerrMail.Domain.Common;

public class EmailReplyBuilder
{
    private string? _header;
    private string? _introduction;
    private string? _message;
    private string? _conclusion;
    private string? _closing;
    private string? _signature;

    public EmailReplyBuilder SetHeader(string header)
    {
        _header = header;
        return this;
    }

    public EmailReplyBuilder SetIntroduction(string introduction)
    {
        _introduction = introduction;
        return this;
    }

    public EmailReplyBuilder SetMessage(string systemMessage)
    {
        _message = systemMessage;
        return this;
    }

    public EmailReplyBuilder SetConclusion(string conclusion)
    {
        _conclusion = conclusion;
        return this;
    }

    public EmailReplyBuilder SetClosing(string closing)
    {
        _closing = closing;
        return this;
    }

    public EmailReplyBuilder SetSignature(string signature)
    {
        _signature = signature;
        return this;
    }

    public string Build()
    {
        return $"""
                 <!DOCTYPE html>
                 <html lang="en">
                   <head>
                     <meta charset="UTF-8" />
                     <meta name="viewport" content="width=device-width, initial-scale=1.0" />
                     <title>{_header}</title>
                   </head>
                   <body
                     style="
                       font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
                       background-color: #f0f0f0;
                       color: #333;
                       padding: 20px;
                     "
                   >
                     <div
                       style="
                         max-width: 600px;
                         margin: 0 auto;
                         background-color: #fff;
                         padding: 20px;
                         border-radius: 10px;
                         box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
                       "
                     >
                       <h1 style="color: #3498db; text-align: center">{_header}</h1>
                 
                       <p style="color: #555; text-align: center">{_introduction}</p>
                 
                       <p
                         style="
                           color: #888;
                           text-align: center;
                           font-size: 16px;
                           font-weight: bold;
                         "
                       >
                         {_message}
                       </p>
                 
                       <p style="color: #555; text-align: center">{_conclusion}</p>
                 
                       <p style="color: #555; text-align: center">
                         {_closing},<br />
                         <span style="color: #e74c3c">{_signature}</span>
                       </p>
                 
                       <p
                         style="
                           color: #888;
                           text-align: center;
                           font-size: 10px;
                           margin-top: 10px;
                         "
                       >
                         This reply is auto-generated by MerrMail.
                       </p>
                     </div>
                   </body>
                 </html>
                 """;
    }
}
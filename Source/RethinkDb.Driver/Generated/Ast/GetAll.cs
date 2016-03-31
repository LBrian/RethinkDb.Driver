














//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591 // Missing XML comment for publicly visible type or member
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public partial class GetAll : ReqlExpr {

    
    
    
/// <summary>
/// <para>Get all documents where the given value matches the value of the requested index.</para>
/// </summary>
/// <example><para>Example: Secondary index keys are not guaranteed to be unique so we cannot query via <a href="/api/javascript/get/">get</a> when using a secondary index.</para>
/// <code>r.table('marvel').getAll('man_of_steel', {index:'code_name'}).run(conn, callback)
/// </code></example>
        public GetAll (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Get all documents where the given value matches the value of the requested index.</para>
/// </summary>
/// <example><para>Example: Secondary index keys are not guaranteed to be unique so we cannot query via <a href="/api/javascript/get/">get</a> when using a secondary index.</para>
/// <code>r.table('marvel').getAll('man_of_steel', {index:'code_name'}).run(conn, callback)
/// </code></example>
        public GetAll (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Get all documents where the given value matches the value of the requested index.</para>
/// </summary>
/// <example><para>Example: Secondary index keys are not guaranteed to be unique so we cannot query via <a href="/api/javascript/get/">get</a> when using a secondary index.</para>
/// <code>r.table('marvel').getAll('man_of_steel', {index:'code_name'}).run(conn, callback)
/// </code></example>
        public GetAll (Arguments args, OptArgs optargs)
         : base(TermType.GET_ALL, args, optargs) {
        }


    



    
///<summary>
/// "index": "T_STR"
///</summary>
        public GetAll this[object optArgs] {
            get
            {
                var newOptArgs = OptArgs.FromMap(this.OptArgs).With(optArgs);
        
                return new GetAll (this.Args, newOptArgs);
            }
        }
        
///<summary>
/// "index": "T_STR"
///</summary>
    public GetAll this[OptArgs optArgs] {
        get
        {
            var newOptArgs = OptArgs.FromMap(this.OptArgs).With(optArgs);
    
            return new GetAll (this.Args, newOptArgs);
        }
    }
    
///<summary>
/// "index": "T_STR"
///</summary>
        public GetAll OptArg(string key, object val){
            
            var newOptArgs = OptArgs.FromMap(this.OptArgs).With(key, val);
        
            return new GetAll (this.Args, newOptArgs);
        }
        internal GetAll optArg(string key, object val){
        
            return this.OptArg(key, val);
        }


    

    
        /// <summary>
        /// Get a single field from an object. If called on a sequence, gets that field from every object in the sequence, skipping objects that lack it.
        /// </summary>
        /// <param name="bracket"></param>
        public new Bracket this[string bracket] => base[bracket];
        
        /// <summary>
        /// Get the nth element of a sequence, counting from zero. If the argument is negative, count from the last element.
        /// </summary>
        /// <param name="bracket"></param>
        /// <returns></returns>
        public new Bracket this[int bracket] => base[bracket];


    

    


    
    }
}

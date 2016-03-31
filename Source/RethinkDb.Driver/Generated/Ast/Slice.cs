














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

    public partial class Slice : ReqlExpr {

    
    
    
/// <summary>
/// <para>Return the elements of a sequence within the specified range.</para>
/// <para>Example: Return the fourth, fifth and sixth youngest players. (The youngest player is at index 0, so those are elements 3-5.)</para>
/// <para><code>js
/// r.table('players').orderBy({index: 'age'}).slice(3,6).run(conn, callback)</code></para>
/// </summary>
/// <example></example>
        public Slice (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Return the elements of a sequence within the specified range.</para>
/// <para>Example: Return the fourth, fifth and sixth youngest players. (The youngest player is at index 0, so those are elements 3-5.)</para>
/// <para><code>js
/// r.table('players').orderBy({index: 'age'}).slice(3,6).run(conn, callback)</code></para>
/// </summary>
/// <example></example>
        public Slice (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Return the elements of a sequence within the specified range.</para>
/// <para>Example: Return the fourth, fifth and sixth youngest players. (The youngest player is at index 0, so those are elements 3-5.)</para>
/// <para><code>js
/// r.table('players').orderBy({index: 'age'}).slice(3,6).run(conn, callback)</code></para>
/// </summary>
/// <example></example>
        public Slice (Arguments args, OptArgs optargs)
         : base(TermType.SLICE, args, optargs) {
        }


    



    
///<summary>
/// "left_bound": "E_BOUND",
///  "right_bound": "E_BOUND"
///</summary>
        public Slice this[object optArgs] {
            get
            {
                var newOptArgs = OptArgs.FromMap(this.OptArgs).With(optArgs);
        
                return new Slice (this.Args, newOptArgs);
            }
        }
        
///<summary>
/// "left_bound": "E_BOUND",
///  "right_bound": "E_BOUND"
///</summary>
    public Slice this[OptArgs optArgs] {
        get
        {
            var newOptArgs = OptArgs.FromMap(this.OptArgs).With(optArgs);
    
            return new Slice (this.Args, newOptArgs);
        }
    }
    
///<summary>
/// "left_bound": "E_BOUND",
///  "right_bound": "E_BOUND"
///</summary>
        public Slice OptArg(string key, object val){
            
            var newOptArgs = OptArgs.FromMap(this.OptArgs).With(key, val);
        
            return new Slice (this.Args, newOptArgs);
        }
        internal Slice optArg(string key, object val){
        
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

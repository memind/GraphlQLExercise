﻿using GraphQL.Types;

namespace GraphlQLExercise.GraphQL.Type
{
    public class MenuInputType : InputObjectGraphType
    {
        public MenuInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("description");
            Field<FloatGraphType>("price");
            Field<StringGraphType>("imageurl");
            Field<IntGraphType>("categoryId");
        }
    }
}

const Sequelize = require('sequelize');

module.exports = function(sequelize){
    const Film = sequelize.define('Film' ,{
        name: {
            type: Sequelize.TEXT,
            allowNull: false,
            required: true
        },
        genre: {
            type: Sequelize.TEXT,
            allowNull: false,
            required: true
        },
        director: {
            type: Sequelize.TEXT,
            allowNull: false,
            required: true
        },
        year: {
            type: Sequelize.INTEGER,
            allowNull: false,
            required: true
        }
    });

    return Film;

    //DONE
};
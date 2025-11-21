import React from 'react';
import { Card } from 'antd';
import { Link } from 'react-router-dom';

import NoImage from '../img/Noimage.png';

function BookCard({ Book }) {
    const { id, title, coverImage, authorName, genreName, publishedYear } = Book;

    return (
        <Card
            hoverable
            className='card'
            cover={
                <Link to={`book/${id}`}>
                    <img
                        className="book-image"
                        draggable={false}
                        alt={title}
                        src={coverImage == null ? NoImage : coverImage}
                    />
                </Link>
            }
        >
            <div style={{ paddingTop: 8 }}>
                <h3 style={{ margin: '0 0 8px 0' }}>{title}</h3>
                <p style={{ margin: 0, color: '#555' }}>{authorName || 'Unknown Author'}</p>
                <p style={{ margin: '4px 0 0 0', color: '#777', fontSize: 12 }}>
                    {genreName || 'Unknown Genre'} {publishedYear ? `• ${publishedYear}` : ''}
                </p>
            </div>
        </Card>
    );
}

export default BookCard;
